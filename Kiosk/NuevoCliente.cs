using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Data.OleDb;

namespace Kiosk
{
    public partial class NuevoCliente : Form
    {
        //private int nuevoCodigoCliente;
        private ConexionDB conexionDB = new ConexionDB();
        public OleDbDataReader lector;
        private ValidacionesDatos validacion = new ValidacionesDatos();
        public bool esEdicion = false;
        public string codigoClienteEdicion = "";
        public NuevoCliente()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //KeyChar validation

        private void txb_dniCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar > 47 && e.KeyChar < 58) || (e.KeyChar == 08) || e.KeyChar == 11))
            {
                e.Handled = true;
            }
        }

        private void txb_telefonoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar > 47 && e.KeyChar < 58) || (e.KeyChar == 08) || e.KeyChar == 11))
            {
                e.Handled = true;
            }
        }
        //-------------------------

        private void NuevoCliente_Load(object sender, EventArgs e)
        {
            if (esEdicion)
            {
                TraerDatosClienteDeBase();
                txb_dniCliente.Enabled = false;
                btn_crear.Text = "Finalizar Edición";

            }
            else
            {
                txb_dniCliente.Enabled = true;
                btn_crear.Text = "Crear";
            }

        }

        private string GenerarCodigoCliente()
        {
            string codCliente;
            
            codCliente=DateTime.Now.Year.ToString() + txb_dniCliente.Text;
            return codCliente;

        }
        private void HayCamposVacios()
        {
            if(!validacion.NoEstaVacio(txb_apellidoCliente.Text))
            {
                txb_apellidoCliente.Text = "aaa";
            }
            if (!validacion.NoEstaVacio(txb_telefonoCliente.Text))
            {
                txb_telefonoCliente.Text = "999";
            }
            if (!validacion.NoEstaVacio(txb_direccion.Text))
            {
                txb_direccion.Text = "aaa";
            }
        }

        void CrearClienteNuevo()
        {
            bool validacionCorrecta;
            string numeroCliente;
            numeroCliente = GenerarCodigoCliente();
            if (validacion.ValidarNumero(txb_dniCliente.ToString()) && validacion.ValidarNumero(txb_telefonoCliente.Text.ToString()))
            {
                validacionCorrecta = true;

            }
            else
            {
                validacionCorrecta = false;
            }

            if (validacion.NoEstaVacio(txb_dniCliente.Text) && validacion.NoEstaVacio(txb_nombreCliente.Text))
            {
                validacionCorrecta = true;

            }
            else
            {
                validacionCorrecta = false;
            }
            if (validacionCorrecta)
            {
                HayCamposVacios();
                string consulta = "";

                consulta = "INSERT INTO Clientes(CodigoCliente,Nombre,Apellido,DNI,Telefono,Direccion)VALUES('" + numeroCliente + "', '" + txb_nombreCliente.Text + "', '"
                    + txb_apellidoCliente.Text + "', '" + txb_dniCliente.Text + "', '" + txb_telefonoCliente.Text + "', '" + txb_direccion.Text + "');";

                conexionDB.consultaIngresoDatos(consulta);
                Form1.Instance.CargarBaseClientes();
                this.Close();
            }
            else
            {
                MessageBox.Show("Verifique que los campos DNI y Nombre estén completos o que DNI y Teléfono sean números");
            }
        }
        private void FinalizarEdicionCliente()
        {
            bool validacionCorrecta;
            string numeroCliente;
            numeroCliente = GenerarCodigoCliente();
            if (validacion.ValidarNumero(txb_dniCliente.ToString()) && validacion.ValidarNumero(txb_telefonoCliente.Text.ToString()))
            {
                validacionCorrecta = true;

            }
            else
            {
                validacionCorrecta = false;
            }

            if (validacion.NoEstaVacio(txb_dniCliente.Text) && validacion.NoEstaVacio(txb_nombreCliente.Text))
            {
                validacionCorrecta = true;

            }
            else
            {
                validacionCorrecta = false;
            }
            if (validacionCorrecta)
            {
                HayCamposVacios();
                string consulta = "";

                consulta = "UPDATE Clientes SET Nombre= '" + txb_nombreCliente.Text + "', Apellido='" + txb_apellidoCliente.Text
                    + "', Telefono='" + txb_telefonoCliente.Text + "', Direccion='"
                    + txb_direccion.Text + "' WHERE CodigoCliente='" + codigoClienteEdicion + "';";

                conexionDB.consultaIngresoDatos(consulta);
                Form1.Instance.CargarBaseClientes();
                this.Close();
            }
            else
            {
                MessageBox.Show("Verifique que los campos DNI y Nombre estén completos o que DNI y Teléfono sean números");
            }
        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            if (!esEdicion)
            {
                CrearClienteNuevo();
            }
            else
            {
                FinalizarEdicionCliente();
            }
        }

        private void TraerDatosClienteDeBase()
        {
            string consulta = "SELECT * FROM Clientes WHERE CodigoCliente='"+codigoClienteEdicion+"';";
            lector = conexionDB.LecturaDatos(consulta);
            while(lector.Read())
            {
                txb_nombreCliente.Text = lector["Nombre"].ToString();
                txb_apellidoCliente.Text = lector["Apellido"].ToString();
                txb_direccion.Text = lector["Direccion"].ToString();
                txb_dniCliente.Text = lector["DNI"].ToString();
                txb_telefonoCliente.Text = lector["Telefono"].ToString();
            }

        }


    }
}
