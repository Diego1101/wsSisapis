using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wsSisapis
{
    public partial class Formulario_web13 : System.Web.UI.Page
    {
        clsUsuario obj = new clsUsuario();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistro_Click(object sender, EventArgs e)
        {
            string nombre = String.Format("{0}", Request.Form["txt_nombre"]);
            string usu = String.Format("{0}", Request.Form["txt_usu"]);
            string pass = String.Format("{0}", Request.Form["txt_pass"]);
            string cPass = String.Format("{0}", Request.Form["txt_confpass"]);

            if (nombre != "" && usu != "" && pass != "") {
                if (pass == cPass) {
                    string resultado = obj.registro(usu, pass,nombre, Application["cnn"].ToString());
                    if (resultado != "0") {
                        Session["Usuario"] = obj.Nombre;
                        Session["ID"] = obj.Id;
                        Response.Write("<script language = 'javascript'>alert('Usuario creado');document.location.href='acceso.aspx';</script>");
                    } else Response.Write("<script language = 'javascript'>alert('El usuario ya existe');</script>");
                } else Response.Write("<script language = 'javascript'>alert('Las contraseñas no coinciden');</script>");

            }  else Response.Write("<script language = 'javascript'>alert('Todos los campos deben llenarse');</script>");

        }
    }
}