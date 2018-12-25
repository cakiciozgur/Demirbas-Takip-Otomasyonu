namespace DemirbasOtomasyon.View
{
    partial class FormAtiklar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAtiklar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlUrunGrs = new System.Windows.Forms.Label();
            this.dgwAtikListesi = new System.Windows.Forms.DataGridView();
            this.txtUrunID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grbUrunAramaIslemleri = new System.Windows.Forms.GroupBox();
            this.BtnTumAtiklar = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAtikBul = new DevExpress.XtraEditors.SimpleButton();
            this.ppdDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.pdYazici = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAtikListesi)).BeginInit();
            this.grbUrunAramaIslemleri.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.pnlUrunGrs);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 78);
            this.panel1.TabIndex = 22;
            // 
            // pnlUrunGrs
            // 
            this.pnlUrunGrs.AutoSize = true;
            this.pnlUrunGrs.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnlUrunGrs.Location = new System.Drawing.Point(251, 20);
            this.pnlUrunGrs.Name = "pnlUrunGrs";
            this.pnlUrunGrs.Size = new System.Drawing.Size(240, 37);
            this.pnlUrunGrs.TabIndex = 0;
            this.pnlUrunGrs.Text = "ATIKLAR LİSTESİ";
            // 
            // dgwAtikListesi
            // 
            this.dgwAtikListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwAtikListesi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgwAtikListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAtikListesi.Location = new System.Drawing.Point(12, 208);
            this.dgwAtikListesi.Name = "dgwAtikListesi";
            this.dgwAtikListesi.ReadOnly = true;
            this.dgwAtikListesi.RowTemplate.Height = 24;
            this.dgwAtikListesi.Size = new System.Drawing.Size(707, 412);
            this.dgwAtikListesi.TabIndex = 20;
            // 
            // txtUrunID
            // 
            this.txtUrunID.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunID.Location = new System.Drawing.Point(94, 46);
            this.txtUrunID.MaxLength = 10;
            this.txtUrunID.Name = "txtUrunID";
            this.txtUrunID.Size = new System.Drawing.Size(200, 28);
            this.txtUrunID.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(1, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ürün ID:";
            // 
            // grbUrunAramaIslemleri
            // 
            this.grbUrunAramaIslemleri.Controls.Add(this.BtnTumAtiklar);
            this.grbUrunAramaIslemleri.Controls.Add(this.BtnAtikBul);
            this.grbUrunAramaIslemleri.Controls.Add(this.txtUrunID);
            this.grbUrunAramaIslemleri.Controls.Add(this.label3);
            this.grbUrunAramaIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbUrunAramaIslemleri.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grbUrunAramaIslemleri.Location = new System.Drawing.Point(12, 84);
            this.grbUrunAramaIslemleri.Name = "grbUrunAramaIslemleri";
            this.grbUrunAramaIslemleri.Size = new System.Drawing.Size(707, 118);
            this.grbUrunAramaIslemleri.TabIndex = 21;
            this.grbUrunAramaIslemleri.TabStop = false;
            // 
            // BtnTumAtiklar
            // 
            this.BtnTumAtiklar.Appearance.BackColor = System.Drawing.Color.White;
            this.BtnTumAtiklar.Appearance.BackColor2 = System.Drawing.Color.DodgerBlue;
            this.BtnTumAtiklar.Appearance.BorderColor = System.Drawing.Color.White;
            this.BtnTumAtiklar.Appearance.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTumAtiklar.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BtnTumAtiklar.Appearance.Options.UseBackColor = true;
            this.BtnTumAtiklar.Appearance.Options.UseBorderColor = true;
            this.BtnTumAtiklar.Appearance.Options.UseFont = true;
            this.BtnTumAtiklar.Appearance.Options.UseForeColor = true;
            this.BtnTumAtiklar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.BtnTumAtiklar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnTumUrunler.ImageOptions.SvgImage")));
            this.BtnTumAtiklar.Location = new System.Drawing.Point(503, 38);
            this.BtnTumAtiklar.Name = "BtnTumAtiklar";
            this.BtnTumAtiklar.Size = new System.Drawing.Size(204, 41);
            this.BtnTumAtiklar.TabIndex = 13;
            this.BtnTumAtiklar.Text = "TÜM ATIKLAR";
            this.BtnTumAtiklar.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Cursor;
            // 
            // BtnAtikBul
            // 
            this.BtnAtikBul.Appearance.BackColor = System.Drawing.Color.White;
            this.BtnAtikBul.Appearance.BackColor2 = System.Drawing.Color.DodgerBlue;
            this.BtnAtikBul.Appearance.BorderColor = System.Drawing.Color.White;
            this.BtnAtikBul.Appearance.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAtikBul.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BtnAtikBul.Appearance.Options.UseBackColor = true;
            this.BtnAtikBul.Appearance.Options.UseBorderColor = true;
            this.BtnAtikBul.Appearance.Options.UseFont = true;
            this.BtnAtikBul.Appearance.Options.UseForeColor = true;
            this.BtnAtikBul.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.BtnAtikBul.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnUrunBul.ImageOptions.SvgImage")));
            this.BtnAtikBul.Location = new System.Drawing.Point(318, 38);
            this.BtnAtikBul.Name = "BtnAtikBul";
            this.BtnAtikBul.Size = new System.Drawing.Size(161, 41);
            this.BtnAtikBul.TabIndex = 12;
            this.BtnAtikBul.Text = "ARA";
            this.BtnAtikBul.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Cursor;
            this.BtnAtikBul.Click += new System.EventHandler(this.BtnAtikBul_Click);
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
            // FormAtiklar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 637);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grbUrunAramaIslemleri);
            this.Controls.Add(this.dgwAtikListesi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormAtiklar";
            this.Load += new System.EventHandler(this.FormAtiklar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAtikListesi)).EndInit();
            this.grbUrunAramaIslemleri.ResumeLayout(false);
            this.grbUrunAramaIslemleri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label pnlUrunGrs;
        private System.Windows.Forms.DataGridView dgwAtikListesi;
        private System.Windows.Forms.TextBox txtUrunID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grbUrunAramaIslemleri;
        private DevExpress.XtraEditors.SimpleButton BtnTumAtiklar;
        private DevExpress.XtraEditors.SimpleButton BtnAtikBul;
        private System.Windows.Forms.PrintPreviewDialog ppdDialog;
        private System.Drawing.Printing.PrintDocument pdYazici;
    }
}