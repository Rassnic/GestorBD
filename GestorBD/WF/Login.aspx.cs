using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GestorBD.WF
{
    public partial class Login : System.Web.UI.Page
    {
        private MySqlCommand command = new MySqlCommand();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public void MsgBox(String ex, Page pg, Object obj)
        {
            string s = "<SCRIPT language='javascript'>alert('" + ex.Replace("\r\n", "\\n").Replace("'", "") + "'); </SCRIPT>";
            Type cstype = obj.GetType();
            ClientScriptManager cs = pg.ClientScript;
            cs.RegisterClientScriptBlock(cstype, s, s.ToString());
        }

        protected void login_Click(object sender, EventArgs e)
        {
                    
           string usuario = user.Value.ToString();
           string password = pass.Value.ToString();
           string cadenacon;
           Session["Usuario"] = usuario;
           Session["password"] = password;

            cadenacon = "Server=127.0.0.1;Port=3306;Database=ejemplo;Uid=" + Session["Usuario"] + ";password=" + Session["password"];  
            conexion.conexion conexion = new conexion.conexion(cadenacon);
            
            try
            {
                conexion.connection.Open();
                command.Connection = conexion.connection;
                command.CommandText = "SELECT user FROM mysql.user WHERE user = " +"'" + usuario +"'";
                command.ExecuteReader();               
                Response.Redirect("https://localhost:44300/WF/Inicio.aspx");

            }
            catch (Exception ex)
            {
                MsgBox("No es posible iniciar sesion, Por favor revise sus datos", this.Page, this);                
            }
        }
    }
}