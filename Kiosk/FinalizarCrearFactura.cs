using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Drawing.Printing;

namespace Kiosk
{
    public partial class FinalizarCrearFactura : Form
    {
        public OleDbDataReader lector;
        ConexionDB conexionDB = new ConexionDB();
        private Form1 creadorFactura=new Form1();
        string medioPagoElegido = "";
        public string montoTotal;
        string nuevoCodigoFactura="";
        string codigoClienteElegido = "1";
        public List<string> codigoProductos = new List<string>();
        public List<string> nombrePrecio = new List<string>();

        // listas para actualizar stock en DB
        public List<string> codigo = new List<string>();
        public List<string> cantidad = new List<string>();

        // ----------------------------------Funcionalidad -------------------------------------------//
        public void CargarBaseClientes()
        {
            string consulta = "SELECT CodigoCLiente, Nombre, Apellido FROM Clientes;";
            lector = conexionDB.LecturaDatos(consulta);
            while (lector.Read())
            {
                dgv_buscarClienteFactura.Rows.Add();
                dgv_buscarClienteFactura[0, dgv_buscarClienteFactura.Rows.Count - 1].Value = lector["CodigoCliente"];
                dgv_buscarClienteFactura[1, dgv_buscarClienteFactura.Rows.Count - 1].Value = lector["Nombre"];
                dgv_buscarClienteFactura[2, dgv_buscarClienteFactura.Rows.Count - 1].Value = lector["Apellido"];
                dgv_buscarClienteFactura[3, dgv_buscarClienteFactura.Rows.Count - 1].Value = "Elegir";
            }
            conexionDB.CerrarBaseLector();
        }

        private void BuscarBaseClientes()
        {
            string consulta = "SELECT * FROM Clientes WHERE Nombre LIKE '%" + txb_nombreCliente.Text + "%';";
            lector = conexionDB.LecturaDatos(consulta);
            while (lector.Read())
            {
                dgv_buscarClienteFactura.Rows.Add();
                dgv_buscarClienteFactura[0, dgv_buscarClienteFactura.Rows.Count - 1].Value = lector["CodigoCliente"];
                dgv_buscarClienteFactura[1, dgv_buscarClienteFactura.Rows.Count - 1].Value = lector["Nombre"];
                dgv_buscarClienteFactura[2, dgv_buscarClienteFactura.Rows.Count - 1].Value = lector["Apellido"];
                dgv_buscarClienteFactura[3, dgv_buscarClienteFactura.Rows.Count - 1].Value = "Elegir";
            }
            conexionDB.CerrarBaseLector();
        }

        public FinalizarCrearFactura()
        {
            InitializeComponent();
        }

        private void FinalizarCrearFactura_Load(object sender, EventArgs e)
        {
            cmb_medioPago.Items.Add("Mercado Pago");
            cmb_medioPago.Items.Add("Efectivo");
            cmb_medioPago.SelectedItem = "Efectivo";
            pnl_facturaElegirCliente.Visible = false;
            CargarBaseClientes();
        }

        private void btn_crearFacturaCliente_Click(object sender, EventArgs e)
        {
            pnl_facturaElegirCliente.Visible = true;
        }

        private void btn_buscarCliente_Click(object sender, EventArgs e)
        {
            BuscarBaseClientes();
        }

