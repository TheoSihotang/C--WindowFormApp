namespace KasirApp
{
    partial class KasirForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            button3 = new Button();
            textBox8 = new TextBox();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            button4 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 108);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 0;
            label1.Text = "No Faktur";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 156);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 1;
            label2.Text = "Tgl Faktur";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(553, 108);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "Operator";
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(26, 199);
            panel1.Name = "panel1";
            panel1.Size = new Size(813, 87);
            panel1.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(17, 33);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(186, 28);
            comboBox1.TabIndex = 14;
            comboBox1.Text = "--Pilih Kode Barang---";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(548, 35);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(60, 27);
            textBox4.TabIndex = 13;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Info;
            textBox3.Enabled = false;
            textBox3.Location = new Point(660, 34);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Info;
            textBox2.Enabled = false;
            textBox2.Location = new Point(399, 35);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Info;
            textBox1.Enabled = false;
            textBox1.Location = new Point(237, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(657, 11);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 9;
            label8.Text = "SubTotal";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(548, 11);
            label7.Name = "label7";
            label7.Size = new Size(60, 20);
            label7.TabIndex = 8;
            label7.Text = "Jml Beli";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(399, 11);
            label6.Name = "label6";
            label6.Size = new Size(99, 20);
            label6.TabIndex = 7;
            label6.Text = "Harga Satuan";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(237, 11);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 6;
            label5.Text = "Nama Barang";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 11);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 4;
            label4.Text = "Kode Barang";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Window;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Location = new Point(574, 299);
            button1.Name = "button1";
            button1.Size = new Size(105, 52);
            button1.TabIndex = 14;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Window;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.Location = new Point(706, 299);
            button2.Name = "button2";
            button2.Size = new Size(105, 52);
            button2.TabIndex = 15;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(26, 370);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(813, 259);
            dataGridView1.TabIndex = 16;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(135, 105);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 14;
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.Info;
            textBox6.Enabled = false;
            textBox6.Location = new Point(135, 156);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 17;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(643, 108);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(125, 27);
            textBox7.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(20, 9);
            label9.Name = "label9";
            label9.Size = new Size(209, 46);
            label9.TabIndex = 19;
            label9.Text = "Apotek XYZ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(27, 64);
            label10.Name = "label10";
            label10.Size = new Size(175, 20);
            label10.TabIndex = 20;
            label10.Text = "Drugs Store and Supplier";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(29, 658);
            label11.Name = "label11";
            label11.Size = new Size(85, 20);
            label11.TabIndex = 14;
            label11.Text = "Perhatian !";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(30, 692);
            label12.Name = "label12";
            label12.Size = new Size(272, 40);
            label12.TabIndex = 21;
            label12.Text = "Barang yang sudah dibeli, tidak dapat \r\nditukar atau dikembalikan";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Window;
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.Font = new Font("Microsoft Sans Serif", 8.25F);
            button3.Location = new Point(30, 795);
            button3.Name = "button3";
            button3.Size = new Size(105, 38);
            button3.TabIndex = 22;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox8
            // 
            textBox8.BackColor = SystemColors.Info;
            textBox8.Enabled = false;
            textBox8.Location = new Point(706, 652);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(125, 27);
            textBox8.TabIndex = 16;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(596, 655);
            label13.Name = "label13";
            label13.Size = new Size(42, 20);
            label13.TabIndex = 15;
            label13.Text = "Total";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(596, 705);
            label14.Name = "label14";
            label14.Size = new Size(94, 20);
            label14.TabIndex = 23;
            label14.Text = "Jumlah Uang";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(596, 753);
            label15.Name = "label15";
            label15.Size = new Size(64, 20);
            label15.TabIndex = 24;
            label15.Text = "Kembali";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(706, 702);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(125, 27);
            textBox9.TabIndex = 25;
            textBox9.TextChanged += textBox9_TextChanged;
            // 
            // textBox10
            // 
            textBox10.BackColor = SystemColors.Info;
            textBox10.Enabled = false;
            textBox10.Location = new Point(706, 750);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(125, 27);
            textBox10.TabIndex = 26;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Window;
            button4.BackgroundImageLayout = ImageLayout.Center;
            button4.Font = new Font("Microsoft Sans Serif", 8.25F);
            button4.Location = new Point(725, 795);
            button4.Name = "button4";
            button4.Size = new Size(105, 38);
            button4.TabIndex = 27;
            button4.Text = "Save";
            button4.UseVisualStyleBackColor = false;
            // 
            // KasirForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 860);
            Controls.Add(button4);
            Controls.Add(textBox10);
            Controls.Add(textBox9);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(textBox8);
            Controls.Add(label13);
            Controls.Add(button3);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "KasirForm";
            Text = "Data Transaksi";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Label label4;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button button3;
        private ComboBox comboBox1;
        private TextBox textBox8;
        private Label label13;
        private Label label14;
        private Label label15;
        private TextBox textBox9;
        private TextBox textBox10;
        private Button button4;
    }
}