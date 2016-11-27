using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

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

        private string constructuirGeoURL(string direccion)
        {
            string geoURL = "";

            if (direccion != "")
            {
                direccion = direccion.Trim();
                direccion = direccion.Replace(" ", "+");

                geoURL = @"https://maps.googleapis.com/maps/api/geocode/xml?address=###ADDRESS###&key=AIzaSyCGGQDJlO0nMXZmoh57w0mW5nm5jFo06c4";

                //Sustitución de las variables
                geoURL = geoURL.Replace("###ADDRESS###", direccion);
                //geoURL = geoURL.Replace("###OUTPUT###", "csv");
                geoURL = geoURL.Replace("###KEY###", "");
            }

            return geoURL;
        }

        private string[] cargarLatitudLatitud(string geoURL)
        {
            // codigo que lee archivo xml
            string[] geoValues = new string[2];

            XmlDocument docXml = new XmlDocument();
            docXml.Load(geoURL);
            
            geoValues[0] = docXml.DocumentElement.SelectSingleNode("result").SelectSingleNode("geometry").SelectSingleNode("location").SelectSingleNode("lat").InnerText.ToString();
            geoValues[1] = docXml.DocumentElement.SelectSingleNode("result").SelectSingleNode("geometry").SelectSingleNode("location").SelectSingleNode("lng").InnerText.ToString();

            // codigo viejo con csv
            //string[] geoValues = new string[4];

            //string csvValues = "";
            //string Latitud = "";
            //string Longitud = "";
            //string Respuesta_geo = "";
            //try
            //{
            //    WebRequest objWebRequest = WebRequest.Create(geoURL);
            //    WebResponse objWebResponse = objWebRequest.GetResponse();
            //    Stream objWebStream = objWebResponse.GetResponseStream();

            //    using (StreamReader objStreamReader = new StreamReader(objWebStream))
            //    {
            //        csvValues = objStreamReader.ReadToEnd();
            //    }

            //    if (csvValues != null)
            //    {
            //        geoValues = csvValues.Split(new char[] { ',' });
            //        if (geoValues.Length > 0)
            //        {
            //            Respuesta_geo = geoValues[0].ToString();
            //            Latitud = geoValues[2].ToString();
            //            Longitud = geoValues[3].ToString();
            //        }
            //    }

            //}
            //catch (Exception exp)
            //{
            //}

            return geoValues;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] latlong = new string[2];
            ConexionMySQL conexion = new ConexionMySQL(Datos);
            try
            {
                latlong = cargarLatitudLatitud(constructuirGeoURL(txtNumero.Text + "+" + txtCalle.Text + "+" + txtColonia.Text + "+" + txtCiudad.Text + "+" + txtEstado.Text));
                string Query = "INSERT INTO emergencias(calleEmergencia,coloniaEmergencia,numeroEmergencia,cpEmergencia,ciudadEmergencia,estadoEmergencia,entreCallesEmergencia,otrasReferenciasEmergencia,ubicacionEmergencia)" +
                    " VALUES(\"" + txtCalle.Text + "\",\"" + txtColonia.Text + "\"," + Convert.ToInt32(txtNumero.Text) + "," + Convert.ToInt32(txtCP.Text) + ",\"" + txtCiudad.Text + "\",\"" + txtEstado.Text + "\",\"" + txtEntreCalles.Text + "\",\"" + txtReferencias.Text + "\",\"" + latlong[0] + "," + latlong[1] + "\");";
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
