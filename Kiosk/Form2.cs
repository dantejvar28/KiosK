using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kiosk
{
    public partial class frm_buscarProducto : Form
    {
        public OleDbDataReader lector;
        private List<string> datosProductos = new List<string>();
        ConexionDB conexionDB = new ConexionDB();
        Form1 instanciaPrincipal; 

        public frm_buscarProducto()
        {
            InitializeComponent();
        }

        private void frm_buscarProducto_Load(object sender, EventArgs e)
        {
            //dgv_listadoBusquedaProducto.Rows.Clear();
            CargarDatos();
            instanciaPrincipal = Form1.Instance;

        }

        private void CargarDatos()
        {
            string consulta="SELECT CodigoProducto, Nombre, Precio FROM Productos;";
            lector = conexionDB.LecturaDatos(consulta);

            while(lector.Read())
            {
                dgv_listadoBusquedaProducto.Rows.Add();             
                dgv_listadoBusquedaProducto[0, dgv_listadoBusquedaProducto.Rows.Count - 1].Value = lector["CodigoProducto"];
                dgv_listadoBusquedaProducto[1, dgv_listadoBusquedaProducto.Rows.Count - 1].Value = lector["Nombre"];
                dgv_listadoBusquedaProducto[2, dgv_listadoBusquedaProducto.Rows.Count - 1].Value = lector["Precio"];
                dgv_listadoBusquedaProducto[3, dgv_listadoBusquedaProducto.Rows.Count - 1].Value = "Elegir";
                
            }
            conexionDB.CerrarBaseLector();

        }

        private void BuscarPorNombreProducto()
        {
            string consulta = "SELECT * FROM Productos WHERE Nombre LIKE '%" + txb_buscarProductoBuscador.Text + "%';";
            lector = conexionDB.LecturaDatos(consulta);
            while (lector.Read())
            {
                dgv_listadoBusquedaProducto.Rows.Add();
                dgv_listadoBusquedaProducto[0, dgv_listadoBusquedaProducto.Rows.Count - 1].Value = lector["CodigoProducto"];
                dgv_listadoBusquedaProducto[1, dgv_listadoBusquedaProducto.Rows.Count - 1].Value = lector["Nombre"];
                dgv_listadoBusquedaProducto[2, dgv_listadoBusquedaProducto.Rows.Count - 1].Value = lector["Precio"];
                dgv_listadoBusquedaProducto[3, dgv_listadoBusquedaProducto.Rows.Count - 1].Value = "Elegir";
            }
        }

        private void btn_buscarBuscador_Click(object sender, EventArgs e)
        {
            dgv_listadoBusquedaProducto.Rows.Clear();
            BuscarPorNombreProducto();
        }

        private void txb_buscarProductoBuscador_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dgv_listadoBusquedaProducto.Rows.Clear();
                BuscarPorNombreProducto();
            }
            
        }

        private void dgv_listadoBusquedaProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_listadoBusquedaProducto.Rows[e.RowIndex]; // obtiene el row
                DataGridViewCell cell = row.Cells[0]; // obtiene la celda de la columna 0
                string codigoProductoElegido=cell.Value.ToString();

                instanciaPrincipal.AgregarProductoFactura(codigoProductoElegido);
                this.Close();
            }
        }
    }
}
