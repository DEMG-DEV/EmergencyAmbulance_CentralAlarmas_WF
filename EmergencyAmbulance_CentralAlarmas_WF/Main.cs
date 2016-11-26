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
    public partial class Main : Form
    {
        private string[] Datos;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Login l = new Login();
            DialogResult res = l.ShowDialog();

            if (res == DialogResult.OK)
            {
                this.Datos = l.data;
            }
            else if (res == DialogResult.Cancel)
            {
                Main_Load(sender, e);
            }
            else if (res == DialogResult.Abort)
            {
                this.Close();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            altaEmergencia ae = new altaEmergencia(Datos);
            ae.MdiParent = this;
            ae.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ListasEmergencias le = new ListasEmergencias(Datos);
            le.MdiParent = this;
            le.Show();
        }
    }
}
