﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sqlserver_crud_apotik
{
    public partial class Data : Form
    {
        public Data()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=alyaapunyaaa;Initial Catalog=pharmacy;Integrated Security=True");

        private void bind_data()
        {
            SqlCommand cmd1 = new SqlCommand("Select id, nama, telp, kelamin, tgldaftar, keluhan ,gejala, jenisobat  from pharmacy", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd1;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahona", 8);
        }

        private void Data_Load(object sender, EventArgs e)
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Yakin Ingin Keluar ? ", "Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedrow = dataGridView1.Rows[index];

            txtId.Text = selectedrow.Cells[0].Value.ToString();
            txtNama.Text = selectedrow.Cells[1].Value.ToString();
            txtNoTelp.Text = selectedrow.Cells[2].Value.ToString();
            string kelamin = selectedrow.Cells[3].Value.ToString();
            txtKeluhan.Text = selectedrow.Cells[4].Value.ToString();
            string gejala = selectedrow.Cells[5].Value.ToString();
            string jenisObat = selectedrow.Cells[6].Value.ToString();
            DateTime tglDaftar = DateTime.Parse(selectedrow.Cells[7].Value.ToString());

            if (kelamin == "Laki-laki")
            {
                rdLakiLaki.Checked = true;
                rdPerempuan.Checked = false;
            }
            else if (kelamin == "Perempuan")
            {
                rdLakiLaki.Checked = false;
                rdPerempuan.Checked = true;
            }
            else
            {
                rdLakiLaki.Checked = false;
                rdPerempuan.Checked = false;
            }

            cbDemam.Checked = false;
            cbPusing.Checked = false;
            cbMual.Checked = false;
            cbDiare.Checked = false;

            string[] selectedGejalaArray = gejala.Split(';');
            foreach (string symptom in selectedGejalaArray)
            {
                if (symptom == "Demam") cbDemam.Checked = true;
                if (symptom == "Pusing") cbPusing.Checked = true;
                if (symptom == "Mual") cbMual.Checked = true;
                if (symptom == "Diare") cbDiare.Checked = true;
            }
            ckbObat.SelectedItem = jenisObat;

            dateTimePicker.Value = tglDaftar;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            string kelamin = "";
            if (rdLakiLaki.Checked)
            {
                kelamin = "Laki-laki";
            }
            else if (rdPerempuan.Checked)
            {
                kelamin = "Perempuan";
            }

            string gejala = "";
            if (cbDemam.Checked)
            {
                gejala += "Demam;";
            }
            if (cbPusing.Checked)
            {
                gejala += "Pusing;";
            }
            if (cbMual.Checked)
            {
                gejala += "Mual;";
            }
            if (cbDiare.Checked)
            {
                gejala += "Diare;";
            }
            gejala = gejala.TrimEnd(';');

            String jenisObat = ckbObat.SelectedItem.ToString();

            string tglDaftar = dateTimePicker.Value.ToString("MMMM dd, yyyy");

            SqlCommand cmd2 = new SqlCommand("INSERT INTO pharmacy(id, nama, telp, kelamin, tgldaftar, keluhan ,gejala, jenisobat)Values(@id, @nama, @telp, @kelamin, @tgldaftar, @keluhan ,@gejala, @jenisobat)", conn);
            cmd2.Parameters.AddWithValue("id", txtId.Text);
            cmd2.Parameters.AddWithValue("nama", txtNama.Text);
            cmd2.Parameters.AddWithValue("telp", txtNoTelp.Text);
            cmd2.Parameters.AddWithValue("kelamin", kelamin);
            cmd2.Parameters.AddWithValue("keluhan", txtKeluhan.Text);
            cmd2.Parameters.AddWithValue("gejala", gejala);
            cmd2.Parameters.AddWithValue("jenisobat", jenisObat);
            cmd2.Parameters.AddWithValue("tgldaftar", tglDaftar);
            conn.Open();
            cmd2.ExecuteNonQuery();
            conn.Close();
            bind_data();

            dataGridView1.ReadOnly = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtNama.Text = "";
            txtKeluhan.Text = "";
            txtNoTelp.Text = "";

            ckbObat.SelectedIndex = 0; 

            rdLakiLaki.Checked = false;
            rdPerempuan.Checked = false;

            cbDemam.Checked = false;
            cbPusing.Checked = false;
            cbMual.Checked = false;
            cbDiare.Checked = false;
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedRows[0].Index;
                string selectedId = dataGridView1.Rows[rowIndex].Cells["id"].Value.ToString();

                SqlCommand cmd4 = new SqlCommand("DELETE FROM pharmacy WHERE id=@id", conn);
                cmd4.Parameters.AddWithValue("@id", selectedId);

                conn.Open();
                cmd4.ExecuteNonQuery();
                conn.Close();

                bind_data();
                btnClear_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string kelamin = "";
            if (rdLakiLaki.Checked)
            {
                kelamin = "Laki-laki";
            }
            else if (rdPerempuan.Checked)
            {
                kelamin = "Perempuan";
            }

            string gejala = "";
            if (cbDemam.Checked)
            {
                gejala += "Demam;";
            }
            if (cbPusing.Checked)
            {
                gejala += "Pusing;";
            }
            if (cbMual.Checked)
            {
                gejala += "Mual;";
            }
            if (cbDiare.Checked)
            {
                gejala += "Diare;";
            }
            gejala = gejala.TrimEnd(';');

            String jenisObat = ckbObat.SelectedItem.ToString();

            string tglDaftar = dateTimePicker.Value.ToString("MMMM dd, yyyy");

            SqlCommand cmd3 = new SqlCommand("Update pharmacy Set id=@id, nama=@nama, telp=@telp, kelamin=@kelamin, tgldaftar=@tgldaftar, keluhan=@keluhan ,gejala=@gejala, jenisobat=@jenisobat where id=@id", conn);

            cmd3.Parameters.AddWithValue("id", txtId.Text);
            cmd3.Parameters.AddWithValue("nama", txtNama.Text);
            cmd3.Parameters.AddWithValue("telp", txtNoTelp.Text);
            cmd3.Parameters.AddWithValue("kelamin", kelamin);
            cmd3.Parameters.AddWithValue("keluhan", txtKeluhan.Text);
            cmd3.Parameters.AddWithValue("gejala", gejala);
            cmd3.Parameters.AddWithValue("jenisobat", jenisObat);
            cmd3.Parameters.AddWithValue("tgldaftar", tglDaftar);

            try
            {
                conn.Open();
                cmd3.ExecuteNonQuery();
                conn.Close();
                bind_data();
                MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error updating record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}