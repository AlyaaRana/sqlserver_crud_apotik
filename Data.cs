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
using static System.Windows.Forms.LinkLabel;

namespace sqlserver_crud_apotik
{
    public partial class Data : Form
    {
        private string tglDaftar;
        private int rowIndex = -1;
        private decimal totalPrice = 0;
        private int selectedIndex = -1;

        public Data()
        {
            InitializeComponent();
            bind_data();
            CustomizeDataGridView();
            ckbObat.DropDownStyle = ComboBoxStyle.DropDownList;
            totalBayar.TextChanged += totalBayar_TextChanged; 

        }

        private void CustomizeDataGridView()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill ;
        }

        SqlConnection conn = new SqlConnection("Data Source=alyaapunyaaa;Initial Catalog=pharmacy;Integrated Security=True");

        private void bind_data()
        {
            SqlCommand cmd1 = new SqlCommand("Select id, nama, telp, kelamin, tgldaftar, totalbayar ,jumlah,gejala, jenisobat  from pharmacy", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd1;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahona", 8);
            dataGridView1.ReadOnly = true;
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
            int index = e.RowIndex;
            DataGridViewRow selectedrow = dataGridView1.Rows[index];
            rowIndex = e.RowIndex;

            txtId.Text = selectedrow.Cells[0].Value.ToString();
            txtNama.Text = selectedrow.Cells[1].Value.ToString();
            txtNoTelp.Text = selectedrow.Cells[2].Value.ToString();
            string kelamin = selectedrow.Cells[3].Value.ToString();
            tglDaftar = selectedrow.Cells[4].Value.ToString();
            string gejala = selectedrow.Cells["gejala"].Value.ToString();
            /*totalBayar.Text = selectedrow.Cells[7].ToString();*/

            if (int.TryParse(selectedrow.Cells["jumlah"].Value.ToString(), out int quantityValue))
            {
                quantityNumeric.Value = quantityValue;
            }
            else
            {
                MessageBox.Show("Invalid quantity value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Set the totalBayar value
            if (decimal.TryParse(selectedrow.Cells["totalbayar"].Value.ToString(), out decimal totalBayarValue))
            {
                totalBayar.Text = totalBayarValue.ToString();
            }
            else
            {
                MessageBox.Show("Invalid total bayar value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (DateTime.TryParse(selectedrow.Cells[4].Value.ToString(), out DateTime dateTimeValue))
            {
                dateTimePicker.Value = dateTimeValue;
            }

            if (kelamin.Contains(rdLakiLaki.Text))
            {
                rdLakiLaki.Checked = true;
            }
            else if (kelamin.Contains(rdPerempuan.Text))
            {
                rdPerempuan.Checked = true;
            }

           
            string jenisobat = selectedrow.Cells["jenisobat"].Value.ToString();
            if (jenisobat.Contains("Obat Cair"))
            {
                ckbObat.SelectedIndex = 1;
            }
            else if (jenisobat.Contains("Tablet"))
            {
                ckbObat.SelectedIndex = 2;
            }
            else if (jenisobat.Contains("Kapsul"))
            {
                ckbObat.SelectedIndex = 3;
            }
            else if (jenisobat.Contains("Obat Oles"))
            {
                ckbObat.SelectedIndex = 4;
            }
            else if (jenisobat.Contains("Supositoria"))
            {
                ckbObat.SelectedIndex = 4;
            }

            cbDemam.Checked = gejala.Contains("Demam");
            cbPusing.Checked = gejala.Contains("Pusing");
            cbMual.Checked = gejala.Contains("Mual");
            cbDiare.Checked = gejala.Contains("Diare");

            
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

            String gejala = "";
            cbDemam.Checked = gejala.Contains("Demam,");
            cbPusing.Checked = gejala.Contains("Pusing,");
            cbMual.Checked = gejala.Contains("Mual,");
            cbDiare.Checked = gejala.Contains("Diare,");
            gejala = gejala.TrimEnd(',', ' ');

            String jenisObat = ckbObat.SelectedItem.ToString();
            string tglDaftar = dateTimePicker.Value.ToString("MMMM dd, yyyy");

            SqlCommand cmd2 = new SqlCommand("INSERT INTO pharmacy(id, nama, telp, kelamin, tgldaftar, jumlah, gejala, jenisobat, totalbayar) Values(@id, @nama, @telp, @kelamin, @tgldaftar, @jumlah, @gejala, @jenisobat, @totalbayar)", conn);
            cmd2.Parameters.AddWithValue("id", txtId.Text);
            cmd2.Parameters.AddWithValue("nama", txtNama.Text);
            cmd2.Parameters.AddWithValue("telp", txtNoTelp.Text);
            cmd2.Parameters.AddWithValue("kelamin", kelamin);
            cmd2.Parameters.AddWithValue("gejala", gejala);
            cmd2.Parameters.AddWithValue("jenisobat", jenisObat);
            cmd2.Parameters.AddWithValue("tgldaftar", tglDaftar);
            cmd2.Parameters.AddWithValue("totalbayar", totalPrice);
            cmd2.Parameters.AddWithValue("jumlah", quantityNumeric.Value);

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
            txtNoTelp.Text = "";

            ckbObat.SelectedIndex = 0; 

            rdLakiLaki.Checked = false;
            rdPerempuan.Checked = false;

            cbDemam.Checked = false;
            cbPusing.Checked = false;
            cbMual.Checked = false;
            cbDiare.Checked = false;

            quantityNumeric.Value = 0;
            totalBayar.Text = "";

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

                MessageBox.Show("Data berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            cbDemam.Checked = gejala.Contains("Demam");
            cbPusing.Checked = gejala.Contains("Pusing");
            cbMual.Checked = gejala.Contains("Mual");
            cbDiare.Checked = gejala.Contains("Diare");

            String jenisObat = "";
            if (ckbObat.SelectedIndex != -1)
            {
                jenisObat = ckbObat.Items[ckbObat.SelectedIndex].ToString();
            }

            string tglDaftar = dateTimePicker.Value.ToString("MMMM dd, yyyy");

            SqlCommand cmd3 = new SqlCommand("Update pharmacy Set id=@id, nama=@nama, telp=@telp, kelamin=@kelamin,gejala=@gejala, jenisobat=@jenisobat, tgldaftar=@tgldaftar,totalbayar=@totalbayar ,jumlah=@jumlah where id=@id", conn);


            cmd3.Parameters.AddWithValue("id", txtId.Text);
            cmd3.Parameters.AddWithValue("nama", txtNama.Text);
            cmd3.Parameters.AddWithValue("telp", txtNoTelp.Text);
            cmd3.Parameters.AddWithValue("kelamin", kelamin);
            cmd3.Parameters.AddWithValue("jumlah", quantityNumeric.Value);
            cmd3.Parameters.AddWithValue("gejala", gejala);
            cmd3.Parameters.AddWithValue("jenisobat", jenisObat);
            cmd3.Parameters.AddWithValue("tgldaftar", tglDaftar);
            cmd3.Parameters.AddWithValue("totalbayar", totalPrice);

            try
            {
                conn.Open();
                cmd3.ExecuteNonQuery();
                UpdateTotalBayar(txtId.Text, jenisObat);
                bind_data();
                MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void UpdateTotalBayar(string id, string jenisObat)
        {
            try
            {
                SqlCommand cmdSelect = new SqlCommand("SELECT harga FROM obat WHERE jenisobat = @jenisobat", conn);
                cmdSelect.Parameters.AddWithValue("jenisobat", jenisObat);

                conn.Open();
                SqlDataReader reader = cmdSelect.ExecuteReader();

                if (reader.Read())
                {
                    decimal hargaObat = Convert.ToDecimal(reader["harga"]);
                    decimal jumlah;
                    if (decimal.TryParse(quantityNumeric.Text, out jumlah))
                    {
                        decimal totalBayar = hargaObat * jumlah;

                        // Update total bayar in the pharmacy table
                        SqlCommand cmdUpdateTotalBayar = new SqlCommand("UPDATE pharmacy SET totalbayar=@totalbayar WHERE id=@id", conn);
                        cmdUpdateTotalBayar.Parameters.AddWithValue("totalbayar", totalBayar);
                        cmdUpdateTotalBayar.Parameters.AddWithValue("id", id);

                        reader.Close(); // Close the reader before executing the update query
                        cmdUpdateTotalBayar.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Invalid quantity value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Jenis obat tidak ditemukan atau invalid total price value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating total bayar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }




        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Select id, nama, telp, kelamin, tgldaftar, keluhan ,gejala, jenisobat from pharmacy where nama Like @nama+'%'", conn);

            sqlCommand.Parameters.AddWithValue("nama", txtSearch.Text);

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = sqlCommand;

            DataTable dataTable = new DataTable();
            dataTable.Clear();
            dataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                dataGridView1.DataSource = dataTable;
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9);
                dataGridView1.DefaultCellStyle.Font = new Font("Tahona", 8);
            }
            else
            {
                dataGridView1.DataSource = null;
                MessageBox.Show("Data kosong.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPrintPdf_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }

        private void ckbObat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap imagebmp = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(imagebmp, new Rectangle(0, 0, imagebmp.Width, imagebmp.Height));
            e.Graphics.DrawImage(imagebmp, 120, 20);
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void quantityNumeric_ValueChanged(object sender, EventArgs e)
        {

        }

        private void totalBayar_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalBayar();
        }

        private decimal[] jenisObatPrices = { 0, 10000, 15000, 20000, 30000, 25000 };

        private decimal CalculateTotalBayar()
        {
            if (ckbObat.SelectedIndex >= 0 && ckbObat.SelectedIndex < jenisObatPrices.Length)
            {
                int selectedIndex = ckbObat.SelectedIndex;
                decimal jenisObatPrice = jenisObatPrices[selectedIndex];

                int quantity = (int)quantityNumeric.Value;
                totalPrice = jenisObatPrice * quantity;
                decimal total = quantityNumeric.Value * jenisObatPrice;
                totalBayar.Text = total.ToString();
            }
            else
            {
                MessageBox.Show("Please select a valid jenis obat.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                totalPrice = 0; 
                totalBayar.Text = totalPrice.ToString();
            }


            return totalPrice;
        }

        private decimal CalculateTotalBayarFromDatabase(string id)
        {
            SqlCommand cmd = new SqlCommand("SELECT totalbayar FROM pharmacy WHERE id=@id", conn);
            cmd.Parameters.AddWithValue("@id", id);

            decimal totalBayar = 0;

            try
            {
                conn.Open();
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    totalBayar = Convert.ToDecimal(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating total bayar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return totalBayar;
        }


    }
}
