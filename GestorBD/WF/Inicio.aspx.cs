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
        conexion.conexion conexion = new conexion.conexion();
        private MySqlCommand command = new MySqlCommand();

        protected void Page_Load(object sender, EventArgs e)
        {
            lblMensaje.Visible = false;
        }

        public DataTable consultar(string consulta) {
            try{ 
            DataTable consultas = new DataTable();
            conexion.connection.Open();
            command.Connection = conexion.connection;
            command.CommandText = consulta;
            consultas.Load(command.ExecuteReader());
            lblMensaje.Text = "Instruccion realizada exitosamente";
            lblMensaje.Visible = true;
            return consultas;
            }
            catch (Exception ex)
            {                
                lblMensaje.Text = "Instruccion fallida " + ex;
                lblMensaje.Visible = true;
            }
            return null;
        }

        protected void btnEjecutar_Click(object sender, EventArgs e)
        {
            try {
                DataTable dt = new DataTable();
                dt = consultar(txtInstruccion.Text);
                DGVSalida.DataSource = dt;
                DGVSalida.DataBind();
                DGVSalida.Visible = true;
            } catch (Exception ex)
            {
                lblMensaje.Text = "Instruccion fallida " + ex;
                lblMensaje.Visible = true;
            }
            
        }
    }
}