using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace sqlserver_crud_apotik
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Yakin Ingin Keluar ? ", "Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void labeltext_Click(object sender, EventArgs e)
        {

        }

        private void navHistory_Click(object sender, EventArgs e)
        {
            new Data().Show();
            this.Hide();
        }

        private void navDashboard_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }
    }
}
