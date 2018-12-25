namespace DemirbasOtomasyon.View
{
    partial class FormZimmetListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormZimmetListele));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlUrunGrs = new System.Windows.Forms.Label();
            this.dgwZimmetListele = new System.Windows.Forms.DataGridView();
            this.grbUrunAramaIslemleri = new System.Windows.Forms.GroupBox();
            this.BtnRapor = new DevExpress.XtraEditors.SimpleButton();
            this.cmbDepartmanTip = new System.Windows.Forms.ComboBox();
            this.BtnTumZimmetler = new DevExpress.XtraEditors.SimpleButton();
            this.BtnZimmetBul = new DevExpress.XtraEditors.SimpleButton();
            this.txtZimmetID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ppdDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.pdYazici = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwZimmetListele)).BeginInit();
            this.grbUrunAramaIslemleri.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.pnlUrunGrs);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1147, 78);
            this.panel1.TabIndex = 22;
            // 
            // pnlUrunGrs
            // 
            this.pnlUrunGrs.AutoSize = true;
            this.pnlUrunGrs.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnlUrunGrs.Location = new System.Drawing.Point(421, 26);
            this.pnlUrunGrs.Name = "pnlUrunGrs";
            this.pnlUrunGrs.Size = new System.Drawing.Size(285, 37);
            this.pnlUrunGrs.TabIndex = 0;
            this.pnlUrunGrs.Text = "ZİMMETLER LİSTESİ";
            // 
            // dgwZimmetListele
            // 
            this.dgwZimmetListele.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwZimmetListele.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwZimmetListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwZimmetListele.Location = new System.Drawing.Point(33, 221);
            this.dgwZimmetListele.Name = "dgwZimmetListele";
            this.dgwZimmetListele.ReadOnly = true;
            this.dgwZimmetListele.RowTemplate.Height = 24;
            this.dgwZimmetListele.Size = new System.Drawing.Size(1082, 402);
            this.dgwZimmetListele.TabIndex = 20;
            // 
            // grbUrunAramaIslemleri
            // 
            this.grbUrunAramaIslemleri.Controls.Add(this.BtnRapor);
            this.grbUrunAramaIslemleri.Controls.Add(this.cmbDepartmanTip);
            this.grbUrunAramaIslemleri.Controls.Add(this.BtnTumZimmetler);
            this.grbUrunAramaIslemleri.Controls.Add(this.BtnZimmetBul);
            this.grbUrunAramaIslemleri.Controls.Add(this.txtZimmetID);
            this.grbUrunAramaIslemleri.Controls.Add(this.label3);
            this.grbUrunAramaIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbUrunAramaIslemleri.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grbUrunAramaIslemleri.Location = new System.Drawing.Point(33, 105);
            this.grbUrunAramaIslemleri.Name = "grbUrunAramaIslemleri";
            this.grbUrunAramaIslemleri.Size = new System.Drawing.Size(1082, 110);
            this.grbUrunAramaIslemleri.TabIndex = 23;
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
            this.BtnRapor.Location = new System.Drawing.Point(826, 16);
            this.BtnRapor.Name = "BtnRapor";
            this.BtnRapor.Size = new System.Drawing.Size(214, 41);
            this.BtnRapor.TabIndex = 25;
            this.BtnRapor.Text = "RAPORLA";
            this.BtnRapor.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Cursor;
            this.BtnRapor.Click += new System.EventHandler(this.BtnRapor_Click);
            // 
            // cmbDepartmanTip
            // 
            this.cmbDepartmanTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartmanTip.FormattingEnabled = true;
            this.cmbDepartmanTip.Location = new System.Drawing.Point(617, 50);
            this.cmbDepartmanTip.Name = "cmbDepartmanTip";
            this.cmbDepartmanTip.Size = new System.Drawing.Size(184, 30);
            this.cmbDepartmanTip.TabIndex = 24;
            this.cmbDepartmanTip.SelectedIndexChanged += new System.EventHandler(this.cmbDepartmanTip_SelectedIndexChanged);
            // 
            // BtnTumZimmetler
            // 
            this.BtnTumZimmetler.Appearance.BackColor = System.Drawing.Color.White;
            this.BtnTumZimmetler.Appearance.BackColor2 = System.Drawing.Color.DodgerBlue;
            this.BtnTumZimmetler.Appearance.BorderColor = System.Drawing.Color.White;
            this.BtnTumZimmetler.Appearance.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTumZimmetler.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BtnTumZimmetler.Appearance.Options.UseBackColor = true;
            this.BtnTumZimmetler.Appearance.Options.UseBorderColor = true;
            this.BtnTumZimmetler.Appearance.Options.UseFont = true;
            this.BtnTumZimmetler.Appearance.Options.UseForeColor = true;
            this.BtnTumZimmetler.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.BtnTumZimmetler.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnTumZimmetler.ImageOptions.SvgImage")));
            this.BtnTumZimmetler.Location = new System.Drawing.Point(826, 63);
            this.BtnTumZimmetler.Name = "BtnTumZimmetler";
            this.BtnTumZimmetler.Size = new System.Drawing.Size(214, 41);
            this.BtnTumZimmetler.TabIndex = 13;
            this.BtnTumZimmetler.Text = "TÜM ZİMMETLER";
            this.BtnTumZimmetler.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Cursor;
            this.BtnTumZimmetler.Click += new System.EventHandler(this.BtnTumZimmetler_Click);
            // 
            // BtnZimmetBul
            // 
            this.BtnZimmetBul.Appearance.BackColor = System.Drawing.Color.White;
            this.BtnZimmetBul.Appearance.BackColor2 = System.Drawing.Color.DodgerBlue;
            this.BtnZimmetBul.Appearance.BorderColor = System.Drawing.Color.White;
            this.BtnZimmetBul.Appearance.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnZimmetBul.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BtnZimmetBul.Appearance.Options.UseBackColor = true;
            this.BtnZimmetBul.Appearance.Options.UseBorderColor = true;
            this.BtnZimmetBul.Appearance.Options.UseFont = true;
            this.BtnZimmetBul.Appearance.Options.UseForeColor = true;
            this.BtnZimmetBul.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.BtnZimmetBul.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnZimmetBul.ImageOptions.SvgImage")));
            this.BtnZimmetBul.Location = new System.Drawing.Point(379, 42);
            this.BtnZimmetBul.Name = "BtnZimmetBul";
            this.BtnZimmetBul.Size = new System.Drawing.Size(161, 41);
            this.BtnZimmetBul.TabIndex = 12;
            this.BtnZimmetBul.Text = "ARA";
            this.BtnZimmetBul.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Cursor;
            this.BtnZimmetBul.Click += new System.EventHandler(this.BtnZimmetBul_Click);
            // 
            // txtZimmetID
            // 
            this.txtZimmetID.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtZimmetID.Location = new System.Drawing.Point(112, 50);
            this.txtZimmetID.MaxLength = 10;
            this.txtZimmetID.Name = "txtZimmetID";
            this.txtZimmetID.Size = new System.Drawing.Size(200, 28);
            this.txtZimmetID.TabIndex = 2;
            this.txtZimmetID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZimmetID_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(10, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Zimmet ID:";
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
            // FormZimmetListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 638);
            this.Controls.Add(this.grbUrunAramaIslemleri);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgwZimmetListele);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormZimmetListele";
            this.Load += new System.EventHandler(this.FormZimmetListele_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwZimmetListele)).EndInit();
            this.grbUrunAramaIslemleri.ResumeLayout(false);
            this.grbUrunAramaIslemleri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label pnlUrunGrs;
        private System.Windows.Forms.DataGridView dgwZimmetListele;
        private System.Windows.Forms.GroupBox grbUrunAramaIslemleri;
        private DevExpress.XtraEditors.SimpleButton BtnZimmetBul;
        private System.Windows.Forms.TextBox txtZimmetID;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton BtnTumZimmetler;
        private System.Windows.Forms.ComboBox cmbDepartmanTip;
        private DevExpress.XtraEditors.SimpleButton BtnRapor;
        private System.Windows.Forms.PrintPreviewDialog ppdDialog;
        private System.Drawing.Printing.PrintDocument pdYazici;
    }
}