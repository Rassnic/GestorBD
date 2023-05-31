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
            llenarBases();
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
            conexion.connection.Close();
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

        public DataTable consultarBases()
        {
            try
            {
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
                lblMensaje.Text = "Instruccion fallida " + ex;
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
                lblMensaje.Text = "Instruccion fallida " + ex;
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
                lblMensaje.Text = "Instruccion fallida " + ex;
                lblMensaje.Visible = true;
            }
            
        }
    }
}