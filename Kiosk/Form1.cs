using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Globalization;
using System.Drawing.Printing;

namespace Kiosk
{
    public partial class Form1 : Form
    {
        // -------------------Instancia principal///

        private static Form1 instance;
        public static Form1 Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Form1();
                }
                return instance;
            }
        }


        // ------------------Variables Generales /// 

        public OleDbDataReader lector;
        ConexionDB conexionDB = new ConexionDB();
        ValidacionesDatos validador = new ValidacionesDatos();
        
        

        //-------------------------------------///
        public Form1()
        {
            InitializeComponent();
        }


        //---------Clientes---------------------------------//

        private void btn_nuevoCliente_Click(object sender, EventArgs e)
        {
            AbrirForm(new NuevoCliente());
        }
        public void CargarBaseClientes()
        {
            dgv_Clientes.Rows.Clear();
            string consulta = "SELECT CodigoCLiente, Nombre, Apellido, DNI, Telefono, Direccion FROM Clientes;";
            lector = conexionDB.LecturaDatos(consulta);
            while (lector.Read())
            {
                dgv_Clientes.Rows.Add();
                dgv_Clientes[0, dgv_Clientes.Rows.Count - 1].Value = lector["CodigoCliente"];
                dgv_Clientes[1, dgv_Clientes.Rows.Count - 1].Value = lector["Nombre"];
                dgv_Clientes[2, dgv_Clientes.Rows.Count - 1].Value = lector["Apellido"];
                dgv_Clientes[3, dgv_Clientes.Rows.Count - 1].Value = lector["DNI"];
                dgv_Clientes[4, dgv_Clientes.Rows.Count - 1].Value = lector["Telefono"];
                dgv_Clientes[5, dgv_Clientes.Rows.Count - 1].Value = lector["Direccion"];
                dgv_Clientes[6, dgv_Clientes.Rows.Count - 1].Value = "Editar";
                
            }
            conexionDB.CerrarBaseLector();
        }

        private void btn_buscarCliente_Click(object sender, EventArgs e)
        {
            dgv_Clientes.Rows.Clear();
            BuscarBaseClientes();
        }

        private void BuscarBaseClientes()
        {
            string consulta = "SELECT * FROM Clientes WHERE Nombre LIKE '%" + txb_nombreClienteBuscar.Text + "%';";
            lector = conexionDB.LecturaDatos(consulta);
            while (lector.Read())
            {
                dgv_Clientes.Rows.Add();
                dgv_Clientes[0, dgv_Clientes.Rows.Count - 1].Value = lector["CodigoCliente"];
                dgv_Clientes[1, dgv_Clientes.Rows.Count - 1].Value = lector["Nombre"];
                dgv_Clientes[2, dgv_Clientes.Rows.Count - 1].Value = lector["Apellido"];
                dgv_Clientes[3, dgv_Clientes.Rows.Count - 1].Value = lector["DNI"];
                dgv_Clientes[4, dgv_Clientes.Rows.Count - 1].Value = lector["Telefono"];
                dgv_Clientes[5, dgv_Clientes.Rows.Count - 1].Value = lector["Direccion"];
                dgv_Clientes[6, dgv_Clientes.Rows.Count - 1].Value = "Editar";
                
            }
            conexionDB.CerrarBaseLector();
        }

        private void txb_nombreClienteBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Llamar a la función deseada
                dgv_Clientes.Rows.Clear();
                BuscarBaseClientes();
            }
            
        }

        private void dgv_Clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6 && e.RowIndex >= 0)
            {
                NuevoCliente editarCliente = new NuevoCliente();
                
                editarCliente.esEdicion = true;
                editarCliente.codigoClienteEdicion = dgv_Clientes.Rows[e.RowIndex].Cells[0].Value.ToString();
                

                editarCliente.Show();
            }
        }

        
        //------------------------------------------------------//



        public void AbrirForm(object formAbrir)
        {
            Form form = formAbrir as Form;
            form.Show();
        }



        // ------- PRODUCTOS --------------------------------------//
        private void btn_nuevoProducto_Click(object sender, EventArgs e)
        {
            AbrirForm(new NuevoProducto());
        }

        public void CargarBaseProductos()
        {
            dgv_Productos.Rows.Clear();
            string consulta = "SELECT CodigoProducto, Nombre, Categoria, UnidadMedida, Costo, Precio, SeVendePorPeso, Stock FROM Productos;";
            lector = conexionDB.LecturaDatos(consulta);

            while (lector.Read())
            {
                dgv_Productos.Rows.Add();
                dgv_Productos[0, dgv_Productos.Rows.Count - 1].Value = lector["CodigoProducto"];
                dgv_Productos[1, dgv_Productos.Rows.Count - 1].Value = lector["Nombre"];
                dgv_Productos[2, dgv_Productos.Rows.Count - 1].Value = lector["Categoria"];
                dgv_Productos[3, dgv_Productos.Rows.Count - 1].Value = lector["UnidadMedida"];
                dgv_Productos[4, dgv_Productos.Rows.Count - 1].Value = lector["Costo"];
                dgv_Productos[5, dgv_Productos.Rows.Count - 1].Value = lector["Precio"];
                dgv_Productos[6, dgv_Productos.Rows.Count - 1].Value = lector["SeVendePorPeso"];
                dgv_Productos[7, dgv_Productos.Rows.Count - 1].Value = lector["Stock"];
                dgv_Productos[8, dgv_Productos.Rows.Count - 1].Value = "Editar";
            }
            conexionDB.CerrarBaseLector();
        }

        private void btn_buscarProducto_Click(object sender, EventArgs e)
        {
            dgv_Productos.Rows.Clear();
            BuscarProductoDesdeBase();
        }

        private void BuscarProductoDesdeBase()
        {
            string consulta = "SELECT * FROM Productos WHERE Nombre LIKE '%" + txb_tituloProductosBuscar.Text + "%';";
            lector = conexionDB.LecturaDatos(consulta);

            while (lector.Read())
            {
                dgv_Productos.Rows.Add();
                dgv_Productos[0, dgv_Productos.Rows.Count - 1].Value = lector["CodigoProducto"];
                dgv_Productos[1, dgv_Productos.Rows.Count - 1].Value = lector["Nombre"];
                dgv_Productos[2, dgv_Productos.Rows.Count - 1].Value = lector["Categoria"];
                dgv_Productos[3, dgv_Productos.Rows.Count - 1].Value = lector["UnidadMedida"];
                dgv_Productos[4, dgv_Productos.Rows.Count - 1].Value = lector["Costo"];
                dgv_Productos[5, dgv_Productos.Rows.Count - 1].Value = lector["Precio"];
                dgv_Productos[6, dgv_Productos.Rows.Count - 1].Value = lector["SeVendePorPeso"];
                dgv_Productos[7, dgv_Productos.Rows.Count - 1].Value = lector["Stock"];
                dgv_Productos[8, dgv_Productos.Rows.Count - 1].Value = "Editar";
            }
            conexionDB.CerrarBaseLector();
        }


        private void txb_tituloProductosBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dgv_Productos.Rows.Clear();
                BuscarProductoDesdeBase();
            }
        }

        private void dgv_Productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8 && e.RowIndex>=0)
            {
                NuevoProducto editarProducto = new NuevoProducto();
                editarProducto.esEdicion = true;
                editarProducto.codigoProductoEdicion = dgv_Productos.Rows[e.RowIndex].Cells[0].Value.ToString();
                editarProducto.Show();
                
            }
        }

        //---------------------termina Productos-------------------------------------//


        private void btn_nuevoComprobanteTesoreria_Click(object sender, EventArgs e)
        {
            pnl_nuevoComprobante.Visible = true;
        }

        private void btn_cancelarCrearComprobante_Click(object sender, EventArgs e)
        {
            pnl_nuevoComprobante.Visible = false;
        }

        

        private void dgv_FacturaFinal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       

        // -------------- Al abrir Programa ------//
        private void Form1_Load(object sender, EventArgs e)
        {
            instance = this;
            cbx_MedioPagoNuevoComprobanteTesoreria.Items.Add("Mercado Pago");
            cbx_MedioPagoNuevoComprobanteTesoreria.Items.Add("Efectivo");
            cbx_MedioPagoNuevoComprobanteTesoreria.SelectedItem = "Efectivo";
        }


        // ---- tb Control cambio de TAB ----- //
        private void tb_kioskMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tb_kioskMain.SelectedTab.Name == "tb_clientes")
            {
                dgv_Clientes.Rows.Clear();
                CargarBaseClientes();
            }
            if (tb_kioskMain.SelectedTab.Name == "tb_productos")
            {
                dgv_Productos.Rows.Clear();
                CargarBaseProductos();
            }
            if (tb_kioskMain.SelectedTab.Name == "tb_totalVentas")
            {
                dgv_Facturas.Rows.Clear();
                CargarBaseFacturas();
            }
            if (tb_kioskMain.SelectedTab.Name == "tb_mercadoPago")
            {
                dgv_ventasMercadoPagoGeneral.Rows.Clear();
                CargarBaseMercadoPago();

            }
            if (tb_kioskMain.SelectedTab.Name == "tb_cierreDeCaja")
            {
                dgv_totalVentas.Rows.Clear();
                txb_totalEfectivo.Enabled = false;
                txb_totalMercadoPago.Enabled = false;
                CargarBaseCierreCaja();

            }
        }

        //-------------------------------- Creacíón de Facturas ----------------------------------//

        public void AgregarProductoFactura(string codigo)
        {
            if (!ProductoYaAgregado(codigo))
            {
                string consulta = "SELECT * FROM Productos WHERE CodigoProducto= '" + codigo + "';";
                lector = conexionDB.LecturaDatos(consulta);
                while (lector.Read())
                {
                    dgv_FacturaFinal.Rows.Add();
                    dgv_FacturaFinal[0, dgv_FacturaFinal.Rows.Count - 1].Value = lector["CodigoProducto"];
                    dgv_FacturaFinal[1, dgv_FacturaFinal.Rows.Count - 1].Value = lector["Nombre"];
                    dgv_FacturaFinal[2, dgv_FacturaFinal.Rows.Count - 1].Value = lector["Stock"];
                    dgv_FacturaFinal[3, dgv_FacturaFinal.Rows.Count - 1].Value = lector["Precio"];
                    dgv_FacturaFinal[4, dgv_FacturaFinal.Rows.Count - 1].Value = "1";
                    dgv_FacturaFinal[5, dgv_FacturaFinal.Rows.Count - 1].Value = lector["Precio"];
                    dgv_FacturaFinal[6, dgv_FacturaFinal.Rows.Count - 1].Value = "Quitar";

                }
                conexionDB.CerrarBaseLector();

                SumarTotalProductos();
                MostrarTotal();
            }
            else
            {
                for (int i = 0; i < dgv_FacturaFinal.Rows.Count;i++ )
                {
                    if(dgv_FacturaFinal[0,i].Value.ToString()==codigo)
                    {
                        dgv_FacturaFinal[4, i].Value = Convert.ToInt32(dgv_FacturaFinal[4, i].Value) + 1;
                        
                    }
                }
                CalcularSubTotal();
                SumarTotalProductos();
                MostrarTotal();
                //MessageBox.Show("El Producto ya está agregado, si requiere agregar más del mismo modifique la cantidad");

            }
        }

        public void CalcularSubTotal()
        {
            foreach (DataGridViewRow fila in dgv_FacturaFinal.Rows)
            {
                if (validador.ValidarNumero(fila.Cells[3].Value.ToString()) && validador.ValidarNumero(fila.Cells[4].Value.ToString()))
                {
                    fila.Cells[5].Value = Convert.ToDouble(fila.Cells[3].Value) * Convert.ToDouble(fila.Cells[4].Value);
                }
                else
                {
                    MessageBox.Show("Una Cantidad Ingresada no es Número");
                }
                
            }
        }

        private double SumarTotalProductos()
        {
            double total = 0;
            foreach (DataGridViewRow fila in dgv_FacturaFinal.Rows)
            {
                double precio = Convert.ToDouble(fila.Cells["clm_subTotal"].Value);
                total += precio;
            }
            return total;
        }
        private void MostrarTotal()
        {
            lbl_Total.Text = "Total: $" + SumarTotalProductos();
        }
        private void txb_codigoProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //enter key is down
                AgregarProductoFactura(txb_codigoProducto.Text);
                txb_codigoProducto.Text = "";
            }
        }

        private void dgv_FacturaFinal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6 && e.RowIndex>=0)
            {
                dgv_FacturaFinal.Rows.RemoveAt(dgv_FacturaFinal.CurrentRow.Index);
                SumarTotalProductos();
                MostrarTotal();
            }
        }

        private void btn_Cobrar_Click(object sender, EventArgs e)
        {
            if (dgv_FacturaFinal.RowCount == 0)
            {
                MessageBox.Show("No hay Productos Agregados, Agregue por lo menos 1 Producto para Crear una Factura", "Error", MessageBoxButtons.OK);
            }
            else
            {
                FinalizarCrearFactura finalizar = new FinalizarCrearFactura();
                

                foreach (DataGridViewRow fila in dgv_FacturaFinal.Rows)
                {

                    finalizar.nombrePrecio.Add(fila.Cells["clm_codigoProducto"].Value.ToString() + " | " + fila.Cells["clm_nombreProducto"].Value.ToString() +" | "+ fila.Cells["clm_Cantidad"].Value.ToString() + " | $" + fila.Cells["clm_subTotal"].Value.ToString());
                    finalizar.codigo.Add(fila.Cells["clm_codigoProducto"].Value.ToString());
                    finalizar.cantidad.Add(fila.Cells["clm_Cantidad"].Value.ToString());
                }
                finalizar.montoTotal = SumarTotalProductos().ToString(); ;
                finalizar.Show();
                                
            }
            
        }

        private void dgv_FacturaFinal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CalcularSubTotal();
                lbl_Total.Text= "Total: $"+SumarTotalProductos().ToString();
            }
        }

        private void dgv_FacturaFinal_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            dgv_FacturaFinal.Rows.Clear();
            lbl_Total.Text = "Total: $" + SumarTotalProductos();
        }

        public bool ProductoYaAgregado(string codigoVerificar)
        {
            bool verificacion = false;
            foreach (DataGridViewRow fila in dgv_FacturaFinal.Rows)
            {
                if(fila.Cells[0].Value.ToString()==codigoVerificar)
                {
                    verificacion = true;
                }
            }
            return verificacion;

            
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            AbrirForm(new frm_buscarProducto());
        }

       

        //-----------------------------Termina Creación de Facturas----------------------//
        
      

        //-----------------------------Vista de Facturas ---------------------------------//

        private string filtroNumeroFactura = "";
        private bool hayNumeroFactura = false;
        public void CargarBaseFacturas()
        {
            string consulta = "SELECT Facturas.CodigoFactura ,Facturas.MedioPago, Facturas.NumeroOperacionMP, Facturas.FechaComprobante, Facturas.MontoFinal, Facturas.FechaRendicion, Clientes.CodigoCliente, Clientes.Nombre"+
                " FROM Clientes INNER JOIN (Facturas INNER JOIN Cli_Fac ON Facturas.CodigoFactura=Cli_Fac.CodigoFactura) "+
                "ON Clientes.CodigoCliente = Cli_Fac.CodigoCliente;";
            lector = conexionDB.LecturaDatos(consulta);
            while (lector.Read())
            {
                dgv_Facturas.Rows.Add();
                dgv_Facturas[0, dgv_Facturas.Rows.Count - 1].Value = lector["FechaComprobante"];
                dgv_Facturas[1, dgv_Facturas.Rows.Count - 1].Value = lector["CodigoFactura"];
                dgv_Facturas[2, dgv_Facturas.Rows.Count - 1].Value = lector["CodigoCliente"];
                dgv_Facturas[3, dgv_Facturas.Rows.Count - 1].Value = lector["Nombre"];
                dgv_Facturas[4, dgv_Facturas.Rows.Count - 1].Value = lector["MedioPago"];
                dgv_Facturas[5, dgv_Facturas.Rows.Count - 1].Value = lector["NumeroOperacionMP"];
                dgv_Facturas[6, dgv_Facturas.Rows.Count - 1].Value = lector["FechaRendicion"];
                dgv_Facturas[7, dgv_Facturas.Rows.Count - 1].Value = lector["MontoFinal"];

            }
            conexionDB.CerrarBaseLector();
        }

        public string ConvertirFecha(string fechaAConvertir)
        {
            DateTime dt = DateTime.ParseExact(fechaAConvertir, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string fechaFormateada = dt.ToString("MM/dd/yyyy");
            return fechaFormateada;
        }

        public void FiltrarFacturas()
        {
            CompletarFechaVacia();
            if (validador.EsFechaValida(txb_fechaFacturaDesde.Text) && validador.EsFechaValida(txb_fechaFacturaHasta.Text))
            {
                string consulta = "";
                
                if (hayNumeroFactura)
                {
                    if (validador.ValidarNumero(txb_numeroFactura.Text))
                    {
                        consulta = "SELECT Facturas.FechaComprobante, Facturas.MontoFinal,Facturas.CodigoFactura, Clientes.CodigoCliente, Clientes.Nombre, Facturas.MedioPago, Facturas.NumeroOperacionMP, Facturas.FechaRendicion FROM ((Clientes INNER JOIN Cli_Fac ON Clientes.CodigoCliente = Cli_Fac.CodigoCliente) INNER JOIN Facturas ON Cli_Fac.CodigoFactura = Facturas.CodigoFactura) WHERE (Facturas.FechaComprobante >= #" + ConvertirFecha(txb_fechaFacturaDesde.Text)
                            + "#) AND (Facturas.FechaComprobante <= #" + ConvertirFecha(txb_fechaFacturaHasta.Text)
                            + "#) AND (Clientes.Nombre LIKE '%" + txb_nombreCliente.Text + "%') AND (Facturas.CodigoFactura " + filtroNumeroFactura + ");";
                    }
                    else
                    {
                        MessageBox.Show("El campo Numero de Factura no es un número.", "Error Numero Factura");
                    }
                }
                else
                {
                    consulta = "SELECT Facturas.FechaComprobante, Facturas.MontoFinal,Facturas.CodigoFactura, Clientes.CodigoCliente, Clientes.Nombre, Facturas.MedioPago, Facturas.NumeroOperacionMP, Facturas.FechaRendicion FROM ((Clientes INNER JOIN Cli_Fac ON Clientes.CodigoCliente = Cli_Fac.CodigoCliente) INNER JOIN Facturas ON Cli_Fac.CodigoFactura = Facturas.CodigoFactura) WHERE (Facturas.FechaComprobante >= #" + ConvertirFecha(txb_fechaFacturaDesde.Text)
                        + "#) AND (Facturas.FechaComprobante <= #" + ConvertirFecha(txb_fechaFacturaHasta.Text)
                        + "#) AND (Clientes.Nombre LIKE '%" + txb_nombreCliente.Text + "%');";
                }
                lector = conexionDB.LecturaDatos(consulta);
                while (lector.Read())
                {
                    dgv_Facturas.Rows.Add();
                    dgv_Facturas[0, dgv_Facturas.Rows.Count - 1].Value = lector["FechaComprobante"];
                    dgv_Facturas[1, dgv_Facturas.Rows.Count - 1].Value = lector["CodigoFactura"];
                    dgv_Facturas[2, dgv_Facturas.Rows.Count - 1].Value = lector["CodigoCliente"];
                    dgv_Facturas[3, dgv_Facturas.Rows.Count - 1].Value = lector["Nombre"];
                    dgv_Facturas[4, dgv_Facturas.Rows.Count - 1].Value = lector["MedioPago"];
                    dgv_Facturas[5, dgv_Facturas.Rows.Count - 1].Value = lector["NumeroOperacionMP"];
                    dgv_Facturas[6, dgv_Facturas.Rows.Count - 1].Value = lector["FechaRendicion"];
                    dgv_Facturas[7, dgv_Facturas.Rows.Count - 1].Value = lector["MontoFinal"];

                }
                conexionDB.CerrarBaseLector();
            }
            else
            {

                MessageBox.Show("Alguna fecha no es válida", "Error Fecha");
            }
        
        }
        private void CompletarFechaVacia()
        {
            if (txb_fechaFacturaDesde.Text.Trim(' ') == "")
            {
                txb_fechaFacturaDesde.Text = "01/01/1960";
            }
            if (txb_fechaFacturaHasta.Text.Trim(' ') == "")
            {
                txb_fechaFacturaHasta.Text = DateTime.Now.ToString("dd/MM/yyyy");
            }
            if (txb_numeroFactura.Text.Trim(' ') == "")
            {
                hayNumeroFactura = false;
            }
            else
            {
                hayNumeroFactura = true;
                filtroNumeroFactura = "= " + txb_numeroFactura.Text;
            }

        }
        private void btn_filtrarFacturas_Click(object sender, EventArgs e)
        {
            dgv_Facturas.Rows.Clear();
            FiltrarFacturas();
        }

        private void btn_quitarFiltrosFacturas_Click(object sender, EventArgs e)
        {
            txb_fechaFacturaDesde.Text = "";
            txb_fechaFacturaHasta.Text = "";
            txb_nombreCliente.Text = "";
            txb_numeroFactura.Text = "";
            dgv_Facturas.Rows.Clear();
            CargarBaseFacturas();

        }


        //------------------------------Termina Vista Facturas ----------------------------//

        // ------------------------------Gestion Mercado Pago -----------------------------//

        private void CargarBaseMercadoPago()
        {
            string consulta = "SELECT Facturas.CodigoFactura, Facturas.MontoFinal, Facturas.NumeroOperacionMP, Facturas.FechaComprobante, Clientes.CodigoCliente, Clientes.Nombre" +
                " FROM Clientes INNER JOIN (Facturas INNER JOIN Cli_Fac ON Facturas.CodigoFactura=Cli_Fac.CodigoFactura) " +
                "ON Clientes.CodigoCliente = Cli_Fac.CodigoCliente WHERE Facturas.MedioPago = 'Mercado Pago' AND Facturas.Estado= 0;";
            lector = conexionDB.LecturaDatos(consulta);
            while (lector.Read())
            {
                dgv_ventasMercadoPagoGeneral.Rows.Add();
                dgv_ventasMercadoPagoGeneral[0, dgv_ventasMercadoPagoGeneral.Rows.Count - 1].Value = lector["FechaComprobante"];
                dgv_ventasMercadoPagoGeneral[1, dgv_ventasMercadoPagoGeneral.Rows.Count - 1].Value = lector["CodigoFactura"];
                dgv_ventasMercadoPagoGeneral[2, dgv_ventasMercadoPagoGeneral.Rows.Count - 1].Value = lector["CodigoCliente"];
                dgv_ventasMercadoPagoGeneral[3, dgv_ventasMercadoPagoGeneral.Rows.Count - 1].Value = lector["Nombre"];
                dgv_ventasMercadoPagoGeneral[4, dgv_ventasMercadoPagoGeneral.Rows.Count - 1].Value = "$ "+lector["MontoFinal"];
                dgv_ventasMercadoPagoGeneral[5, dgv_ventasMercadoPagoGeneral.Rows.Count - 1].Value = lector["NumeroOperacionMP"];
                dgv_ventasMercadoPagoGeneral[6, dgv_ventasMercadoPagoGeneral.Rows.Count - 1].Value = "Rendir";

            }
            conexionDB.CerrarBaseLector();
        }

        private void dgv_ventasMercadoPagoGeneral_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6 && e.RowIndex >= 0)
            {
                RendirMercadoPago rendir = new RendirMercadoPago();
                rendir.codigoFactura = dgv_ventasMercadoPagoGeneral.Rows[e.RowIndex].Cells[1].Value.ToString();
                rendir.Show();
                
            }
        }

        public void RendirComprobante(string numeroFactura,string numeroOperacion)
        {
            string consulta = "";
            consulta = "UPDATE Facturas SET NumeroOperacionMP = '"+numeroOperacion
                + "', Estado = 1 WHERE CodigoFactura=" + numeroFactura + ";";
            conexionDB.consultaIngresoDatos(consulta);
            
            dgv_ventasMercadoPagoGeneral.Rows.Clear();
            CargarBaseMercadoPago();
        }


        //-------------------------------Finaliza Gestion Mercado Pago-----------------------------------//


        //-------------------------------Cierre de Caja--------------------------------------------------//

        double totalMercadoPago;
        double totalEfectivo;

        private void CargarBaseCierreCaja()
        {
            string consulta = "SELECT Facturas.CodigoFactura,Facturas.MedioPago , Facturas.MontoFinal, Clientes.CodigoCliente, Clientes.Nombre" +
                " FROM Clientes INNER JOIN (Facturas INNER JOIN Cli_Fac ON Facturas.CodigoFactura=Cli_Fac.CodigoFactura) " +
                "ON Clientes.CodigoCliente = Cli_Fac.CodigoCliente WHERE Facturas.FechaComprobante =#" + ConvertirFecha(DateTime.Now.ToString("dd/MM/yyyy")) + "#  AND Facturas.MedioPago= 'Efectivo' AND Facturas.Estado = 0;";
            lector = conexionDB.LecturaDatos(consulta);
            while (lector.Read())
            {
                dgv_totalVentas.Rows.Add();
                dgv_totalVentas[0, dgv_totalVentas.Rows.Count - 1].Value = lector["CodigoFactura"];
                dgv_totalVentas[1, dgv_totalVentas.Rows.Count - 1].Value = lector["CodigoCliente"];
                dgv_totalVentas[2, dgv_totalVentas.Rows.Count - 1].Value = lector["Nombre"];
                dgv_totalVentas[3, dgv_totalVentas.Rows.Count - 1].Value = lector["MedioPago"];
                dgv_totalVentas[4, dgv_totalVentas.Rows.Count - 1].Value = lector["MontoFinal"];
                
            }

            consulta = "SELECT Facturas.CodigoFactura, Facturas.MontoFinal, Facturas.MedioPago, Clientes.CodigoCliente, Clientes.Nombre" +
                " FROM Clientes INNER JOIN (Facturas INNER JOIN Cli_Fac ON Facturas.CodigoFactura=Cli_Fac.CodigoFactura) " +
                "ON Clientes.CodigoCliente = Cli_Fac.CodigoCliente WHERE Facturas.FechaRendicion=#" + ConvertirFecha("01/01/1990") + "# AND Facturas.Estado = 1 AND Facturas.MedioPago= 'Mercado Pago';";
            lector = conexionDB.LecturaDatos(consulta);
            while (lector.Read())
            {
                dgv_totalVentas.Rows.Add();
                dgv_totalVentas[0, dgv_totalVentas.Rows.Count - 1].Value = lector["CodigoFactura"];
                dgv_totalVentas[1, dgv_totalVentas.Rows.Count - 1].Value = lector["CodigoCliente"];
                dgv_totalVentas[2, dgv_totalVentas.Rows.Count - 1].Value = lector["Nombre"];
                dgv_totalVentas[3, dgv_totalVentas.Rows.Count - 1].Value = lector["MedioPago"];
                dgv_totalVentas[4, dgv_totalVentas.Rows.Count - 1].Value = lector["MontoFinal"];

            }
            conexionDB.CerrarBaseLector();

            CalcularMontosCierre();
        }

        void CalcularMontosCierre()
        {
            foreach (DataGridViewRow lineas in dgv_totalVentas.Rows)
            {
                if (lineas.Cells[3].Value.ToString() == "Efectivo")
                {
                    totalEfectivo += (Convert.ToDouble(lineas.Cells[4].Value.ToString()));
                }
                if (lineas.Cells[3].Value.ToString() == "Mercado Pago")
                {
                    totalMercadoPago += (Convert.ToDouble(lineas.Cells[4].Value.ToString()));
                }
            }
            txb_totalEfectivo.Text = totalEfectivo.ToString();
            txb_totalMercadoPago.Text = totalMercadoPago.ToString();
            lbl_resultadoCierreCaja.Text = "Resultado: $" + (totalMercadoPago + totalEfectivo);

        }

        private void ImprimirTicketVenta()
        {
            pd_imprimirCierre = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            pd_imprimirCierre.PrinterSettings = ps;
            pd_imprimirCierre.PrintPage += pd_imprimirCierre_PrintPage;
            pd_imprimirCierre.Print();
        }

        private void pd_imprimirCierre_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 8);
            int ancho = 180;
            int y = 20;

            e.Graphics.DrawString("---Cierre Caja---", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 40));
            e.Graphics.DrawString("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy"), font, Brushes.Black, new RectangleF(0, y += 20, ancho, 40));
            e.Graphics.DrawString("------------", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 40));
            e.Graphics.DrawString("", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 40));
            e.Graphics.DrawString("Comprobante | Monto", font, Brushes.Black, new RectangleF(0, y += 30, ancho, 40));
            e.Graphics.DrawString("------------", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 40));

            foreach (DataGridViewRow linea in dgv_totalVentas.Rows)
            {

                e.Graphics.DrawString(linea.Cells[0].Value.ToString() + " | $" +linea.Cells[4].Value.ToString(), font, Brushes.Black, new RectangleF(0, y += 20, ancho, 40));
                e.Graphics.DrawString("", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 40));
            }
            e.Graphics.DrawString("------------", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 40));
            e.Graphics.DrawString("Total: $"+(totalEfectivo+totalMercadoPago), font, Brushes.Black, new RectangleF(0, y += 20, ancho, 40));
            e.Graphics.DrawString("------------", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 40));

        }

        private void btn_cerrarCaja_Click(object sender, EventArgs e)
        {
            RendirComprobantesEfectivo();
            ActualizarFechaRendicion();
            ImprimirTicketVenta();
            
            dgv_totalVentas.Rows.Clear();
            totalEfectivo = 0;
            CargarBaseCierreCaja();
                        
        }

        private void RendirComprobantesEfectivo()
        {
            foreach (DataGridViewRow linea in dgv_totalVentas.Rows)
            {

                string consulta = "";
                consulta = "UPDATE Facturas SET Estado = 1 WHERE CodigoFactura=" + linea.Cells["cm_cierreCajaNumFactura"].Value.ToString() + ";";
                conexionDB.consultaIngresoDatos(consulta);
            }
        }
        private void ActualizarFechaRendicion()
        {
            foreach (DataGridViewRow linea in dgv_totalVentas.Rows)
            {
                string consulta = "";
                consulta = "UPDATE Facturas SET FechaRendicion='" + DateTime.Now.ToString("dd/MM/yyyy") + "' WHERE CodigoFactura=" + linea.Cells["cm_cierreCajaNumFactura"].Value.ToString() + ";";
                conexionDB.consultaIngresoDatos(consulta);
            }
        }
        

        //----------------------------------Fin Cierra de Caja-------------------------------------------//

        //----------------------------------Comprobantes ------------------------------------------------//

        string nuevoCodigoComprobante = "";
        string medioPago = "";
        string montoComprobante = "";
        private void CrearComprobante()
        {
            nuevoCodigoComprobante = conexionDB.GenerarCodigoUnico("Facturas", "CodigoFactura");

            string consulta = "";
            consulta = "INSERT INTO Facturas(CodigoFactura,MontoFinal,MedioPago,NumeroOperacionMP,Estado,FechaRendicion,FechaComprobante)VALUES('"
                + nuevoCodigoComprobante + "', '"
                + montoComprobante + "', '" + medioPago + "', '" + "0000" + "', '" + "0" + "', '" + "01/01/1990" + "', '" + DateTime.Now.ToString("dd/MM/yyyy") + "');";
            conexionDB.consultaIngresoDatos(consulta);

            consulta = "INSERT INTO Cli_Fac(CodigoCliente,CodigoFactura) VALUES('2', '" + nuevoCodigoComprobante + "');";
            conexionDB.consultaIngresoDatos(consulta);
        }

        private void cbx_MedioPagoNuevoComprobanteTesoreria_SelectedIndexChanged(object sender, EventArgs e)
        {
            medioPago = cbx_MedioPagoNuevoComprobanteTesoreria.SelectedItem.ToString();
        }

        void DefinirMonto()
        {
            if (validador.ValidarNumero(txb_montoComprobanteTesoreria.Text))
            {
                if (rb_IngresoDinero.Checked)
                {
                    montoComprobante = Convert.ToString(Convert.ToDouble(txb_montoComprobanteTesoreria.Text) * (1));
                }
                if (rb_egresoDinero.Checked)
                {
                    montoComprobante = Convert.ToString(Convert.ToDouble(txb_montoComprobanteTesoreria.Text) * (-1));
                }
            }
            else
            {
                MessageBox.Show("El monto debe ser un Número", "Error");
            }
        }

        private void btn_crearComprobanteTesoreria_Click(object sender, EventArgs e)
        {
            DefinirMonto();
            CrearComprobante();
        }



        //----------------------------------Fin Comprobantes --------------------------------------------//
    }
}
