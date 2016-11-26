using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmergencyAmbulance_CentralAlarmas_WF
{
    public partial class altaEmergencia : Form
    {
        private string[] Datos;

        public altaEmergencia(string[] data)
        {
            InitializeComponent();
            this.Datos = data;
        }

        private void altaEmergencia_Load(object sender, EventArgs e)
        {
            obtenerFolio();
        }

        private void obtenerFolio()
        {
            ConexionMySQL conexion = new ConexionMySQL(Datos);
            try
            {
                string Query = "SELECT MAX(idEmergencia) FROM emergencias;";
                MySqlDataAdapter adapter = conexion.conexionGetData(Query);
                DataTable datos = new DataTable();
                adapter.Fill(datos);

                textBox9.Text = Convert.ToString((Convert.ToInt32(datos.Rows[0][0].ToString()) + 1));
                conexion.conexionClose();
            }
            catch (Exception ex)
            {
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConexionMySQL conexion = new ConexionMySQL(Datos);
            try
            {
                string Query = "INSERT INTO emergencias(calleEmergencia,coloniaEmergencia,numeroEmergencia,cpEmergencia,ciudadEmergencia,estadoEmergencia,entreCallesEmergencia,otrasReferenciasEmergencia)" +
                    " VALUES(\"" + txtCalle.Text + "\",\"" + txtColonia.Text + "\"," + Convert.ToInt32(txtNumero.Text) + "," + Convert.ToInt32(txtCP.Text) + ",\"" + txtCiudad.Text + "\",\"" + txtEstado.Text + "\",\"" + txtEntreCalles.Text + "\",\"" + txtReferencias.Text + "\");";
                MySqlDataReader adapter = conexion.conexionSendData(Query);
                while (adapter.Read())
                {
                }
                conexion.conexionClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Agregar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtCalle.Text = "";
            txtCiudad.Text = "";
            txtColonia.Text = "";
            txtCP.Text = "";
            txtEntreCalles.Text = "";
            txtEstado.Text = "";
            txtNumero.Text = "";
            txtReferencias.Text = "";
            obtenerFolio();
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
            }
        }
    }
}
