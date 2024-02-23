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
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SqlClient;

namespace sqlserver_crud_apotik
{
    public partial class Dashboard : Form
    {
        private string loggedInUsername;
        private SqlConnection conn;
        public Dashboard()
        {
            InitializeComponent();
            SetLabelUsername();
            conn = new SqlConnection("Data Source=alyaapunyaaa;Initial Catalog=pharmacy;Integrated Security=True");
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadChart();
        }

        public string LoggedInUsername
        {
            get { return loggedInUsername; }
            set { loggedInUsername = value; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Yakin Ingin Keluar ? ", "Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void LoadChart()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT tgldaftar, COUNT(id) AS JumlahPasien FROM pharmacy GROUP BY tgldaftar ORDER BY tgldaftar", conn);

                SqlDataReader reader = cmd.ExecuteReader();

                chart.Series.Clear();

                Series series = new Series("Jumlah Pasien");
                series.ChartType = SeriesChartType.Column;  // Menggunakan Column Chart
                series.Color = Color.Black;

                while (reader.Read())
                {
                    string tanggal = reader["tgldaftar"].ToString();
                    int jumlahPasien = Convert.ToInt32(reader["JumlahPasien"]);

                    DataPoint dataPoint = new DataPoint();
                    dataPoint.SetValueXY(tanggal, jumlahPasien);
                    dataPoint.Tag = $"Tanggal: {tanggal}, Jumlah Pasien: {jumlahPasien}";

                    series.Points.Add(dataPoint);
                }

                chart.Series.Add(series);

                // Mengatur sumbu x dan y
                chart.ChartAreas[0].AxisX.Title = "Tanggal"; // Ubah judul sumbu x
                chart.ChartAreas[0].AxisY.Title = "Jumlah Pasien"; // Ubah judul sumbu y

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading chart data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
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

        private void SetLabelUsername()
        {
            labelTxt.Text = "Welcome, " + loggedInUsername;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void chart_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
