using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace Kiosk
{
    public partial class ConexionDB
    {
        public OleDbConnection conexionConBD;
        public OleDbCommand orden;
        public OleDbDataReader lector;

        private string strConexion = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=C:\\Kiosk\\BaseDeDatos\\KioskDB.mdb;";
        
        private void AbrirBase()
        {
            conexionConBD = new OleDbConnection(strConexion);
            conexionConBD.Open();
        }

        public void CerrarBaseLector()
        {
            lector.Close();
            conexionConBD.Close();
        }

        public void consultaIngresoDatos(string consulta)
        {
            AbrirBase();
            orden = new OleDbCommand(consulta, conexionConBD);
            orden.ExecuteNonQuery();
            conexionConBD.Close();
        }
               

        public OleDbDataReader LecturaDatos(string consulta)
        {
            AbrirBase();
            orden = new OleDbCommand(consulta, conexionConBD);
            return lector = orden.ExecuteReader();
        }



        public string GenerarCodigoUnico(string tabla, string campo)
        {
            string codigo = "";
            string consulta = "SELECT MAX(" + campo + ") FROM " + tabla;
            LecturaDatos(consulta);
            if (lector.Read() && !lector.IsDBNull(0))
            {
                int ultimoCodigo = Convert.ToInt32(lector[0]);
                codigo = (ultimoCodigo + 1).ToString().PadLeft(4, '0');
            }
            else
            {
                codigo = "0001";
            }
            lector.Close();
            return codigo;
        }

     }
}
