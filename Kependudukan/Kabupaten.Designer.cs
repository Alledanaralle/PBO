namespace Kependudukan
{
    partial class Kabupaten
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
            this.IdKabupaten_tb = new System.Windows.Forms.TextBox();
            this.NamaKabupaten_tb = new System.Windows.Forms.TextBox();
            this.exit_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.simpan_btn = new System.Windows.Forms.Button();
            this.bersihkan_btn = new System.Windows.Forms.Button();
            this.hapus_btn = new System.Windows.Forms.Button();
            this.Kabupaten_DGV = new System.Windows.Forms.DataGridView();
            this.IdKabupaten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaKabupaten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pencarian_tb = new System.Windows.Forms.TextBox();
            this.pencarian_lbl = new System.Windows.Forms.Label();
            this.kelurahan_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Kabupaten_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Kabupaten";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Kabupaten";
            // 
            // IdKabupaten_tb
            // 
            this.IdKabupaten_tb.Enabled = false;
            this.IdKabupaten_tb.Location = new System.Drawing.Point(325, 85);
            this.IdKabupaten_tb.Multiline = true;
            this.IdKabupaten_tb.Name = "IdKabupaten_tb";
            this.IdKabupaten_tb.ReadOnly = true;
            this.IdKabupaten_tb.Size = new System.Drawing.Size(106, 40);
            this.IdKabupaten_tb.TabIndex = 2;
            this.IdKabupaten_tb.TextChanged += new System.EventHandler(this.IdKabupaten_tb_TextChanged);
            // 
            // NamaKabupaten_tb
            // 
            this.NamaKabupaten_tb.Location = new System.Drawing.Point(325, 131);
            this.NamaKabupaten_tb.Multiline = true;
            this.NamaKabupaten_tb.Name = "NamaKabupaten_tb";
            this.NamaKabupaten_tb.Size = new System.Drawing.Size(294, 39);
            this.NamaKabupaten_tb.TabIndex = 3;
            this.NamaKabupaten_tb.TextChanged += new System.EventHandler(this.NamaKabupaten_tb_TextChanged);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.White;
            this.exit_btn.ForeColor = System.Drawing.Color.Black;
            this.exit_btn.Location = new System.Drawing.Point(532, 191);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(87, 44);
            this.exit_btn.TabIndex = 16;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.edit_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.edit_btn.Location = new System.Drawing.Point(255, 191);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(86, 44);
            this.edit_btn.TabIndex = 15;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = false;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // simpan_btn
            // 
            this.simpan_btn.BackColor = System.Drawing.Color.Green;
            this.simpan_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.simpan_btn.Location = new System.Drawing.Point(163, 191);
            this.simpan_btn.Name = "simpan_btn";
            this.simpan_btn.Size = new System.Drawing.Size(86, 44);
            this.simpan_btn.TabIndex = 14;
            this.simpan_btn.Text = "Simpan";
            this.simpan_btn.UseVisualStyleBackColor = false;
            this.simpan_btn.Click += new System.EventHandler(this.simpan_btn_Click);
            // 
            // bersihkan_btn
            // 
            this.bersihkan_btn.Location = new System.Drawing.Point(437, 191);
            this.bersihkan_btn.Name = "bersihkan_btn";
            this.bersihkan_btn.Size = new System.Drawing.Size(89, 44);
            this.bersihkan_btn.TabIndex = 13;
            this.bersihkan_btn.Text = "Bersihkan";
            this.bersihkan_btn.UseVisualStyleBackColor = true;
            this.bersihkan_btn.Click += new System.EventHandler(this.bersihkan_btn_Click);
            // 
            // hapus_btn
            // 
            this.hapus_btn.BackColor = System.Drawing.Color.Brown;
            this.hapus_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.hapus_btn.Location = new System.Drawing.Point(347, 191);
            this.hapus_btn.Name = "hapus_btn";
            this.hapus_btn.Size = new System.Drawing.Size(84, 44);
            this.hapus_btn.TabIndex = 12;
            this.hapus_btn.Text = "Hapus";
            this.hapus_btn.UseVisualStyleBackColor = false;
            this.hapus_btn.Click += new System.EventHandler(this.hapus_btn_Click);
            // 
            // Kabupaten_DGV
            // 
            this.Kabupaten_DGV.AllowUserToAddRows = false;
            this.Kabupaten_DGV.AllowUserToDeleteRows = false;
            this.Kabupaten_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Kabupaten_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdKabupaten,
            this.NamaKabupaten});
            this.Kabupaten_DGV.Location = new System.Drawing.Point(149, 308);
            this.Kabupaten_DGV.Name = "Kabupaten_DGV";
            this.Kabupaten_DGV.ReadOnly = true;
            this.Kabupaten_DGV.RowHeadersWidth = 51;
            this.Kabupaten_DGV.RowTemplate.Height = 24;
            this.Kabupaten_DGV.Size = new System.Drawing.Size(485, 197);
            this.Kabupaten_DGV.TabIndex = 17;
            this.Kabupaten_DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Kabupaten_DGV_CellClick);
            // 
            // IdKabupaten
            // 
            this.IdKabupaten.DataPropertyName = "IdKabupaten";
            this.IdKabupaten.HeaderText = "Id Kabupaten";
            this.IdKabupaten.MinimumWidth = 6;
            this.IdKabupaten.Name = "IdKabupaten";
            this.IdKabupaten.ReadOnly = true;
            this.IdKabupaten.Width = 125;
            // 
            // NamaKabupaten
            // 
            this.NamaKabupaten.DataPropertyName = "NamaKabupaten";
            this.NamaKabupaten.HeaderText = "Nama Kabupaten";
            this.NamaKabupaten.MinimumWidth = 6;
            this.NamaKabupaten.Name = "NamaKabupaten";
            this.NamaKabupaten.ReadOnly = true;
            this.NamaKabupaten.Width = 300;
            // 
            // pencarian_tb
            // 
            this.pencarian_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pencarian_tb.Location = new System.Drawing.Point(325, 255);
            this.pencarian_tb.Multiline = true;
            this.pencarian_tb.Name = "pencarian_tb";
            this.pencarian_tb.Size = new System.Drawing.Size(294, 36);
            this.pencarian_tb.TabIndex = 18;
            this.pencarian_tb.TextChanged += new System.EventHandler(this.pencarian_tb_TextChanged);
            // 
            // pencarian_lbl
            // 
            this.pencarian_lbl.AutoSize = true;
            this.pencarian_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pencarian_lbl.Location = new System.Drawing.Point(167, 262);
            this.pencarian_lbl.Name = "pencarian_lbl";
            this.pencarian_lbl.Size = new System.Drawing.Size(84, 20);
            this.pencarian_lbl.TabIndex = 19;
            this.pencarian_lbl.Text = "Pencarian";
            // 
            // kelurahan_lbl
            // 
            this.kelurahan_lbl.AutoSize = true;
            this.kelurahan_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kelurahan_lbl.Location = new System.Drawing.Point(306, 34);
            this.kelurahan_lbl.Name = "kelurahan_lbl";
            this.kelurahan_lbl.Size = new System.Drawing.Size(167, 29);
            this.kelurahan_lbl.TabIndex = 32;
            this.kelurahan_lbl.Text = "KABUPATEN";
            // 
            // Kabupaten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 610);
            this.ControlBox = false;
            this.Controls.Add(this.kelurahan_lbl);
            this.Controls.Add(this.pencarian_lbl);
            this.Controls.Add(this.pencarian_tb);
            this.Controls.Add(this.Kabupaten_DGV);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.simpan_btn);
            this.Controls.Add(this.bersihkan_btn);
            this.Controls.Add(this.hapus_btn);
            this.Controls.Add(this.NamaKabupaten_tb);
            this.Controls.Add(this.IdKabupaten_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Kabupaten";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kabupaten";
            this.Load += new System.EventHandler(this.Kabupaten_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Kabupaten_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IdKabupaten_tb;
        private System.Windows.Forms.TextBox NamaKabupaten_tb;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button simpan_btn;
        private System.Windows.Forms.Button bersihkan_btn;
        private System.Windows.Forms.Button hapus_btn;
        private System.Windows.Forms.DataGridView Kabupaten_DGV;
        private System.Windows.Forms.TextBox pencarian_tb;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdKabupaten;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaKabupaten;
        private System.Windows.Forms.Label pencarian_lbl;
        private System.Windows.Forms.Label kelurahan_lbl;
    }
}