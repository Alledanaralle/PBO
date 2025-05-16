namespace Kependudukan
{
    partial class Kecamatan
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
            this.pencarian_tb = new System.Windows.Forms.TextBox();
            this.Kecamatan_DGV = new System.Windows.Forms.DataGridView();
            this.IdKecamatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaKecamatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exit_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.simpan_btn = new System.Windows.Forms.Button();
            this.bersihkan_btn = new System.Windows.Forms.Button();
            this.hapus_btn = new System.Windows.Forms.Button();
            this.NamaKecamatan_tb = new System.Windows.Forms.TextBox();
            this.IdKecamatan_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pencarian_lbl = new System.Windows.Forms.Label();
            this.kelurahan_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Kecamatan_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // pencarian_tb
            // 
            this.pencarian_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pencarian_tb.Location = new System.Drawing.Point(322, 263);
            this.pencarian_tb.Multiline = true;
            this.pencarian_tb.Name = "pencarian_tb";
            this.pencarian_tb.Size = new System.Drawing.Size(323, 36);
            this.pencarian_tb.TabIndex = 29;
            this.pencarian_tb.TextChanged += new System.EventHandler(this.pencarian_tb_TextChanged);
            // 
            // Kecamatan_DGV
            // 
            this.Kecamatan_DGV.AllowUserToAddRows = false;
            this.Kecamatan_DGV.AllowUserToDeleteRows = false;
            this.Kecamatan_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Kecamatan_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdKecamatan,
            this.NamaKecamatan});
            this.Kecamatan_DGV.Location = new System.Drawing.Point(160, 321);
            this.Kecamatan_DGV.Name = "Kecamatan_DGV";
            this.Kecamatan_DGV.ReadOnly = true;
            this.Kecamatan_DGV.RowHeadersWidth = 51;
            this.Kecamatan_DGV.RowTemplate.Height = 24;
            this.Kecamatan_DGV.Size = new System.Drawing.Size(485, 197);
            this.Kecamatan_DGV.TabIndex = 28;
            this.Kecamatan_DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Kecamatan_DGV_CellClick);
            // 
            // IdKecamatan
            // 
            this.IdKecamatan.DataPropertyName = "IdKecamatan";
            this.IdKecamatan.HeaderText = "Id Kecamatan";
            this.IdKecamatan.MinimumWidth = 6;
            this.IdKecamatan.Name = "IdKecamatan";
            this.IdKecamatan.ReadOnly = true;
            this.IdKecamatan.Width = 125;
            // 
            // NamaKecamatan
            // 
            this.NamaKecamatan.DataPropertyName = "NamaKecamatan";
            this.NamaKecamatan.HeaderText = "Nama Kecamatan";
            this.NamaKecamatan.MinimumWidth = 6;
            this.NamaKecamatan.Name = "NamaKecamatan";
            this.NamaKecamatan.ReadOnly = true;
            this.NamaKecamatan.Width = 300;
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.White;
            this.exit_btn.ForeColor = System.Drawing.Color.Black;
            this.exit_btn.Location = new System.Drawing.Point(545, 201);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(87, 44);
            this.exit_btn.TabIndex = 27;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.edit_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.edit_btn.Location = new System.Drawing.Point(268, 201);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(86, 44);
            this.edit_btn.TabIndex = 26;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = false;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // simpan_btn
            // 
            this.simpan_btn.BackColor = System.Drawing.Color.Green;
            this.simpan_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.simpan_btn.Location = new System.Drawing.Point(176, 201);
            this.simpan_btn.Name = "simpan_btn";
            this.simpan_btn.Size = new System.Drawing.Size(86, 44);
            this.simpan_btn.TabIndex = 25;
            this.simpan_btn.Text = "Simpan";
            this.simpan_btn.UseVisualStyleBackColor = false;
            this.simpan_btn.Click += new System.EventHandler(this.simpan_btn_Click);
            // 
            // bersihkan_btn
            // 
            this.bersihkan_btn.Location = new System.Drawing.Point(450, 201);
            this.bersihkan_btn.Name = "bersihkan_btn";
            this.bersihkan_btn.Size = new System.Drawing.Size(89, 44);
            this.bersihkan_btn.TabIndex = 24;
            this.bersihkan_btn.Text = "Bersihkan";
            this.bersihkan_btn.UseVisualStyleBackColor = true;
            this.bersihkan_btn.Click += new System.EventHandler(this.bersihkan_btn_Click);
            // 
            // hapus_btn
            // 
            this.hapus_btn.BackColor = System.Drawing.Color.Brown;
            this.hapus_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.hapus_btn.Location = new System.Drawing.Point(360, 201);
            this.hapus_btn.Name = "hapus_btn";
            this.hapus_btn.Size = new System.Drawing.Size(84, 44);
            this.hapus_btn.TabIndex = 23;
            this.hapus_btn.Text = "Hapus";
            this.hapus_btn.UseVisualStyleBackColor = false;
            this.hapus_btn.Click += new System.EventHandler(this.hapus_btn_Click);
            // 
            // NamaKecamatan_tb
            // 
            this.NamaKecamatan_tb.Location = new System.Drawing.Point(322, 142);
            this.NamaKecamatan_tb.Multiline = true;
            this.NamaKecamatan_tb.Name = "NamaKecamatan_tb";
            this.NamaKecamatan_tb.Size = new System.Drawing.Size(323, 39);
            this.NamaKecamatan_tb.TabIndex = 22;
            // 
            // IdKecamatan_tb
            // 
            this.IdKecamatan_tb.Enabled = false;
            this.IdKecamatan_tb.Location = new System.Drawing.Point(322, 96);
            this.IdKecamatan_tb.Multiline = true;
            this.IdKecamatan_tb.Name = "IdKecamatan_tb";
            this.IdKecamatan_tb.ReadOnly = true;
            this.IdKecamatan_tb.Size = new System.Drawing.Size(111, 40);
            this.IdKecamatan_tb.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nama Kecamatan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Id Kecamatan";
            // 
            // pencarian_lbl
            // 
            this.pencarian_lbl.AutoSize = true;
            this.pencarian_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pencarian_lbl.Location = new System.Drawing.Point(172, 279);
            this.pencarian_lbl.Name = "pencarian_lbl";
            this.pencarian_lbl.Size = new System.Drawing.Size(84, 20);
            this.pencarian_lbl.TabIndex = 30;
            this.pencarian_lbl.Text = "Pencarian";
            // 
            // kelurahan_lbl
            // 
            this.kelurahan_lbl.AutoSize = true;
            this.kelurahan_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kelurahan_lbl.Location = new System.Drawing.Point(307, 28);
            this.kelurahan_lbl.Name = "kelurahan_lbl";
            this.kelurahan_lbl.Size = new System.Drawing.Size(170, 29);
            this.kelurahan_lbl.TabIndex = 31;
            this.kelurahan_lbl.Text = "KECAMATAN";
            // 
            // Kecamatan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 576);
            this.ControlBox = false;
            this.Controls.Add(this.kelurahan_lbl);
            this.Controls.Add(this.pencarian_lbl);
            this.Controls.Add(this.pencarian_tb);
            this.Controls.Add(this.Kecamatan_DGV);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.simpan_btn);
            this.Controls.Add(this.bersihkan_btn);
            this.Controls.Add(this.hapus_btn);
            this.Controls.Add(this.NamaKecamatan_tb);
            this.Controls.Add(this.IdKecamatan_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Kecamatan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kecamatan";
            this.Load += new System.EventHandler(this.Kecamatan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Kecamatan_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pencarian_tb;
        private System.Windows.Forms.DataGridView Kecamatan_DGV;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button simpan_btn;
        private System.Windows.Forms.Button bersihkan_btn;
        private System.Windows.Forms.Button hapus_btn;
        private System.Windows.Forms.TextBox NamaKecamatan_tb;
        private System.Windows.Forms.TextBox IdKecamatan_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pencarian_lbl;
        private System.Windows.Forms.Label kelurahan_lbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdKecamatan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaKecamatan;
    }
}