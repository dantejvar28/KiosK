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
    public partial class NuevoProducto : Form
    {
        public ConexionDB conexionDB=new ConexionDB();
        string unidadSeleccionada;
        int seVendePesoEstado;
        private ValidacionesDatos validacion = new ValidacionesDatos();
        public bool esEdicion=false;
        public string codigoProductoEdicion = "";

        public OleDbDataReader lector;
        

        public NuevoProducto()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NuevoProducto_Load(object sender, EventArgs e)
        {
            cmb_unidadDeMedida.Items.Add("Und");
            cmb_unidadDeMedida.Items.Add("Kg");
            cmb_unidadDeMedida.SelectedIndex = 0;
            if (esEdicion)
            {
                txb_codigoProducto.Enabled = false;
                txb_nombreProducto.Enabled = false;
                cmb_unidadDeMedida.Enabled = false;
                btn_crearProducto.Text = "Finalizar Edicion";
            }
            TraerDatosParaEditar(codigoProductoEdicion);

        }

        public void AgregarNuevoProducto()
        {
            if (!esEdicion)
            {
                bool validacionCorrecta;

                if (validacion.ValidarNumero(txb_costoProducto.Text.ToString()) && validacion.ValidarNumero(txb_precioProducto.Text.ToString()) && validacion.ValidarNumero(txb_stockProducto.Text.ToString()))
                {
                    validacionCorrecta = true;
                }
                else
                {
                    validacionCorrecta = false;
                }

                if (validacion.NoEstaVacio(txb_codigoProducto.Text) && validacion.NoEstaVacio(txb_nombreProducto.Text) && validacion.NoEstaVacio(txb_costoProducto.Text)
                    && validacion.NoEstaVacio(txb_precioProducto.Text) && validacion.NoEstaVacio(txb_stockProducto.Text))
                {
                    validacionCorrecta = true;
                }
                else
                {
                    validacionCorrecta = false;
                }

                if (validacionCorrecta)
                {
                    if (Convert.ToDouble(txb_costoProducto.Text) < Convert.ToDouble(txb_precioProducto.Text))
                    {
                        HayCamposVacios();
                        string consulta = "";

                        consulta = "INSERT INTO Productos(CodigoProducto,Nombre,Categoria,UnidadMedida,Costo,Precio,SeVendePorPeso,Stock)VALUES('" + txb_codigoProducto.Text.Replace(" ", "") + "', '" +
                            txb_nombreProducto.Text + "', '" + txb_categoriaProducto.Text + "', '" + unidadSeleccionada + "', '" + txb_costoProducto.Text + "', '" +
                                txb_precioProducto.Text + "', '" + seVendePesoEstado.ToString() + "', '" + txb_stockProducto.Text + "');";

                        conexionDB.consultaIngresoDatos(consulta);
                        Form1.Instance.CargarBaseProductos();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("El Costo no puede ser menor que el precio");
                    }

                }
                else
                {
                    MessageBox.Show("Verifique que los valores: Stock, Precio y Costo sean Números o No estén vacíos");
                }
            }
            else
            {
                bool validacionCorrecta;
                if (validacion.ValidarNumero(txb_costoProducto.Text.ToString()) && validacion.ValidarNumero(txb_precioProducto.Text.ToString()) && validacion.ValidarNumero(txb_stockProducto.Text.ToString()))
                {
                    validacionCorrecta = true;
                }
                else
                {
                    validacionCorrecta = false;
                }

                if (validacion.NoEstaVacio(txb_codigoProducto.Text) && validacion.NoEstaVacio(txb_nombreProducto.Text) && validacion.NoEstaVacio(txb_costoProducto.Text)
                    && validacion.NoEstaVacio(txb_precioProducto.Text) && validacion.NoEstaVacio(txb_stockProducto.Text))
                {
                    validacionCorrecta = true;
                }
                else
                {
                    validacionCorrecta = false;
                }
                if (validacionCorrecta)
                {
                    if (Convert.ToDouble(txb_costoProducto.Text) < Convert.ToDouble(txb_precioProducto.Text))
                    {
                        string consulta = "UPDATE Productos SET Precio ='" + txb_precioProducto.Text
                            + "', Costo ='" + txb_costoProducto.Text + "', Categoria = '" + txb_categoriaProducto.Text
                            + "', Stock = '" + txb_stockProducto.Text + "', SeVendePorPeso ='" + seVendePesoEstado.ToString()
                            + "' WHERE CodigoProducto = '" + txb_codigoProducto.Text + "';";
                        conexionDB.consultaIngresoDatos(consulta);
                        Form1.Instance.CargarBaseProductos();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("El Costo no puede ser menor que el precio");
                    }
                }
                else
                {
                    MessageBox.Show("Verifique que los valores: Stock, Precio y Costo sean Números o No estén vacíos");
                }
            }


        }

        private void SeVendePeso()
        {
            if (cbx_seVendePorPeso.Checked)
            {
                seVendePesoEstado = 1;
            }
            else{
                seVendePesoEstado = 0;
            }

        }
        private void btn_crearProducto_Click(object sender, EventArgs e)
        {
            SeVendePeso();
            AgregarNuevoProducto();
            
        }

        private void cmb_unidadDeMedida_SelectedIndexChanged(object sender, EventArgs e)
        {
            unidadSeleccionada = cmb_unidadDeMedida.SelectedItem.ToString();
        }


        // Key press validation
        private void txb_costoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar > 47 && e.KeyChar < 58) || (e.KeyChar == 08) || e.KeyChar == 11))
            {
                e.Handled = true;
            }
        }

        private void txb_precioProducto_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txb_precioProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar > 47 && e.KeyChar < 58) || (e.KeyChar == 08) || e.KeyChar == 11))
            {
                e.Handled = true;
            }
        }

        private void txb_stockProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar > 47 && e.KeyChar < 58) || (e.KeyChar == 08) || e.KeyChar == 11))
            {
                e.Handled = true;
            }
        }

        // Verificar campos Vacíos.

        private void HayCamposVacios()
        {
            if (!validacion.NoEstaVacio(txb_categoriaProducto.Text))
            {
                txb_categoriaProducto.Text = "Generico";
            }
        }

        private void TraerDatosParaEditar(string codigo)
        {
            string consulta="SELECT * FROM Productos WHERE CodigoProducto= '" + codigo + "';";
            lector = conexionDB.LecturaDatos(consulta);
            while (lector.Read())
            {
                txb_codigoProducto.Text=lector["CodigoProducto"].ToString();
                txb_nombreProducto.Text = lector["Nombre"].ToString();
                txb_categoriaProducto.Text = lector["Categoria"].ToString();
                txb_costoProducto.Text = lector["Costo"].ToString();
                txb_precioProducto.Text = lector["Precio"].ToString();
                txb_stockProducto.Text = lector["Stock"].ToString();
                if (lector["UnidadMedida"].ToString() == "Kg")
                {
                    cmb_unidadDeMedida.SelectedItem = "Kg";

                }
                else
                {
                    cmb_unidadDeMedida.SelectedItem = "Und";
                }
                if (lector["SeVendePorPeso"].ToString() == "0")
                {
                    cbx_seVendePorPeso.Checked = false;
                }
                else
                {
                    cbx_seVendePorPeso.Checked = true;
                }
            }

        }

    }
}
