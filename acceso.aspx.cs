using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wsSisapis
{
    public partial class Formulario_web11 : System.Web.UI.Page
    {
        clsUsuario obj = new clsUsuario();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "" && txtPass.Text != "")
            {
                string resultado = obj.acceso(txtUsuario.Text, txtPass.Text, Application["cnn"].ToString());
                if (resultado != "0")
                {
                    Session["Usuario"] = obj.Nombre;
                    Session["ID"] = obj.Id;
                    Response.Write("<script language = 'javascript'>document.location.href='index.aspx';</script>");
                }
                else Response.Write("<script language = 'javascript'>alert('Datos incorrectos');</script>");
            }
            else Response.Write("<script language = 'javascript'>alert('Todos los campos deben llenarse');</script>");
        
        }
    }
}