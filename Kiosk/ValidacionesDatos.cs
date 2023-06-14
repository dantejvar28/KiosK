using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Kiosk
{
    public partial class ValidacionesDatos
    {
        public bool ValidarNumero(string numero)
        {
            bool esNumero;
            try
            {
                Convert.ToDouble(numero);
                esNumero = true;
            }
            catch
            {
                esNumero = false;
            }
            return esNumero;
        }
        public bool ValidarLetras(string letras)
        {
            foreach (char ch in letras)
            {
                if (!Char.IsLetter(ch))
                {
                    return false;

                }

            }
            return true;

        }
        public bool NoEstaVacio(string dato)
        {
            if (dato.Trim() == "")
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public bool EsFechaValida(string fecha)
        {
            DateTime result;
            bool esValida = DateTime.TryParseExact(fecha, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out result);
            return esValida;
        }

    }
}
