namespace DemirbasOtomasyon.View
{
    partial class FormUrunListele
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlUrunGrs = new System.Windows.Forms.Label();
            this.dgwUrunListesi = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUrunID = new System.Windows.Forms.TextBox();
            this.grbUrunAramaIslemleri = new System.Windows.Forms.GroupBox();
            this.BtnTumUrunler = new DevExpress.XtraEditors.SimpleButton();
            this.BtnUrunBul = new DevExpress.XtraEditors.SimpleButton();
            this.BtnRapor = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrunListesi)).BeginInit();
            this.grbUrunAramaIslemleri.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.pnlUrunGrs);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1147, 78);
            this.panel1.TabIndex = 19;
            // 
            // pnlUrunGrs
            // 
            this.pnlUrunGrs.AutoSize = true;
            this.pnlUrunGrs.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnlUrunGrs.Location = new System.Drawing.Point(432, 21);
            this.pnlUrunGrs.Name = "pnlUrunGrs";
            this.pnlUrunGrs.Size = new System.Drawing.Size(258, 37);
            this.pnlUrunGrs.TabIndex = 0;
            this.pnlUrunGrs.Text = "ÜRÜNLER LİSTESİ";
            // 
            // dgwUrunListesi
            // 
            this.dgwUrunListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwUrunListesi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwUrunListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUrunListesi.Location = new System.Drawing.Point(33, 213);
            this.dgwUrunListesi.Name = "dgwUrunListesi";
            this.dgwUrunListesi.RowTemplate.Height = 24;
            this.dgwUrunListesi.Size = new System.Drawing.Size(1081, 412);
            this.dgwUrunListesi.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(10, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ürün ID:";
            // 
            // txtUrunID
            // 
            this.txtUrunID.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunID.Location = new System.Drawing.Point(103, 47);
            this.txtUrunID.Name = "txtUrunID";
            this.txtUrunID.Size = new System.Drawing.Size(200, 28);
            this.txtUrunID.TabIndex = 2;
            // 
            // grbUrunAramaIslemleri
            // 
            this.grbUrunAramaIslemleri.Controls.Add(this.BtnRapor);
            this.grbUrunAramaIslemleri.Controls.Add(this.BtnTumUrunler);
            this.grbUrunAramaIslemleri.Controls.Add(this.BtnUrunBul);
            this.grbUrunAramaIslemleri.Controls.Add(this.txtUrunID);
            this.grbUrunAramaIslemleri.Controls.Add(this.label3);
            this.grbUrunAramaIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbUrunAramaIslemleri.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grbUrunAramaIslemleri.Location = new System.Drawing.Point(33, 97);
            this.grbUrunAramaIslemleri.Name = "grbUrunAramaIslemleri";
            this.grbUrunAramaIslemleri.Size = new System.Drawing.Size(1081, 110);
            this.grbUrunAramaIslemleri.TabIndex = 18;
            this.grbUrunAramaIslemleri.TabStop = false;
            // 
            // BtnTumUrunler
            // 
            this.BtnTumUrunler.Appearance.BackColor = System.Drawing.Color.White;
            this.BtnTumUrunler.Appearance.BackColor2 = System.Drawing.Color.DodgerBlue;
            this.BtnTumUrunler.Appearance.BorderColor = System.Drawing.Color.White;
            this.BtnTumUrunler.Appearance.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTumUrunler.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BtnTumUrunler.Appearance.Options.UseBackColor = true;
            this.BtnTumUrunler.Appearance.Options.UseBorderColor = true;
            this.BtnTumUrunler.Appearance.Options.UseFont = true;
            this.BtnTumUrunler.Appearance.Options.UseForeColor = true;
            this.BtnTumUrunler.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.BtnTumUrunler.Location = new System.Drawing.Point(880, 63);
            this.BtnTumUrunler.Name = "BtnTumUrunler";
            this.BtnTumUrunler.Size = new System.Drawing.Size(161, 41);
            this.BtnTumUrunler.TabIndex = 13;
            this.BtnTumUrunler.Text = "TÜM ÜRÜNLER";
            this.BtnTumUrunler.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Cursor;
            this.BtnTumUrunler.Click += new System.EventHandler(this.BtnTumUrunler_Click);
            // 
            // BtnUrunBul
            // 
            this.BtnUrunBul.Appearance.BackColor = System.Drawing.Color.White;
            this.BtnUrunBul.Appearance.BackColor2 = System.Drawing.Color.DodgerBlue;
            this.BtnUrunBul.Appearance.BorderColor = System.Drawing.Color.White;
            this.BtnUrunBul.Appearance.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUrunBul.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BtnUrunBul.Appearance.Options.UseBackColor = true;
            this.BtnUrunBul.Appearance.Options.UseBorderColor = true;
            this.BtnUrunBul.Appearance.Options.UseFont = true;
            this.BtnUrunBul.Appearance.Options.UseForeColor = true;
            this.BtnUrunBul.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.BtnUrunBul.Location = new System.Drawing.Point(376, 39);
            this.BtnUrunBul.Name = "BtnUrunBul";
            this.BtnUrunBul.Size = new System.Drawing.Size(161, 41);
            this.BtnUrunBul.TabIndex = 12;
            this.BtnUrunBul.Text = "ARA";
            this.BtnUrunBul.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Cursor;
            this.BtnUrunBul.Click += new System.EventHandler(this.BtnUrunBul_Click);
            // 
            // BtnRapor
            // 
            this.BtnRapor.Appearance.BackColor = System.Drawing.Color.White;
            this.BtnRapor.Appearance.BackColor2 = System.Drawing.Color.DodgerBlue;
            this.BtnRapor.Appearance.BorderColor = System.Drawing.Color.White;
            this.BtnRapor.Appearance.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnRapor.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BtnRapor.Appearance.Options.UseBackColor = true;
            this.BtnRapor.Appearance.Options.UseBorderColor = true;
            this.BtnRapor.Appearance.Options.UseFont = true;
            this.BtnRapor.Appearance.Options.UseForeColor = true;
            this.BtnRapor.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.BtnRapor.Location = new System.Drawing.Point(880, 16);
            this.BtnRapor.Name = "BtnRapor";
            this.BtnRapor.Size = new System.Drawing.Size(161, 41);
            this.BtnRapor.TabIndex = 26;
            this.BtnRapor.Text = "RAPORLA";
            this.BtnRapor.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Cursor;
            // 
            // FormUrunListele
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 637);
            this.Controls.Add(this.grbUrunAramaIslemleri);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgwUrunListesi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormUrunListele";
            this.Load += new System.EventHandler(this.FormUrunListele_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrunListesi)).EndInit();
            this.grbUrunAramaIslemleri.ResumeLayout(false);
            this.grbUrunAramaIslemleri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label pnlUrunGrs;
        private System.Windows.Forms.DataGridView dgwUrunListesi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUrunID;
        private System.Windows.Forms.GroupBox grbUrunAramaIslemleri;
        private DevExpress.XtraEditors.SimpleButton BtnUrunBul;
        private DevExpress.XtraEditors.SimpleButton BtnTumUrunler;
        private DevExpress.XtraEditors.SimpleButton BtnRapor;
    }
}