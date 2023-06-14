using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kiosk
{
    public partial class RendirMercadoPago : Form
    {
        public string codigoFactura="";
        string numeroOperacion = "";
        ValidacionesDatos validador = new ValidacionesDatos();

        public RendirMercadoPago()
        {
            InitializeComponent();
        }

        private void RendirMercadoPago_Load(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_rendir_Click(object sender, EventArgs e)
        {
            if(validador.ValidarNumero(txb_numeroOperacion.Text))
            {
                numeroOperacion = txb_numeroOperacion.Text;
                Form1.Instance.RendirComprobante(codigoFactura, numeroOperacion);
                this.Close();
            }
        }
    }
}
