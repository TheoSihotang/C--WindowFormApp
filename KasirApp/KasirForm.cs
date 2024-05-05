using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

            /*  ConnectionDb connection = new ConnectionDb();
              SqlConnection conn = connection.sqlConnection();
              try
              {
                  conn.Open();
                  string query = "SELECT BarangID FROM tbl_barang";
                  SqlCommand cmd = new SqlCommand(query, conn);
                  SqlDataReader reader = cmd.ExecuteReader();
                  while (reader.Read())
                  {
                      MessageBox.Show(reader["BarangID"].ToString());
                  }
              }
              catch (Exception)
              {

                  throw;
              }*/
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void KasirForm_Load(object sender, EventArgs e)
        {

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
                string name = (string)reader["Nama"].ToString();
                textBox1.Text = name;

                string price = (string)reader["Harga"].ToString();
                string[] prices = price.Split(".");
                textBox2.Text = prices[0];
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 0 && textBox4.Text.Length > 0)
            {
                int? result = Convert.ToInt32(textBox4.Text) * Convert.ToInt32(textBox2.Text);
                textBox3.Text = result.ToString();
                textBox8.Text = result.ToString();
            }
            else
            {
                textBox3.Text = "";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = null;
            textBox3.Text = null;
            textBox2.Text = null;
            textBox1.Text = null;
            textBox4.Text = null;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if(textBox8.Text.Length > 0 && textBox9.Text.Length > 0)
            {
                int result = Convert.ToInt32(textBox9.Text) - Convert.ToInt32(textBox8.Text);
                textBox10.Text = result.ToString();
            } else
            {
                textBox10.Text = null;
            }
        }
    }
}