        private void txb_nombreCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Llamar a la función deseada
                dgv_buscarClienteFactura.Rows.Clear();
                BuscarBaseClientes();
            }
        }

        private void btn_crearFacturaInvitado_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                GenerarFactura("1", medioPagoElegido);

            }
            else if (resultado == DialogResult.No)
            {
                
            }
            
        }

        private void cmb_medioPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            medioPagoElegido = cmb_medioPago.SelectedItem.ToString();
        }

        private void dgv_buscarClienteFactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex >= 0) // Verifica si se ha hecho clic en la columna 3 y en una celda de datos (no encabezado)
            {
                
                DialogResult resultado = MessageBox.Show("¿Desea crear Factura?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    DataGridViewRow row = dgv_buscarClienteFactura.Rows[e.RowIndex]; // obtiene el row
                    DataGridViewCell cell = row.Cells[0]; // obtiene la celda de la columna 0

                    // Obtener el valor de la celda
                    codigoClienteElegido = cell.Value.ToString();

                    // Utiliza el valor de la celda

                    GenerarFactura(codigoClienteElegido, medioPagoElegido);
                }
                else if (resultado == DialogResult.No)
                {
                    // Si se hace clic en "No", realiza la acción deseada
                }
            }
        }

        public void GenerarFactura(string codigoCliente, string medioPago)
        {
            // ---------------------------Generar Factura ------------------//
            nuevoCodigoFactura = conexionDB.GenerarCodigoUnico("Facturas", "CodigoFactura");

            string consulta = "";
            consulta = "INSERT INTO Facturas(CodigoFactura,MontoFinal,MedioPago,NumeroOperacionMP,Estado,FechaRendicion,FechaComprobante)VALUES('"
                + nuevoCodigoFactura + "', '"
                + montoTotal + "', '" + medioPago + "', '" + "0000" + "', '" + "0" + "', '" + "01/01/1990" + "', '" + DateTime.Now.ToString("dd/MM/yyyy") + "');";
            conexionDB.consultaIngresoDatos(consulta);

            consulta = "INSERT INTO Cli_Fac(CodigoCliente,CodigoFactura) VALUES('" + codigoCliente + "', '" + nuevoCodigoFactura + "');";
            conexionDB.consultaIngresoDatos(consulta);

            foreach (string elemento in codigoProductos)
            {
                consulta = "INSERT INTO Fac_Prod(CodigoFactura,CodigoProducto) VALUES('" + nuevoCodigoFactura + "', '" + elemento + "');";
                conexionDB.consultaIngresoDatos(consulta);
            }
            //--------------------------------------------------------------//

            //--------------------Descontar Stock----------------------------//

            foreach (string elemento in codigo)
            {
                string nuevoStock = "";
                string stockTotal = "";

                consulta = "SELECT * FROM Productos WHERE CodigoProducto='" + elemento + "';";
                lector = conexionDB.LecturaDatos(consulta);
                
                while (lector.Read())
                {
                    stockTotal = lector["Stock"].ToString();
                }
                conexionDB.CerrarBaseLector();
                
                int indice = codigo.IndexOf(elemento);

                nuevoStock = Convert.ToString(Convert.ToDouble(stockTotal) - Convert.ToDouble(cantidad[indice]));
                consulta = "UPDATE Productos SET Stock='" + nuevoStock + "' WHERE CodigoProducto='" + elemento + "';";
                conexionDB.consultaIngresoDatos(consulta);
            }

            

            //----------------------------------------------------------------//

            // ------ fase de Impresión---- // 
            ImprimirTicketVenta();

            this.Close();
        }

        private void ImprimirTicketVenta()
        {
            pd_imprimirTicket = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            pd_imprimirTicket.PrinterSettings = ps;
            pd_imprimirTicket.PrintPage += pd_imprimirTicket_PrintPage;
            pd_imprimirTicket.Print();
        }

        private void pd_imprimirTicket_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 8);
            int ancho = 180;
            int y = 20;

            e.Graphics.DrawString("---Diego---", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 40));
            e.Graphics.DrawString("Factura# "+nuevoCodigoFactura, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 40));
            e.Graphics.DrawString("Cliente: " + codigoClienteElegido, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 40));
            e.Graphics.DrawString("------------", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 40));
            e.Graphics.DrawString("Cod | Prod | Cant | SubTotal", font, Brushes.Black, new RectangleF(0, y += 30, ancho, 40));
            e.Graphics.DrawString("------------", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 40));
            e.Graphics.DrawString("------------", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 40));
            foreach (string elemento in nombrePrecio)
            {
                e.Graphics.DrawString(elemento, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 40));
                e.Graphics.DrawString("      ", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 40));
            }
            e.Graphics.DrawString("------------", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 40));
            e.Graphics.DrawString("Total: $" + montoTotal, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 40));
            e.Graphics.DrawString("------------", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("¡Muchas Gracias por su Compra!", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 40));
            e.Graphics.DrawString("------------", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("------------", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("------------", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("             ", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
        }
    }
}
