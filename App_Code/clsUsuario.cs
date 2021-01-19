using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Microsoft.AnalysisServices.AdomdClient;


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
        String cadCon = "DataSource=.;Catalog=SISAPIS";
        String cadSQL = "";
        AdomdConnection cnnM;
        AdomdDataAdapter daM;


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
        
     
        public DataSet rptPrediccion1()
        {
            cadSQL = cadSQL + "SELECT ";
            cadSQL = cadSQL + " [dmExportacion].[AUT MARCA], ";
            cadSQL = cadSQL + "    t.[AUT_MARCA], ";
            cadSQL = cadSQL + "     t.[AUT_SEGMENTO], ";
            cadSQL = cadSQL + "     t.[AUT_TIPO], ";
            cadSQL = cadSQL + "    t.[AUT_MODELO] ";
            cadSQL = cadSQL + "From ";
            cadSQL = cadSQL + " [dmExportacion] ";
            cadSQL = cadSQL + "PREDICTION JOIN";
            cadSQL = cadSQL + "    OPENQUERY([BD SISAPIS], ";
            cadSQL = cadSQL + "    'SELECT ";
            cadSQL = cadSQL + "       [AUT_MARCA], ";
            cadSQL = cadSQL + "          [AUT_SEGMENTO], ";
            cadSQL = cadSQL + "      [AUT_TIPO], ";
            cadSQL = cadSQL + "    [AUT_MODELO], ";
            cadSQL = cadSQL + "   [AUT_ID] ";
            cadSQL = cadSQL + "    FROM ";
            cadSQL = cadSQL + "         [dbo].[AUTO] ";
            cadSQL = cadSQL + "    ') AS t ";
            cadSQL = cadSQL + "ON ";
            cadSQL = cadSQL + "  [dmExportacion].[AUT SEGMENTO] = t.[AUT_SEGMENTO] AND";
            cadSQL = cadSQL + "  [dmExportacion].[AUT TIPO] = t.[AUT_TIPO] AND ";
            cadSQL = cadSQL + "  [dmExportacion].[AUT MARCA] = t.[AUT_MARCA] AND";
            cadSQL = cadSQL + "  [dmExportacion].[AUT MODELO] = t.[AUT_MODELO]";
            
            cnnM = new AdomdConnection(cadCon);
            daM = new AdomdDataAdapter(cadSQL, cnnM);
            DataSet ds = new DataSet();
            daM.Fill(ds, "ss");
            return ds;
        }
        public DataSet rptPrediccion2()
        {
            cadSQL = cadSQL + "SELECT ";
            cadSQL = cadSQL + " [dmVentaModeloArboles].[AUT MODELO],";
            cadSQL = cadSQL + " t.[AUT_MARCA],";
            cadSQL = cadSQL + " t.[AUT_SEGMENTO],";
            cadSQL = cadSQL + " t.[AUT_TIPO],";
            cadSQL = cadSQL + " t.[AUT_MODELO],";
            cadSQL = cadSQL + " t.[AUT_ID]";
            cadSQL = cadSQL + " From";
            cadSQL = cadSQL + " [dmVentaModeloArboles]";
            cadSQL = cadSQL + " PREDICTION JOIN";
            cadSQL = cadSQL + " OPENQUERY([BD SISAPIS],";
            cadSQL = cadSQL + "  'SELECT";
            cadSQL = cadSQL + "    [AUT_MARCA],";
            cadSQL = cadSQL + "    [AUT_SEGMENTO],";
            cadSQL = cadSQL + "    [AUT_TIPO],";
            cadSQL = cadSQL + "    [AUT_MODELO],";
            cadSQL = cadSQL + "    [AUT_ID]";
            cadSQL = cadSQL + "  FROM";
            cadSQL = cadSQL + "    [dbo].[AUTO]";
            cadSQL = cadSQL + "  ') AS t";
            cadSQL = cadSQL + " ON";
            cadSQL = cadSQL + " [dmVentaModeloArboles].[AUT SEGMENTO] = t.[AUT_SEGMENTO] AND";
            cadSQL = cadSQL + " [dmVentaModeloArboles].[AUT TIPO] = t.[AUT_TIPO] AND";
            cadSQL = cadSQL + " [dmVentaModeloArboles].[AUT MARCA] = t.[AUT_MARCA] AND";
            cadSQL = cadSQL + " [dmVentaModeloArboles].[AUT MODELO] = t.[AUT_MODELO]";

            cnnM = new AdomdConnection(cadCon);
            daM = new AdomdDataAdapter(cadSQL, cnnM);
            DataSet ds = new DataSet();
            daM.Fill(ds, "ss");
            return ds;
        }
        public DataSet rptPrediccion3()
        {
            cadSQL = cadSQL + " SELECT";
            cadSQL = cadSQL + " [dmVentasArboles].[AUT MARCA],";
            cadSQL = cadSQL + " t.[AUT_MARCA],";
            cadSQL = cadSQL + " t.[AUT_SEGMENTO],";
            cadSQL = cadSQL + " t.[AUT_TIPO],";
            cadSQL = cadSQL + " t.[AUT_MODELO],";
            cadSQL = cadSQL + " t.[AUT_ID]";
            cadSQL = cadSQL + " From";
            cadSQL = cadSQL + " [dmVentasArboles]";
            cadSQL = cadSQL + " PREDICTION JOIN";
            cadSQL = cadSQL + " OPENQUERY([BD SISAPIS],";
            cadSQL = cadSQL + "  'SELECT";
            cadSQL = cadSQL + "    [AUT_MARCA],";
            cadSQL = cadSQL + "    [AUT_SEGMENTO],";
            cadSQL = cadSQL + "    [AUT_TIPO],";
            cadSQL = cadSQL + "   [AUT_MODELO],";
            cadSQL = cadSQL + "  [AUT_ID]";
            cadSQL = cadSQL + " FROM";
            cadSQL = cadSQL + "  [dbo].[AUTO]";
            cadSQL = cadSQL + "  ') AS t";
            cadSQL = cadSQL + " ON";
            cadSQL = cadSQL + " [dmVentasArboles].[AUT SEGMENTO] = t.[AUT_SEGMENTO] AND";
            cadSQL = cadSQL + " [dmVentasArboles].[AUT TIPO] = t.[AUT_TIPO] AND";
            cadSQL = cadSQL + " [dmVentasArboles].[AUT MARCA] = t.[AUT_MARCA] AND";
            cadSQL = cadSQL + " [dmVentasArboles].[AUT MODELO] = t.[AUT_MODELO]";

            cnnM = new AdomdConnection(cadCon);
            daM = new AdomdDataAdapter(cadSQL, cnnM);
            DataSet ds = new DataSet();
            daM.Fill(ds, "ss");
            return ds;
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