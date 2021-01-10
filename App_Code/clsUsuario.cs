using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace wsSisapis
{
    public class clsUsuario
    {
        public int Id;
        public string Nombre, Usu, Contra;
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataReader dr;
        DataSet ds;
        SqlDataAdapter da;

        public clsUsuario()
        {

        }

        ~clsUsuario()
        {

        }

        public string acceso(string usu, string pass, string cn)
        {
                        string resultado = "";
            cnn = new SqlConnection(cn);
            cmd = new SqlCommand("stpIniciarSesion", cnn);

            SqlParameter nUsu = cmd.Parameters.Add("@USU", SqlDbType.NVarChar, 20);
            SqlParameter nPas = cmd.Parameters.Add("@PSW", SqlDbType.NVarChar, 20);

            cmd.CommandType = CommandType.StoredProcedure;

            nUsu.Value = usu;
            nPas.Value = pass;

            cnn.Open();

            dr = cmd.ExecuteReader();
            dr.Read();

            resultado = dr.GetValue(0).ToString();
            if (resultado != "0")
            {
                Id = int.Parse(dr.GetValue(0).ToString());
                Nombre = dr.GetValue(1).ToString();
            }

            return resultado;
        }

        public string registro(string usu, string pass, string nombre, string cn)
        {
            string resultado = "";
            cnn = new SqlConnection(cn);
            cmd = new SqlCommand("stpAddUser", cnn);

            SqlParameter nUsu = cmd.Parameters.Add("@usuario", SqlDbType.NVarChar, 20);
            SqlParameter nPas = cmd.Parameters.Add("@contra", SqlDbType.NVarChar, 20);
            SqlParameter nNombre = cmd.Parameters.Add("@nombre", SqlDbType.NVarChar, 20);

            cmd.CommandType = CommandType.StoredProcedure;

            nUsu.Value = usu;
            nPas.Value = pass;
            nNombre.Value = nombre;

            cnn.Open();

            dr = cmd.ExecuteReader();
            dr.Read();

            resultado = dr.GetValue(0).ToString();
            if (resultado != "0")
            {
                Id = int.Parse(dr.GetValue(0).ToString());
                Nombre = dr.GetValue(1).ToString();
            }

            return resultado;
        }
    }
}