using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiosk
{
    public class DatosFacturaProductos
    {
        public List<string> CodigoProductos { get; set; }
        public List<string> NombresProductos { get; set; }
        public double MontoTotal { get; set; }

        public DatosFacturaProductos()
        {
            CodigoProductos = new List<string>();
            NombresProductos = new List<string>();
            MontoTotal = 0;
        }

        public void AgregarProducto(string codigo, string nombre)
        {
            CodigoProductos.Add(codigo);
            NombresProductos.Add(nombre);
        }
        public void DefinirMontoTotal(double Monto)
        {
            MontoTotal = Monto;
        }
    }
}
