namespace Kependudukan
{
    partial class DataPenduduk
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
            this.dataGridViewPenduduk = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnUbahData = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnKelurahan = new System.Windows.Forms.Button();
            this.btnKecamatan = new System.Windows.Forms.Button();
            this.btnKabupaten = new System.Windows.Forms.Button();
            this.btnAnggota = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPenduduk)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPenduduk
            // 
            this.dataGridViewPenduduk.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPenduduk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPenduduk.Location = new System.Drawing.Point(12, 94);
            this.dataGridViewPenduduk.Name = "dataGridViewPenduduk";
            this.dataGridViewPenduduk.Size = new System.Drawing.Size(546, 244);
            this.dataGridViewPenduduk.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Penduduk";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tambah Data Penduduk";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonTambahData_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(380, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Hapus Data Penduduk";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonHapusData_Click);
            // 
            // btnUbahData
            // 
            this.btnUbahData.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbahData.Location = new System.Drawing.Point(196, 53);
            this.btnUbahData.Name = "btnUbahData";
            this.btnUbahData.Size = new System.Drawing.Size(178, 35);
            this.btnUbahData.TabIndex = 4;
            this.btnUbahData.Text = "Ubah Data Penduduk";
            this.btnUbahData.UseVisualStyleBackColor = true;
            this.btnUbahData.Click += new System.EventHandler(this.btnUbahData_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(483, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 28);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnKelurahan
            // 
            this.btnKelurahan.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKelurahan.Location = new System.Drawing.Point(12, 356);
            this.btnKelurahan.Name = "btnKelurahan";
            this.btnKelurahan.Size = new System.Drawing.Size(80, 28);
            this.btnKelurahan.TabIndex = 6;
            this.btnKelurahan.Text = "Kelurahan";
            this.btnKelurahan.UseVisualStyleBackColor = true;
            this.btnKelurahan.Click += new System.EventHandler(this.btnKelurahan_Click);
            // 
            // btnKecamatan
            // 
            this.btnKecamatan.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKecamatan.Location = new System.Drawing.Point(98, 356);
            this.btnKecamatan.Name = "btnKecamatan";
            this.btnKecamatan.Size = new System.Drawing.Size(92, 28);
            this.btnKecamatan.TabIndex = 7;
            this.btnKecamatan.Text = "Kecamatan";
            this.btnKecamatan.UseVisualStyleBackColor = true;
            this.btnKecamatan.Click += new System.EventHandler(this.btnKecamatan_Click);
            // 
            // btnKabupaten
            // 
            this.btnKabupaten.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKabupaten.Location = new System.Drawing.Point(196, 356);
            this.btnKabupaten.Name = "btnKabupaten";
            this.btnKabupaten.Size = new System.Drawing.Size(92, 28);
            this.btnKabupaten.TabIndex = 8;
            this.btnKabupaten.Text = "Kabupaten";
            this.btnKabupaten.UseVisualStyleBackColor = true;
            this.btnKabupaten.Click += new System.EventHandler(this.btnKabupaten_Click);
            // 
            // btnAnggota
            // 
            this.btnAnggota.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnggota.Location = new System.Drawing.Point(294, 356);
            this.btnAnggota.Name = "btnAnggota";
            this.btnAnggota.Size = new System.Drawing.Size(137, 28);
            this.btnAnggota.TabIndex = 9;
            this.btnAnggota.Text = "Anggota Keluarga";
            this.btnAnggota.UseVisualStyleBackColor = true;
            this.btnAnggota.Click += new System.EventHandler(this.btnAnggota_Click);
            // 
            // DataPenduduk
            // 
            this.ClientSize = new System.Drawing.Size(571, 423);
            this.Controls.Add(this.btnAnggota);
            this.Controls.Add(this.btnKabupaten);
            this.Controls.Add(this.btnKecamatan);
            this.Controls.Add(this.btnKelurahan);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnUbahData);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewPenduduk);
            this.Name = "DataPenduduk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Penduduk";
            this.Load += new System.EventHandler(this.DataPenduduk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPenduduk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPenduduk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnUbahData;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnKelurahan;
        private System.Windows.Forms.Button btnKecamatan;
        private System.Windows.Forms.Button btnKabupaten;
        private System.Windows.Forms.Button btnAnggota;
    }
}

