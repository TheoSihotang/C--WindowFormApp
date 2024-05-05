using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KasirApp
{
    public partial class KasirForm : Form
    {
        ConnectionDb connection = new ConnectionDb();
        public KasirForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            FillComboBox();
            DateTime date = DateTime.Now;
            string tanggal = date.Day.ToString();
            string bulan = date.ToString("MMMM");
            string tahun = date.Year.ToString();
            textBox6.Text = $"{tanggal} {bulan} {tahun}";
            NoFaktur();
            textBox7.Text = "Tes";
        }

        private void NoFaktur()
        {
            SqlConnection conn = connection.sqlConnection();
            conn.Open();
            string query = "SELECT MAX(CAST(SUBSTRING(NoFaktur, 2, LEN(NoFaktur)) AS INT)) AS LastInvoiceNumber FROM tbl_trx";
            SqlCommand cmd = new SqlCommand(query, conn);
            Object getNoFaktur = cmd.ExecuteScalar();
            if (getNoFaktur != DBNull.Value)
            {
                int noFaktur = Convert.ToInt32(getNoFaktur);
                string placeNoFaktur = "F" + (noFaktur + 1).ToString("D3");
                textBox5.Text = placeNoFaktur;
            }
            else
            {
                textBox5.Text = "F001";
            }
            conn.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void FillComboBox()
        {
            SqlDataReader reader = KodeBarang();

            while (reader.Read())
            {
                comboBox1.Items.Add(reader["BarangID"]);
            }
        }

        private static SqlDataReader KodeBarang()
        {

            ConnectionDb connection = new ConnectionDb();
            SqlConnection conn = connection.sqlConnection();
            conn.Open();

            string query = "SELECT * FROM tbl_barang";
            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = connection.sqlConnection();

            string query = "SELECT * FROM tbl_barang WHERE BarangID ='" + comboBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string? name = (string?)reader["Nama"].ToString();
                textBox1.Text = name;

                string? price = (string?)reader["Harga"].ToString();
                string[]? prices = price?.Split(".");
                textBox2.Text = CurrentcyFormat(prices?[0]);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 0 && textBox4.Text.Length > 0)
            {
                int? result = Convert.ToInt32(textBox4.Text) * Convert.ToInt32(Regex.Replace(textBox2.Text, @"\D", ""));
                textBox3.Text = CurrentcyFormat(result.ToString());
                textBox8.Text = CurrentcyFormat(result.ToString());
            }
            else
            {
                textBox3.Text = "";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            comboBox1.SelectedItem = null;
            textBox3.Text = null;
            textBox2.Text = null;
            textBox1.Text = null;
            textBox4.Text = null;
            textBox8.Text = null;
            textBox9.Text = null;
            textBox10.Text = null;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

            if (textBox8.Text.Length > 0 && textBox9.Text.Length > 0)
            {
                textBox9.Text = CurrentcyFormat(textBox9.Text);
                textBox9.Select(textBox9.Text.Length, 0);
                string ignoreCharPay = Regex.Replace(textBox9.Text, @"\D", "");
                string ignoreCharSubTotal = Regex.Replace(textBox8.Text, @"\D", "");

                int result = Convert.ToInt32(ignoreCharPay) - Convert.ToInt32(ignoreCharSubTotal);
                if (result > 0)
                {
                    textBox10.Text = result.ToString();
                    textBox10.Text = CurrentcyFormat(textBox10.Text);
                }
                else
                {
                    textBox10.Text = "";
                }
            }
            else
            {
                textBox10.Text = null;
            }
        }

        private string CurrentcyFormat(String value)
        {
            string cleanAnyChar = new string(value.Where(char.IsDigit).ToArray());

            int converToInteger = 0;
            int.TryParse(cleanAnyChar, out converToInteger);

            return converToInteger.ToString("#,##0", new CultureInfo("id-ID"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(dataGridView1.Rows.Count, comboBox1.Text, textBox1.Text, textBox4.Text, textBox3.Text);
            ClearForm();
            NoFaktur();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = connection.sqlConnection();
            conn.Open();
            SqlTransaction transaction = conn.BeginTransaction();

            try
            {
                string query = "INSERT INTO tbl_trx(FinalTotal) VALUES (@FinalTotal); SELECT SCOPE_IDENTITY();";
                SqlCommand cmdTrx = new SqlCommand(query, conn, transaction);
                int result = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    int value;

                    string subTotal = Convert.ToString(row.Cells["SubTotal"].Value);
                    if (!string.IsNullOrEmpty(subTotal))
                    {
                        string ignoreChar = Regex.Replace(subTotal, @"\D", "");
                        if (!string.IsNullOrEmpty(ignoreChar) && int.TryParse(ignoreChar, out value))
                        {
                            result += value;
                        }
                    }
                }

                cmdTrx.Parameters.AddWithValue("@FinalTotal", result);
                int idTrx = Convert.ToInt32(cmdTrx.ExecuteScalar());

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["BarangID"].Value != null && row.Cells["BarangID"].Value != DBNull.Value && !string.IsNullOrWhiteSpace(row.Cells["BarangID"].Value.ToString()))
                    {
                        string convertToNumber = new string(row.Cells["BarangID"].Value.ToString().Where(char.IsDigit).ToArray());
                        int barangID;
                        if (int.TryParse(convertToNumber, out barangID))
                        {
                            string queryTrxDtl = "INSERT INTO tbl_trx_dtl (IDBarang, IDFaktur) VALUES (@IDBarang, @IDFaktur)";
                            SqlCommand cmdDtl = new SqlCommand(queryTrxDtl, conn, transaction);
                            cmdDtl.Parameters.AddWithValue("@IDBarang", barangID);
                            cmdDtl.Parameters.AddWithValue("@IDFaktur", idTrx);
                            int resultDtl = cmdDtl.ExecuteNonQuery();
                            if (resultDtl > 0)
                            {
                                MessageBox.Show("sukses simpa data");
                            }
                            else
                            {
                                MessageBox.Show("gagal");
                            }
                        }
                    }
                }

                transaction.Commit();
                MessageBox.Show("Transaksi berhasil disimpan");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
                transaction.Rollback();
            }
            finally
            {
                conn.Close();
            }
        }
    }
}



       
   
