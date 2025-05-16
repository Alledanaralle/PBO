namespace Kependudukan
{
    partial class FromKK
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nik_lbl = new System.Windows.Forms.Label();
            this.NoKK_txt = new System.Windows.Forms.TextBox();
            this.simpan_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.batal_btn = new System.Windows.Forms.Button();
            this.hapus_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kabupaten_lbl = new System.Windows.Forms.Label();
            this.kabupaten_cmb = new System.Windows.Forms.ComboBox();
            this.kecamatan_cmb = new System.Windows.Forms.ComboBox();
            this.kecamatan_lbl = new System.Windows.Forms.Label();
            this.kelurahan_cmb = new System.Windows.Forms.ComboBox();
            this.kelurahan_lbl = new System.Windows.Forms.Label();
            this.id_cmb = new System.Windows.Forms.ComboBox();
            this.kartukeluarga_dgv = new System.Windows.Forms.DataGridView();
            this.Alamat_txt = new System.Windows.Forms.TextBox();
            this.pencarian_gbox = new System.Windows.Forms.GroupBox();
            this.pencarian_txt = new System.Windows.Forms.TextBox();
            this.no_kk = new System.Windows.Forms.Label();
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_kepala_keluarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_kabupaten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdKecamatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kartukeluarga_dgv)).BeginInit();
            this.pencarian_gbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "No.KK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alamat";
            // 
            // nik_lbl
            // 
            this.nik_lbl.AutoSize = true;
            this.nik_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nik_lbl.Location = new System.Drawing.Point(179, 197);
            this.nik_lbl.Name = "nik_lbl";
            this.nik_lbl.Size = new System.Drawing.Size(48, 25);
            this.nik_lbl.TabIndex = 2;
            this.nik_lbl.Text = "NIK";
            this.nik_lbl.Click += new System.EventHandler(this.nik_lbl_Click);
            // 
            // NoKK_txt
            // 
            this.NoKK_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoKK_txt.Location = new System.Drawing.Point(310, 74);
            this.NoKK_txt.Multiline = true;
            this.NoKK_txt.Name = "NoKK_txt";
            this.NoKK_txt.Size = new System.Drawing.Size(335, 39);
            this.NoKK_txt.TabIndex = 3;
            // 
            // simpan_btn
            // 
            this.simpan_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.simpan_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpan_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.simpan_btn.Location = new System.Drawing.Point(124, 387);
            this.simpan_btn.Name = "simpan_btn";
            this.simpan_btn.Size = new System.Drawing.Size(93, 35);
            this.simpan_btn.TabIndex = 5;
            this.simpan_btn.Text = "Simpan";
            this.simpan_btn.UseVisualStyleBackColor = false;
            this.simpan_btn.Click += new System.EventHandler(this.simpan_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.BackColor = System.Drawing.Color.Green;
            this.edit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.edit_btn.Location = new System.Drawing.Point(223, 387);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(89, 35);
            this.edit_btn.TabIndex = 7;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = false;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // batal_btn
            // 
            this.batal_btn.BackColor = System.Drawing.SystemColors.GrayText;
            this.batal_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batal_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.batal_btn.Location = new System.Drawing.Point(318, 387);
            this.batal_btn.Name = "batal_btn";
            this.batal_btn.Size = new System.Drawing.Size(91, 35);
            this.batal_btn.TabIndex = 8;
            this.batal_btn.Text = "Batal";
            this.batal_btn.UseVisualStyleBackColor = false;
            this.batal_btn.Click += new System.EventHandler(this.batal_btn_Click);
            // 
            // hapus_btn
            // 
            this.hapus_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hapus_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hapus_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hapus_btn.Location = new System.Drawing.Point(415, 387);
            this.hapus_btn.Name = "hapus_btn";
            this.hapus_btn.Size = new System.Drawing.Size(91, 35);
            this.hapus_btn.TabIndex = 9;
            this.hapus_btn.Text = "Hapus";
            this.hapus_btn.UseVisualStyleBackColor = false;
            this.hapus_btn.Click += new System.EventHandler(this.hapus_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.Location = new System.Drawing.Point(512, 387);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(89, 35);
            this.exit_btn.TabIndex = 11;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kabupaten_lbl);
            this.groupBox1.Controls.Add(this.kabupaten_cmb);
            this.groupBox1.Controls.Add(this.kecamatan_cmb);
            this.groupBox1.Controls.Add(this.kecamatan_lbl);
            this.groupBox1.Controls.Add(this.kelurahan_cmb);
            this.groupBox1.Controls.Add(this.kelurahan_lbl);
            this.groupBox1.Controls.Add(this.id_cmb);
            this.groupBox1.Controls.Add(this.kartukeluarga_dgv);
            this.groupBox1.Controls.Add(this.Alamat_txt);
            this.groupBox1.Controls.Add(this.exit_btn);
            this.groupBox1.Controls.Add(this.nik_lbl);
            this.groupBox1.Controls.Add(this.pencarian_gbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.hapus_btn);
            this.groupBox1.Controls.Add(this.edit_btn);
            this.groupBox1.Controls.Add(this.batal_btn);
            this.groupBox1.Controls.Add(this.simpan_btn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(44, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 746);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Form Kartu Keluarga";
            // 
            // kabupaten_lbl
            // 
            this.kabupaten_lbl.AutoSize = true;
            this.kabupaten_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kabupaten_lbl.Location = new System.Drawing.Point(110, 236);
            this.kabupaten_lbl.Name = "kabupaten_lbl";
            this.kabupaten_lbl.Size = new System.Drawing.Size(117, 25);
            this.kabupaten_lbl.TabIndex = 26;
            this.kabupaten_lbl.Text = "Kabupaten";
            // 
            // kabupaten_cmb
            // 
            this.kabupaten_cmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kabupaten_cmb.FormattingEnabled = true;
            this.kabupaten_cmb.Location = new System.Drawing.Point(266, 236);
            this.kabupaten_cmb.Name = "kabupaten_cmb";
            this.kabupaten_cmb.Size = new System.Drawing.Size(335, 33);
            this.kabupaten_cmb.TabIndex = 25;
            // 
            // kecamatan_cmb
            // 
            this.kecamatan_cmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kecamatan_cmb.FormattingEnabled = true;
            this.kecamatan_cmb.Location = new System.Drawing.Point(266, 276);
            this.kecamatan_cmb.Name = "kecamatan_cmb";
            this.kecamatan_cmb.Size = new System.Drawing.Size(335, 33);
            this.kecamatan_cmb.TabIndex = 24;
            // 
            // kecamatan_lbl
            // 
            this.kecamatan_lbl.AutoSize = true;
            this.kecamatan_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kecamatan_lbl.Location = new System.Drawing.Point(106, 276);
            this.kecamatan_lbl.Name = "kecamatan_lbl";
            this.kecamatan_lbl.Size = new System.Drawing.Size(121, 25);
            this.kecamatan_lbl.TabIndex = 23;
            this.kecamatan_lbl.Text = "Kecamatan";
            // 
            // kelurahan_cmb
            // 
            this.kelurahan_cmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kelurahan_cmb.FormattingEnabled = true;
            this.kelurahan_cmb.Location = new System.Drawing.Point(266, 315);
            this.kelurahan_cmb.Name = "kelurahan_cmb";
            this.kelurahan_cmb.Size = new System.Drawing.Size(335, 33);
            this.kelurahan_cmb.TabIndex = 22;
            // 
            // kelurahan_lbl
            // 
            this.kelurahan_lbl.AutoSize = true;
            this.kelurahan_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kelurahan_lbl.Location = new System.Drawing.Point(116, 318);
            this.kelurahan_lbl.Name = "kelurahan_lbl";
            this.kelurahan_lbl.Size = new System.Drawing.Size(111, 25);
            this.kelurahan_lbl.TabIndex = 21;
            this.kelurahan_lbl.Text = "Kelurahan";
            // 
            // id_cmb
            // 
            this.id_cmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_cmb.FormattingEnabled = true;
            this.id_cmb.Location = new System.Drawing.Point(266, 194);
            this.id_cmb.Name = "id_cmb";
            this.id_cmb.Size = new System.Drawing.Size(335, 33);
            this.id_cmb.TabIndex = 20;
            // 
            // kartukeluarga_dgv
            // 
            this.kartukeluarga_dgv.AllowUserToAddRows = false;
            this.kartukeluarga_dgv.AllowUserToDeleteRows = false;
            this.kartukeluarga_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kartukeluarga_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cId,
            this.cNama,
            this.id_kepala_keluarga,
            this.id_kabupaten,
            this.IdKecamatan});
            this.kartukeluarga_dgv.Location = new System.Drawing.Point(35, 531);
            this.kartukeluarga_dgv.Margin = new System.Windows.Forms.Padding(4);
            this.kartukeluarga_dgv.Name = "kartukeluarga_dgv";
            this.kartukeluarga_dgv.ReadOnly = true;
            this.kartukeluarga_dgv.RowHeadersWidth = 51;
            this.kartukeluarga_dgv.Size = new System.Drawing.Size(582, 179);
            this.kartukeluarga_dgv.TabIndex = 17;
            this.kartukeluarga_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kartukeluarga_dgv_CellContentClick);
            this.kartukeluarga_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.f);
            // 
            // Alamat_txt
            // 
            this.Alamat_txt.BackColor = System.Drawing.Color.White;
            this.Alamat_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alamat_txt.Location = new System.Drawing.Point(266, 99);
            this.Alamat_txt.Multiline = true;
            this.Alamat_txt.Name = "Alamat_txt";
            this.Alamat_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Alamat_txt.Size = new System.Drawing.Size(335, 80);
            this.Alamat_txt.TabIndex = 16;
            // 
            // pencarian_gbox
            // 
            this.pencarian_gbox.Controls.Add(this.pencarian_txt);
            this.pencarian_gbox.Controls.Add(this.no_kk);
            this.pencarian_gbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pencarian_gbox.Location = new System.Drawing.Point(35, 444);
            this.pencarian_gbox.Margin = new System.Windows.Forms.Padding(4);
            this.pencarian_gbox.Name = "pencarian_gbox";
            this.pencarian_gbox.Padding = new System.Windows.Forms.Padding(4);
            this.pencarian_gbox.Size = new System.Drawing.Size(417, 68);
            this.pencarian_gbox.TabIndex = 13;
            this.pencarian_gbox.TabStop = false;
            this.pencarian_gbox.Text = "Pencarian";
            // 
            // pencarian_txt
            // 
            this.pencarian_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pencarian_txt.Location = new System.Drawing.Point(72, 25);
            this.pencarian_txt.Margin = new System.Windows.Forms.Padding(4);
            this.pencarian_txt.Multiline = true;
            this.pencarian_txt.Name = "pencarian_txt";
            this.pencarian_txt.Size = new System.Drawing.Size(337, 33);
            this.pencarian_txt.TabIndex = 1;
            this.pencarian_txt.TextChanged += new System.EventHandler(this.NoKK_txt_TextChanged);
            // 
            // no_kk
            // 
            this.no_kk.AutoSize = true;
            this.no_kk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_kk.Location = new System.Drawing.Point(8, 28);
            this.no_kk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.no_kk.Name = "no_kk";
            this.no_kk.Size = new System.Drawing.Size(56, 20);
            this.no_kk.TabIndex = 0;
            this.no_kk.Text = "No.KK";
            // 
            // cId
            // 
            this.cId.DataPropertyName = "NoKK";
            this.cId.HeaderText = "NO.KK";
            this.cId.MinimumWidth = 6;
            this.cId.Name = "cId";
            this.cId.ReadOnly = true;
            this.cId.Width = 200;
            // 
            // cNama
            // 
            this.cNama.DataPropertyName = "IdPendudukKepala";
            this.cNama.HeaderText = "NIK";
            this.cNama.MinimumWidth = 6;
            this.cNama.Name = "cNama";
            this.cNama.ReadOnly = true;
            this.cNama.Width = 200;
            // 
            // id_kepala_keluarga
            // 
            this.id_kepala_keluarga.DataPropertyName = "Alamat";
            this.id_kepala_keluarga.HeaderText = "ALAMAT";
            this.id_kepala_keluarga.MinimumWidth = 6;
            this.id_kepala_keluarga.Name = "id_kepala_keluarga";
            this.id_kepala_keluarga.ReadOnly = true;
            this.id_kepala_keluarga.Width = 200;
            // 
            // id_kabupaten
            // 
            this.id_kabupaten.DataPropertyName = "IdKabupaten";
            this.id_kabupaten.HeaderText = "IdKabupaten";
            this.id_kabupaten.MinimumWidth = 6;
            this.id_kabupaten.Name = "id_kabupaten";
            this.id_kabupaten.ReadOnly = true;
            this.id_kabupaten.Width = 125;
            // 
            // IdKecamatan
            // 
            this.IdKecamatan.DataPropertyName = "IdKecamatan";
            this.IdKecamatan.HeaderText = "ID KECAMATAN";
            this.IdKecamatan.MinimumWidth = 6;
            this.IdKecamatan.Name = "IdKecamatan";
            this.IdKecamatan.ReadOnly = true;
            this.IdKecamatan.Width = 125;
            // 
            // FromKK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 789);
            this.Controls.Add(this.NoKK_txt);
            this.Controls.Add(this.groupBox1);
            this.Name = "FromKK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ". : : KARTU KELUARGA : : .";
            this.Load += new System.EventHandler(this.FromKK_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kartukeluarga_dgv)).EndInit();
            this.pencarian_gbox.ResumeLayout(false);
            this.pencarian_gbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nik_lbl;
        private System.Windows.Forms.TextBox NoKK_txt;
        private System.Windows.Forms.Button simpan_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button batal_btn;
        private System.Windows.Forms.Button hapus_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox pencarian_gbox;
        private System.Windows.Forms.TextBox pencarian_txt;
        private System.Windows.Forms.Label no_kk;
        private System.Windows.Forms.TextBox Alamat_txt;
        private System.Windows.Forms.DataGridView kartukeluarga_dgv;
        private System.Windows.Forms.ComboBox id_cmb;
        private System.Windows.Forms.ComboBox kelurahan_cmb;
        private System.Windows.Forms.Label kelurahan_lbl;
        private System.Windows.Forms.Label kabupaten_lbl;
        private System.Windows.Forms.ComboBox kabupaten_cmb;
        private System.Windows.Forms.ComboBox kecamatan_cmb;
        private System.Windows.Forms.Label kecamatan_lbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_kepala_keluarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_kabupaten;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdKecamatan;
    }
}