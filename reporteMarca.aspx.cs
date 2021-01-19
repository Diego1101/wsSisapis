using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrystalDecisions.CrystalReports.Engine;
using System.Data;
namespace wsSisapis
{
    public partial class reporteMarca : System.Web.UI.Page
    {
        ReportDocument reporte;
        //datos actualizados 
        DataSet ds;
        //Copia de la clase
        clsUsuario obj;
        protected void Page_Load(object sender, EventArgs e)
        {
            obj = new clsUsuario();
            reporte = new ReportDocument();
            ds = new DataSet();

            reporte.Load(Server.MapPath("~/reportes/reporte3.rpt"));
            ds = obj.rptPrediccion3();
            reporte.SetDataSource(ds.Tables[0]);
            reporte.SetDatabaseLogon("sa", "geovanna", @"DESKTOP-C84DRT1", "BD_SISAPIS");

            CrystalReportViewer1.ReportSource = reporte;
            CrystalReportViewer1.DataBind();
        }

        protected void CrystalReportViewer1_Init(object sender, EventArgs e)
        {

        }
    }
}