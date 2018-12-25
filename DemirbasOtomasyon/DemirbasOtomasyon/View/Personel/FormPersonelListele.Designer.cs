namespace DemirbasOtomasyon.View
{
    partial class FormPersonelListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPersonelListele));
            this.dgwPersonelListele = new System.Windows.Forms.DataGridView();
            this.pnlUrunGrs = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grbUrunAramaIslemleri = new System.Windows.Forms.GroupBox();
            this.BtnRapor = new DevExpress.XtraEditors.SimpleButton();
            this.cmbDepartmanTip = new System.Windows.Forms.ComboBox();
            this.BtnTumPersonel = new DevExpress.XtraEditors.SimpleButton();
            this.BtnPersonelBul = new DevExpress.XtraEditors.SimpleButton();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ppdDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.pdYazici = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPersonelListele)).BeginInit();
            this.panel1.SuspendLayout();
            this.grbUrunAramaIslemleri.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwPersonelListele
            // 
            this.dgwPersonelListele.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwPersonelListele.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwPersonelListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPersonelListele.Location = new System.Drawing.Point(32, 221);
            this.dgwPersonelListele.Name = "dgwPersonelListele";
            this.dgwPersonelListele.ReadOnly = true;
            this.dgwPersonelListele.RowTemplate.Height = 24;
            this.dgwPersonelListele.Size = new System.Drawing.Size(1082, 402);
            this.dgwPersonelListele.TabIndex = 23;
            // 
            // pnlUrunGrs
            // 
            this.pnlUrunGrs.AutoSize = true;
            this.pnlUrunGrs.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnlUrunGrs.Location = new System.Drawing.Point(418, 20);
            this.pnlUrunGrs.Name = "pnlUrunGrs";
            this.pnlUrunGrs.Size = new System.Drawing.Size(271, 37);
            this.pnlUrunGrs.TabIndex = 0;
            this.pnlUrunGrs.Text = "PERSONEL LİSTESİ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.pnlUrunGrs);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1147, 78);
            this.panel1.TabIndex = 24;
            // 
            // grbUrunAramaIslemleri
            // 
            this.grbUrunAramaIslemleri.Controls.Add(this.BtnRapor);
            this.grbUrunAramaIslemleri.Controls.Add(this.cmbDepartmanTip);
            this.grbUrunAramaIslemleri.Controls.Add(this.BtnTumPersonel);
            this.grbUrunAramaIslemleri.Controls.Add(this.BtnPersonelBul);
            this.grbUrunAramaIslemleri.Controls.Add(this.txtPersonelID);
            this.grbUrunAramaIslemleri.Controls.Add(this.label3);
            this.grbUrunAramaIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbUrunAramaIslemleri.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grbUrunAramaIslemleri.Location = new System.Drawing.Point(32, 105);
            this.grbUrunAramaIslemleri.Name = "grbUrunAramaIslemleri";
            this.grbUrunAramaIslemleri.Size = new System.Drawing.Size(1082, 110);
            this.grbUrunAramaIslemleri.TabIndex = 25;
            this.grbUrunAramaIslemleri.TabStop = false;
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
            this.BtnRapor.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnRapor.ImageOptions.SvgImage")));
            this.BtnRapor.Location = new System.Drawing.Point(825, 16);
            this.BtnRapor.Name = "BtnRapor";
            this.BtnRapor.Size = new System.Drawing.Size(224, 41);
            this.BtnRapor.TabIndex = 26;
            this.BtnRapor.Text = "RAPORLA";
            this.BtnRapor.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Cursor;
            this.BtnRapor.Click += new System.EventHandler(this.BtnRapor_Click);
            // 
            // cmbDepartmanTip
            // 
            this.cmbDepartmanTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartmanTip.FormattingEnabled = true;
            this.cmbDepartmanTip.Location = new System.Drawing.Point(567, 47);
            this.cmbDepartmanTip.Name = "cmbDepartmanTip";
            this.cmbDepartmanTip.Size = new System.Drawing.Size(212, 30);
            this.cmbDepartmanTip.TabIndex = 14;
            this.cmbDepartmanTip.SelectedIndexChanged += new System.EventHandler(this.cmbDepartmanTip_SelectedIndexChanged);
            // 
            // BtnTumPersonel
            // 
            this.BtnTumPersonel.Appearance.BackColor = System.Drawing.Color.White;
            this.BtnTumPersonel.Appearance.BackColor2 = System.Drawing.Color.DodgerBlue;
            this.BtnTumPersonel.Appearance.BorderColor = System.Drawing.Color.White;
            this.BtnTumPersonel.Appearance.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTumPersonel.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BtnTumPersonel.Appearance.Options.UseBackColor = true;
            this.BtnTumPersonel.Appearance.Options.UseBorderColor = true;
            this.BtnTumPersonel.Appearance.Options.UseFont = true;
            this.BtnTumPersonel.Appearance.Options.UseForeColor = true;
            this.BtnTumPersonel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.BtnTumPersonel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnTumPersonel.ImageOptions.SvgImage")));
            this.BtnTumPersonel.Location = new System.Drawing.Point(825, 63);
            this.BtnTumPersonel.Name = "BtnTumPersonel";
            this.BtnTumPersonel.Size = new System.Drawing.Size(224, 41);
            this.BtnTumPersonel.TabIndex = 13;
            this.BtnTumPersonel.Text = "TÜM PERSONEL";
            this.BtnTumPersonel.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Cursor;
            this.BtnTumPersonel.Click += new System.EventHandler(this.BtnTumPersonel_Click);
            // 
            // BtnPersonelBul
            // 
            this.BtnPersonelBul.Appearance.BackColor = System.Drawing.Color.White;
            this.BtnPersonelBul.Appearance.BackColor2 = System.Drawing.Color.DodgerBlue;
            this.BtnPersonelBul.Appearance.BorderColor = System.Drawing.Color.White;
            this.BtnPersonelBul.Appearance.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnPersonelBul.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BtnPersonelBul.Appearance.Options.UseBackColor = true;
            this.BtnPersonelBul.Appearance.Options.UseBorderColor = true;
            this.BtnPersonelBul.Appearance.Options.UseFont = true;
            this.BtnPersonelBul.Appearance.Options.UseForeColor = true;
            this.BtnPersonelBul.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.BtnPersonelBul.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnPersonelBul.ImageOptions.SvgImage")));
            this.BtnPersonelBul.Location = new System.Drawing.Point(340, 39);
            this.BtnPersonelBul.Name = "BtnPersonelBul";
            this.BtnPersonelBul.Size = new System.Drawing.Size(161, 41);
            this.BtnPersonelBul.TabIndex = 12;
            this.BtnPersonelBul.Text = "ARA";
            this.BtnPersonelBul.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Cursor;
            this.BtnPersonelBul.Click += new System.EventHandler(this.BtnPersonelBul_Click);
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelID.Location = new System.Drawing.Point(118, 47);
            this.txtPersonelID.MaxLength = 10;
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(200, 28);
            this.txtPersonelID.TabIndex = 2;
            this.txtPersonelID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPersonelID_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(10, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Personel ID:";
            // 
            // ppdDialog
            // 
            this.ppdDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppdDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppdDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.ppdDialog.Document = this.pdYazici;
            this.ppdDialog.Enabled = true;
            this.ppdDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("ppdDialog.Icon")));
            this.ppdDialog.Name = "ppdDialog";
            this.ppdDialog.Visible = false;
            // 
            // pdYazici
            // 
            this.pdYazici.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdYazici_PrintPage);
            // 
            // FormPersonelListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 637);
            this.Controls.Add(this.grbUrunAramaIslemleri);
            this.Controls.Add(this.dgwPersonelListele);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormPersonelListele";
            this.Load += new System.EventHandler(this.FormPersonelListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPersonelListele)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grbUrunAramaIslemleri.ResumeLayout(false);
            this.grbUrunAramaIslemleri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwPersonelListele;
        private System.Windows.Forms.Label pnlUrunGrs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grbUrunAramaIslemleri;
        private DevExpress.XtraEditors.SimpleButton BtnPersonelBul;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton BtnTumPersonel;
        private System.Windows.Forms.ComboBox cmbDepartmanTip;
        private DevExpress.XtraEditors.SimpleButton BtnRapor;
        private System.Windows.Forms.PrintPreviewDialog ppdDialog;
        private System.Drawing.Printing.PrintDocument pdYazici;
    }
}