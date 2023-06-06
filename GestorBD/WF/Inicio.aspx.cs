using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GestorBD.WF
{
    public partial class Inicio : System.Web.UI.Page
    {
        WF.Login login = new WF.Login();               
        private MySqlCommand command = new MySqlCommand();
        

        protected void Page_Load(object sender, EventArgs e)
        {
            llenarBases();
            lblMensaje.Visible = false;
        }

        public string getconexion()
        {
            string cadena = "Server=127.0.0.1;Port=3306;Database=ejemplo;Uid=" + Session["Usuario"] + ";password=" + Session["password"];
            return cadena;
        }

        public DataTable consultar(string consulta) {

            try
            {            
            conexion.conexion conexion = new conexion.conexion(getconexion());
            DataTable consultas = new DataTable();
            conexion.connection.Open();
            command.Connection = conexion.connection;
            command.CommandText = consulta;
            consultas.Load(command.ExecuteReader());
            lblMensaje.Text = "Instruccion realizada exitosamente";
            conexion.connection.Close();
            lblMensaje.Visible = true;
            return consultas;
            }
            catch (Exception ex)
            { 
                string msg = ex.ToString();                                
                lblMensaje.Text = "Instruccion fallida " + msg.Substring(0, 160);
                lblMensaje.Visible = true;
            }
            return null;
        }

        public DataTable consultarBases()
        {
            try
            {                
                conexion.conexion conexion = new conexion.conexion(getconexion());
                DataTable consultas = new DataTable();
                conexion.connection.Open();
                command.Connection = conexion.connection;
                command.CommandText = "show databases;";
                consultas.Load(command.ExecuteReader());
                conexion.connection.Close();
                return consultas;
            }
            catch (Exception ex)
            {
                string msg = ex.ToString();
                lblMensaje.Text = "Instruccion fallida " + msg.Substring(0, 160);
                lblMensaje.Visible = true;
            }
            return null;
        }

        public void llenarBases() {
            try
            {
                DataTable dt = new DataTable();
                dt = consultarBases();
                DGVBases.DataSource = dt;
                DGVBases.DataBind();
                DGVBases.Visible = true;
            }
            catch (Exception ex)
            {
                string msg = ex.ToString();
                lblMensaje.Text = "Instruccion fallida " + msg.Substring(0, 160);
                lblMensaje.Visible = true;
            }

        }

        protected void btnEjecutar_Click(object sender, EventArgs e)
        {
            try {
                DataTable dt = new DataTable();
                dt = consultar(txtInstruccion.Text);
                DGVSalida.DataSource = dt;
                DGVSalida.DataBind();
                DGVSalida.Visible = true;
                llenarBases();
            } catch (Exception ex)
            {
                string msg = ex.ToString();
                lblMensaje.Text = "Instruccion fallida " + msg.Substring(0, 160);
                lblMensaje.Visible = true;
            }
            
        }

        protected void btnCerrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://localhost:44300/WF/Login.aspx");
            Session["Usuario"] = "";
            Session["password"] = "";
        }
    }
}