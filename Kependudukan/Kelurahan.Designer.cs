namespace Kependudukan
{
    partial class Kelurahan
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
            this.idKelurahan_lbl = new System.Windows.Forms.Label();
            this.namaKelurahan_lbl = new System.Windows.Forms.Label();
            this.kodepos_lbl = new System.Windows.Forms.Label();
            this.kelurahan_lbl = new System.Windows.Forms.Label();
            this.idKelurahan_tb = new System.Windows.Forms.TextBox();
            this.namaKelurahan_tb = new System.Windows.Forms.TextBox();
            this.kodePos_tb = new System.Windows.Forms.TextBox();
            this.hapus_btn = new System.Windows.Forms.Button();
            this.bersihkan_btn = new System.Windows.Forms.Button();
            this.simpan_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.pencarian_tb = new System.Windows.Forms.TextBox();
            this.pencarian_lbl = new System.Windows.Forms.Label();
            this.kelurahan_DGV = new System.Windows.Forms.DataGridView();
            this.IdKelurahan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaKelurahan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KodePos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kelurahan_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // idKelurahan_lbl
            // 
            this.idKelurahan_lbl.AutoSize = true;
            this.idKelurahan_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idKelurahan_lbl.Location = new System.Drawing.Point(128, 98);
            this.idKelurahan_lbl.Name = "idKelurahan_lbl";
            this.idKelurahan_lbl.Size = new System.Drawing.Size(123, 25);
            this.idKelurahan_lbl.TabIndex = 0;
            this.idKelurahan_lbl.Text = "Id Kelurahan";
            // 
            // namaKelurahan_lbl
            // 
            this.namaKelurahan_lbl.AutoSize = true;
            this.namaKelurahan_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namaKelurahan_lbl.Location = new System.Drawing.Point(128, 146);
            this.namaKelurahan_lbl.Name = "namaKelurahan_lbl";
            this.namaKelurahan_lbl.Size = new System.Drawing.Size(159, 25);
            this.namaKelurahan_lbl.TabIndex = 1;
            this.namaKelurahan_lbl.Text = "Nama Kelurahan";
            // 
            // kodepos_lbl
            // 
            this.kodepos_lbl.AutoSize = true;
            this.kodepos_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kodepos_lbl.Location = new System.Drawing.Point(128, 193);
            this.kodepos_lbl.Name = "kodepos_lbl";
            this.kodepos_lbl.Size = new System.Drawing.Size(98, 25);
            this.kodepos_lbl.TabIndex = 2;
            this.kodepos_lbl.Text = "Kode Pos";
            // 
            // kelurahan_lbl
            // 
            this.kelurahan_lbl.AutoSize = true;
            this.kelurahan_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kelurahan_lbl.Location = new System.Drawing.Point(312, 27);
            this.kelurahan_lbl.Name = "kelurahan_lbl";
            this.kelurahan_lbl.Size = new System.Drawing.Size(166, 29);
            this.kelurahan_lbl.TabIndex = 3;
            this.kelurahan_lbl.Text = "KELURAHAN";
            // 
            // idKelurahan_tb
            // 
            this.idKelurahan_tb.Enabled = false;
            this.idKelurahan_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idKelurahan_tb.Location = new System.Drawing.Point(317, 84);
            this.idKelurahan_tb.Multiline = true;
            this.idKelurahan_tb.Name = "idKelurahan_tb";
            this.idKelurahan_tb.ReadOnly = true;
            this.idKelurahan_tb.Size = new System.Drawing.Size(131, 39);
            this.idKelurahan_tb.TabIndex = 4;
            this.idKelurahan_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idKelurahan_tb_KeyPress);
            // 
            // namaKelurahan_tb
            // 
            this.namaKelurahan_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namaKelurahan_tb.Location = new System.Drawing.Point(317, 129);
            this.namaKelurahan_tb.Multiline = true;
            this.namaKelurahan_tb.Name = "namaKelurahan_tb";
            this.namaKelurahan_tb.Size = new System.Drawing.Size(340, 42);
            this.namaKelurahan_tb.TabIndex = 5;
            this.namaKelurahan_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.namaKelurahan_tb_KeyPress);
            // 
            // kodePos_tb
            // 
            this.kodePos_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kodePos_tb.Location = new System.Drawing.Point(317, 177);
            this.kodePos_tb.Multiline = true;
            this.kodePos_tb.Name = "kodePos_tb";
            this.kodePos_tb.Size = new System.Drawing.Size(340, 41);
            this.kodePos_tb.TabIndex = 6;
            this.kodePos_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kodePos_tb_KeyPress);
            // 
            // hapus_btn
            // 
            this.hapus_btn.BackColor = System.Drawing.Color.Brown;
            this.hapus_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.hapus_btn.Location = new System.Drawing.Point(385, 240);
            this.hapus_btn.Name = "hapus_btn";
            this.hapus_btn.Size = new System.Drawing.Size(84, 44);
            this.hapus_btn.TabIndex = 7;
            this.hapus_btn.Text = "Hapus";
            this.hapus_btn.UseVisualStyleBackColor = false;
            this.hapus_btn.Click += new System.EventHandler(this.hapus_btn_Click);
            // 
            // bersihkan_btn
            // 
            this.bersihkan_btn.Location = new System.Drawing.Point(475, 240);
            this.bersihkan_btn.Name = "bersihkan_btn";
            this.bersihkan_btn.Size = new System.Drawing.Size(89, 44);
            this.bersihkan_btn.TabIndex = 8;
            this.bersihkan_btn.Text = "Bersihkan";
            this.bersihkan_btn.UseVisualStyleBackColor = true;
            this.bersihkan_btn.Click += new System.EventHandler(this.bersihkan_btn_Click);
            // 
            // simpan_btn
            // 
            this.simpan_btn.BackColor = System.Drawing.Color.Green;
            this.simpan_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.simpan_btn.Location = new System.Drawing.Point(201, 240);
            this.simpan_btn.Name = "simpan_btn";
            this.simpan_btn.Size = new System.Drawing.Size(86, 44);
            this.simpan_btn.TabIndex = 9;
            this.simpan_btn.Text = "Simpan";
            this.simpan_btn.UseVisualStyleBackColor = false;
            this.simpan_btn.Click += new System.EventHandler(this.simpan_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.edit_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.edit_btn.Location = new System.Drawing.Point(293, 240);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(86, 44);
            this.edit_btn.TabIndex = 10;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = false;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.White;
            this.exit_btn.ForeColor = System.Drawing.Color.Black;
            this.exit_btn.Location = new System.Drawing.Point(570, 240);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(87, 44);
            this.exit_btn.TabIndex = 11;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // pencarian_tb
            // 
            this.pencarian_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pencarian_tb.Location = new System.Drawing.Point(319, 319);
            this.pencarian_tb.Multiline = true;
            this.pencarian_tb.Name = "pencarian_tb";
            this.pencarian_tb.Size = new System.Drawing.Size(340, 36);
            this.pencarian_tb.TabIndex = 12;
            this.pencarian_tb.TextChanged += new System.EventHandler(this.pencarian_tb_TextChanged);
            // 
            // pencarian_lbl
            // 
            this.pencarian_lbl.AutoSize = true;
            this.pencarian_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pencarian_lbl.Location = new System.Drawing.Point(131, 335);
            this.pencarian_lbl.Name = "pencarian_lbl";
            this.pencarian_lbl.Size = new System.Drawing.Size(84, 20);
            this.pencarian_lbl.TabIndex = 13;
            this.pencarian_lbl.Text = "Pencarian";
            // 
            // kelurahan_DGV
            // 
            this.kelurahan_DGV.AllowUserToAddRows = false;
            this.kelurahan_DGV.AllowUserToDeleteRows = false;
            this.kelurahan_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kelurahan_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdKelurahan,
            this.NamaKelurahan,
            this.KodePos});
            this.kelurahan_DGV.Location = new System.Drawing.Point(135, 379);
            this.kelurahan_DGV.Name = "kelurahan_DGV";
            this.kelurahan_DGV.ReadOnly = true;
            this.kelurahan_DGV.RowHeadersWidth = 51;
            this.kelurahan_DGV.RowTemplate.Height = 24;
            this.kelurahan_DGV.Size = new System.Drawing.Size(557, 197);
            this.kelurahan_DGV.TabIndex = 15;
            this.kelurahan_DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kelurahan_DGV_CellClick);
            // 
            // IdKelurahan
            // 
            this.IdKelurahan.DataPropertyName = "IdKelurahan";
            this.IdKelurahan.HeaderText = "Id Kelurahan";
            this.IdKelurahan.MinimumWidth = 6;
            this.IdKelurahan.Name = "IdKelurahan";
            this.IdKelurahan.ReadOnly = true;
            this.IdKelurahan.Width = 125;
            // 
            // NamaKelurahan
            // 
            this.NamaKelurahan.DataPropertyName = "NamaKelurahan";
            this.NamaKelurahan.HeaderText = "Nama Kelurahan";
            this.NamaKelurahan.MinimumWidth = 6;
            this.NamaKelurahan.Name = "NamaKelurahan";
            this.NamaKelurahan.ReadOnly = true;
            this.NamaKelurahan.Width = 200;
            // 
            // KodePos
            // 
            this.KodePos.DataPropertyName = "KodePos";
            this.KodePos.HeaderText = "Kode Pos";
            this.KodePos.MinimumWidth = 6;
            this.KodePos.Name = "KodePos";
            this.KodePos.ReadOnly = true;
            this.KodePos.Width = 200;
            // 
            // Kelurahan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 614);
            this.ControlBox = false;
            this.Controls.Add(this.kelurahan_DGV);
            this.Controls.Add(this.pencarian_lbl);
            this.Controls.Add(this.pencarian_tb);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.simpan_btn);
            this.Controls.Add(this.bersihkan_btn);
            this.Controls.Add(this.hapus_btn);
            this.Controls.Add(this.kodePos_tb);
            this.Controls.Add(this.namaKelurahan_tb);
            this.Controls.Add(this.idKelurahan_tb);
            this.Controls.Add(this.kelurahan_lbl);
            this.Controls.Add(this.kodepos_lbl);
            this.Controls.Add(this.namaKelurahan_lbl);
            this.Controls.Add(this.idKelurahan_lbl);
            this.Name = "Kelurahan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kelurahan";
            this.Load += new System.EventHandler(this.Kelurahan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kelurahan_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idKelurahan_lbl;
        private System.Windows.Forms.Label namaKelurahan_lbl;
        private System.Windows.Forms.Label kodepos_lbl;
        private System.Windows.Forms.Label kelurahan_lbl;
        private System.Windows.Forms.TextBox idKelurahan_tb;
        private System.Windows.Forms.TextBox namaKelurahan_tb;
        private System.Windows.Forms.TextBox kodePos_tb;
        private System.Windows.Forms.Button hapus_btn;
        private System.Windows.Forms.Button bersihkan_btn;
        private System.Windows.Forms.Button simpan_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.TextBox pencarian_tb;
        private System.Windows.Forms.Label pencarian_lbl;
        private System.Windows.Forms.DataGridView kelurahan_DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdKelurahan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaKelurahan;
        private System.Windows.Forms.DataGridViewTextBoxColumn KodePos;
    }
}