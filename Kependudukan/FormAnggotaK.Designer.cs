namespace Kependudukan
{
    partial class FormAnggotaK
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
            this.juduldata_lbl = new System.Windows.Forms.Label();
            this.pencarian_gbx = new System.Windows.Forms.GroupBox();
            this.cari_txt = new System.Windows.Forms.TextBox();
            this.cari_id_lbl = new System.Windows.Forms.Label();
            this.close_btn = new System.Windows.Forms.Button();
            this.batal_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.simpan_btn = new System.Windows.Forms.Button();
            this.status_txt = new System.Windows.Forms.TextBox();
            this.status_lbl = new System.Windows.Forms.Label();
            this.id_penduduk_lbl = new System.Windows.Forms.Label();
            this.no_kk_lbl = new System.Windows.Forms.Label();
            this.id_anggota_txt = new System.Windows.Forms.TextBox();
            this.id_anggota_lbl = new System.Windows.Forms.Label();
            this.form_gbx = new System.Windows.Forms.GroupBox();
            this.id_penduduk_cmb = new System.Windows.Forms.ComboBox();
            this.no_kk_cmb = new System.Windows.Forms.ComboBox();
            this.anggota_dgv = new System.Windows.Forms.DataGridView();
            this.IdAnggota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoKK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPenduduk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusDalamKeluarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pencarian_gbx.SuspendLayout();
            this.form_gbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anggota_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // juduldata_lbl
            // 
            this.juduldata_lbl.AutoSize = true;
            this.juduldata_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.juduldata_lbl.Location = new System.Drawing.Point(182, 29);
            this.juduldata_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.juduldata_lbl.Name = "juduldata_lbl";
            this.juduldata_lbl.Size = new System.Drawing.Size(279, 22);
            this.juduldata_lbl.TabIndex = 5;
            this.juduldata_lbl.Text = "DATA ANGGOTA KELUARGA";
            // 
            // pencarian_gbx
            // 
            this.pencarian_gbx.Controls.Add(this.cari_txt);
            this.pencarian_gbx.Controls.Add(this.cari_id_lbl);
            this.pencarian_gbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pencarian_gbx.Location = new System.Drawing.Point(12, 325);
            this.pencarian_gbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pencarian_gbx.Name = "pencarian_gbx";
            this.pencarian_gbx.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pencarian_gbx.Size = new System.Drawing.Size(612, 77);
            this.pencarian_gbx.TabIndex = 17;
            this.pencarian_gbx.TabStop = false;
            this.pencarian_gbx.Text = "Pencarian";
            // 
            // cari_txt
            // 
            this.cari_txt.Location = new System.Drawing.Point(4, 50);
            this.cari_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cari_txt.Name = "cari_txt";
            this.cari_txt.Size = new System.Drawing.Size(604, 23);
            this.cari_txt.TabIndex = 1;
            this.cari_txt.TextChanged += new System.EventHandler(this.cari_txt_TextChanged);
            // 
            // cari_id_lbl
            // 
            this.cari_id_lbl.AutoSize = true;
            this.cari_id_lbl.Location = new System.Drawing.Point(4, 27);
            this.cari_id_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cari_id_lbl.Name = "cari_id_lbl";
            this.cari_id_lbl.Size = new System.Drawing.Size(78, 17);
            this.cari_id_lbl.TabIndex = 0;
            this.cari_id_lbl.Text = "ID Anggota";
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.Silver;
            this.close_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.Location = new System.Drawing.Point(408, 284);
            this.close_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(72, 36);
            this.close_btn.TabIndex = 31;
            this.close_btn.Text = "Exit";
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // batal_btn
            // 
            this.batal_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.batal_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batal_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.batal_btn.Location = new System.Drawing.Point(332, 284);
            this.batal_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.batal_btn.Name = "batal_btn";
            this.batal_btn.Size = new System.Drawing.Size(72, 36);
            this.batal_btn.TabIndex = 30;
            this.batal_btn.Text = "Batal";
            this.batal_btn.UseVisualStyleBackColor = false;
            this.batal_btn.Click += new System.EventHandler(this.batal_btn_Click_1);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.Maroon;
            this.delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.delete_btn.Location = new System.Drawing.Point(255, 284);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(72, 36);
            this.delete_btn.TabIndex = 29;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.update_btn.Location = new System.Drawing.Point(178, 284);
            this.update_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(72, 36);
            this.update_btn.TabIndex = 28;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click_1);
            // 
            // simpan_btn
            // 
            this.simpan_btn.BackColor = System.Drawing.Color.Green;
            this.simpan_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpan_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.simpan_btn.Location = new System.Drawing.Point(102, 284);
            this.simpan_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.simpan_btn.Name = "simpan_btn";
            this.simpan_btn.Size = new System.Drawing.Size(72, 36);
            this.simpan_btn.TabIndex = 27;
            this.simpan_btn.Text = "Simpan";
            this.simpan_btn.UseVisualStyleBackColor = false;
            this.simpan_btn.Click += new System.EventHandler(this.simpan_btn_Click);
            // 
            // status_txt
            // 
            this.status_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_txt.Location = new System.Drawing.Point(236, 245);
            this.status_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.status_txt.Name = "status_txt";
            this.status_txt.Size = new System.Drawing.Size(245, 23);
            this.status_txt.TabIndex = 26;
            this.status_txt.TextChanged += new System.EventHandler(this.status_txt_TextChanged);
            // 
            // status_lbl
            // 
            this.status_lbl.AutoSize = true;
            this.status_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_lbl.Location = new System.Drawing.Point(140, 249);
            this.status_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.status_lbl.Name = "status_lbl";
            this.status_lbl.Size = new System.Drawing.Size(72, 18);
            this.status_lbl.TabIndex = 24;
            this.status_lbl.Text = "STATUS";
            // 
            // id_penduduk_lbl
            // 
            this.id_penduduk_lbl.AutoSize = true;
            this.id_penduduk_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_penduduk_lbl.Location = new System.Drawing.Point(98, 196);
            this.id_penduduk_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.id_penduduk_lbl.Name = "id_penduduk_lbl";
            this.id_penduduk_lbl.Size = new System.Drawing.Size(122, 18);
            this.id_penduduk_lbl.TabIndex = 23;
            this.id_penduduk_lbl.Text = "ID PENDUDUK";
            this.id_penduduk_lbl.Click += new System.EventHandler(this.id_penduduk_lbl_Click);
            // 
            // no_kk_lbl
            // 
            this.no_kk_lbl.AutoSize = true;
            this.no_kk_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_kk_lbl.Location = new System.Drawing.Point(153, 144);
            this.no_kk_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.no_kk_lbl.Name = "no_kk_lbl";
            this.no_kk_lbl.Size = new System.Drawing.Size(60, 18);
            this.no_kk_lbl.TabIndex = 21;
            this.no_kk_lbl.Text = "NO KK";
            this.no_kk_lbl.Click += new System.EventHandler(this.no_kk_lbl_Click_1);
            // 
            // id_anggota_txt
            // 
            this.id_anggota_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_anggota_txt.Location = new System.Drawing.Point(236, 91);
            this.id_anggota_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.id_anggota_txt.Name = "id_anggota_txt";
            this.id_anggota_txt.Size = new System.Drawing.Size(245, 23);
            this.id_anggota_txt.TabIndex = 20;
            this.id_anggota_txt.TextChanged += new System.EventHandler(this.id_anggota_txt_TextChanged);
            // 
            // id_anggota_lbl
            // 
            this.id_anggota_lbl.AutoSize = true;
            this.id_anggota_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_anggota_lbl.Location = new System.Drawing.Point(106, 95);
            this.id_anggota_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.id_anggota_lbl.Name = "id_anggota_lbl";
            this.id_anggota_lbl.Size = new System.Drawing.Size(110, 18);
            this.id_anggota_lbl.TabIndex = 19;
            this.id_anggota_lbl.Text = "ID ANGGOTA";
            // 
            // form_gbx
            // 
            this.form_gbx.Controls.Add(this.id_penduduk_cmb);
            this.form_gbx.Controls.Add(this.no_kk_cmb);
            this.form_gbx.Controls.Add(this.status_lbl);
            this.form_gbx.Controls.Add(this.status_txt);
            this.form_gbx.Controls.Add(this.id_penduduk_lbl);
            this.form_gbx.Controls.Add(this.anggota_dgv);
            this.form_gbx.Controls.Add(this.no_kk_lbl);
            this.form_gbx.Controls.Add(this.id_anggota_lbl);
            this.form_gbx.Controls.Add(this.id_anggota_txt);
            this.form_gbx.Controls.Add(this.close_btn);
            this.form_gbx.Controls.Add(this.pencarian_gbx);
            this.form_gbx.Controls.Add(this.batal_btn);
            this.form_gbx.Controls.Add(this.juduldata_lbl);
            this.form_gbx.Controls.Add(this.delete_btn);
            this.form_gbx.Controls.Add(this.simpan_btn);
            this.form_gbx.Controls.Add(this.update_btn);
            this.form_gbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form_gbx.Location = new System.Drawing.Point(9, 10);
            this.form_gbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.form_gbx.Name = "form_gbx";
            this.form_gbx.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.form_gbx.Size = new System.Drawing.Size(628, 530);
            this.form_gbx.TabIndex = 32;
            this.form_gbx.TabStop = false;
            this.form_gbx.Text = "Form Anggota Keluarga";
            // 
            // id_penduduk_cmb
            // 
            this.id_penduduk_cmb.FormattingEnabled = true;
            this.id_penduduk_cmb.Location = new System.Drawing.Point(236, 193);
            this.id_penduduk_cmb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.id_penduduk_cmb.Name = "id_penduduk_cmb";
            this.id_penduduk_cmb.Size = new System.Drawing.Size(245, 23);
            this.id_penduduk_cmb.TabIndex = 34;
            this.id_penduduk_cmb.SelectedIndexChanged += new System.EventHandler(this.nik_cmb_SelectedIndexChanged);
            // 
            // no_kk_cmb
            // 
            this.no_kk_cmb.FormattingEnabled = true;
            this.no_kk_cmb.Location = new System.Drawing.Point(236, 141);
            this.no_kk_cmb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.no_kk_cmb.Name = "no_kk_cmb";
            this.no_kk_cmb.Size = new System.Drawing.Size(245, 23);
            this.no_kk_cmb.TabIndex = 33;
            // 
            // anggota_dgv
            // 
            this.anggota_dgv.AllowUserToAddRows = false;
            this.anggota_dgv.AllowUserToDeleteRows = false;
            this.anggota_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.anggota_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAnggota,
            this.NoKK,
            this.IdPenduduk,
            this.StatusDalamKeluarga});
            this.anggota_dgv.Location = new System.Drawing.Point(12, 407);
            this.anggota_dgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.anggota_dgv.Name = "anggota_dgv";
            this.anggota_dgv.ReadOnly = true;
            this.anggota_dgv.RowHeadersWidth = 51;
            this.anggota_dgv.RowTemplate.Height = 24;
            this.anggota_dgv.Size = new System.Drawing.Size(612, 106);
            this.anggota_dgv.TabIndex = 32;
            this.anggota_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.anggota_dgv_CellClick);
            this.anggota_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.anggota_dgv_CellContentClick);
            // 
            // IdAnggota
            // 
            this.IdAnggota.DataPropertyName = "IdAnggota";
            this.IdAnggota.HeaderText = "ID ANGGOTA";
            this.IdAnggota.MinimumWidth = 8;
            this.IdAnggota.Name = "IdAnggota";
            this.IdAnggota.ReadOnly = true;
            this.IdAnggota.Width = 150;
            // 
            // NoKK
            // 
            this.NoKK.DataPropertyName = "NoKK";
            this.NoKK.HeaderText = "NO KK";
            this.NoKK.MinimumWidth = 8;
            this.NoKK.Name = "NoKK";
            this.NoKK.ReadOnly = true;
            this.NoKK.Width = 200;
            // 
            // IdPenduduk
            // 
            this.IdPenduduk.DataPropertyName = "IdPenduduk";
            this.IdPenduduk.HeaderText = "IdPenduduk";
            this.IdPenduduk.MinimumWidth = 8;
            this.IdPenduduk.Name = "IdPenduduk";
            this.IdPenduduk.ReadOnly = true;
            this.IdPenduduk.Width = 150;
            // 
            // StatusDalamKeluarga
            // 
            this.StatusDalamKeluarga.DataPropertyName = "StatusDalamKeluarga";
            this.StatusDalamKeluarga.HeaderText = "STATUS";
            this.StatusDalamKeluarga.MinimumWidth = 6;
            this.StatusDalamKeluarga.Name = "StatusDalamKeluarga";
            this.StatusDalamKeluarga.ReadOnly = true;
            this.StatusDalamKeluarga.Width = 300;
            // 
            // FormAnggotaK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 540);
            this.Controls.Add(this.form_gbx);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormAnggotaK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ANGGOTA KELUARGA ";
            this.Load += new System.EventHandler(this.FormAnggotaK_Load);
            this.pencarian_gbx.ResumeLayout(false);
            this.pencarian_gbx.PerformLayout();
            this.form_gbx.ResumeLayout(false);
            this.form_gbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anggota_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label juduldata_lbl;
        private System.Windows.Forms.GroupBox pencarian_gbx;
        private System.Windows.Forms.TextBox cari_txt;
        private System.Windows.Forms.Label cari_id_lbl;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Button batal_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button simpan_btn;
        private System.Windows.Forms.TextBox status_txt;
        private System.Windows.Forms.Label status_lbl;
        private System.Windows.Forms.Label id_penduduk_lbl;
        private System.Windows.Forms.Label no_kk_lbl;
        private System.Windows.Forms.TextBox id_anggota_txt;
        private System.Windows.Forms.Label id_anggota_lbl;
        private System.Windows.Forms.GroupBox form_gbx;
        private System.Windows.Forms.DataGridView anggota_dgv;
        private System.Windows.Forms.ComboBox no_kk_cmb;
        private System.Windows.Forms.ComboBox id_penduduk_cmb;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAnggota;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoKK;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPenduduk;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusDalamKeluarga;
    }
}