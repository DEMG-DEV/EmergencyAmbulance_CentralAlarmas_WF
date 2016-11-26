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
    public partial class ListasEmergencias : Form
    {
        private string[] Datos;
        string port = "3306", server = "", user = "", pass = "", database = "emergency";

        public ListasEmergencias(string[] conection)
        {
            InitializeComponent();
            this.server = conection[0];
            this.user = conection[1];
            this.pass = conection[2];
            emergenciasTableAdapter.Connection.ConnectionString = "Server=" + server + "; Port=" + port + "; Database=" + database + "; Uid=" + user + "; Pwd=" + pass + ";";
            Datos = conection;
            this.WindowState = FormWindowState.Maximized;
        }

        private void ListasEmergencias_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emergencyDataSet.emergencias' table. You can move, or remove it, as needed.
            this.emergenciasTableAdapter.Fill(this.emergencyDataSet.emergencias);

        }
    }
}
