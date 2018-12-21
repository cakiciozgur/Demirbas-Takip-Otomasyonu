namespace DemirbasOtomasyon.View
{
    partial class FormKullaniciSecim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKullaniciSecim));
            this.btnSatinAlmaBirimi = new DevExpress.XtraEditors.SimpleButton();
            this.btnBirimYetkilisi = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdmin = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSatinAlmaBirimi
            // 
            this.btnSatinAlmaBirimi.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSatinAlmaBirimi.Appearance.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatinAlmaBirimi.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnSatinAlmaBirimi.Appearance.Options.UseBackColor = true;
            this.btnSatinAlmaBirimi.Appearance.Options.UseFont = true;
            this.btnSatinAlmaBirimi.Appearance.Options.UseForeColor = true;
            this.btnSatinAlmaBirimi.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnSatinAlmaBirimi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSatinAlmaBirimi.ImageOptions.Image")));
            this.btnSatinAlmaBirimi.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnSatinAlmaBirimi.Location = new System.Drawing.Point(657, 113);
            this.btnSatinAlmaBirimi.Name = "btnSatinAlmaBirimi";
            this.btnSatinAlmaBirimi.Size = new System.Drawing.Size(291, 375);
            this.btnSatinAlmaBirimi.TabIndex = 2;
            this.btnSatinAlmaBirimi.Text = "SATIN ALMA BİRİMİ GİRİŞ";
            this.btnSatinAlmaBirimi.Click += new System.EventHandler(this.BtnSatinAlmaBirimi_Click);
            // 
            // btnBirimYetkilisi
            // 
            this.btnBirimYetkilisi.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBirimYetkilisi.Appearance.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBirimYetkilisi.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnBirimYetkilisi.Appearance.Options.UseBackColor = true;
            this.btnBirimYetkilisi.Appearance.Options.UseFont = true;
            this.btnBirimYetkilisi.Appearance.Options.UseForeColor = true;
            this.btnBirimYetkilisi.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnBirimYetkilisi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBirimYetkilisi.ImageOptions.Image")));
            this.btnBirimYetkilisi.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnBirimYetkilisi.Location = new System.Drawing.Point(328, 113);
            this.btnBirimYetkilisi.Name = "btnBirimYetkilisi";
            this.btnBirimYetkilisi.Size = new System.Drawing.Size(310, 375);
            this.btnBirimYetkilisi.TabIndex = 3;
            this.btnBirimYetkilisi.Text = "BİRİM YETKİLİSİ GİRİŞİ";
            this.btnBirimYetkilisi.Click += new System.EventHandler(this.BtnBirimYetkilisi_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdmin.Appearance.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdmin.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Appearance.Options.UseBackColor = true;
            this.btnAdmin.Appearance.Options.UseFont = true;
            this.btnAdmin.Appearance.Options.UseForeColor = true;
            this.btnAdmin.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnAdmin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmin.ImageOptions.Image")));
            this.btnAdmin.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnAdmin.Location = new System.Drawing.Point(12, 113);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(296, 375);
            this.btnAdmin.TabIndex = 4;
            this.btnAdmin.Text = "ADMİN GİRİŞİ";
            this.btnAdmin.Click += new System.EventHandler(this.BtnAdmin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.btnAdmin);
            this.panel1.Controls.Add(this.btnBirimYetkilisi);
            this.panel1.Controls.Add(this.btnSatinAlmaBirimi);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 611);
            this.panel1.TabIndex = 17;
            // 
            // FormKullaniciSecim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 607);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormKullaniciSecim";
            this.Text = "Kullanıcı Seçimi";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSatinAlmaBirimi;
        private DevExpress.XtraEditors.SimpleButton btnBirimYetkilisi;
        private DevExpress.XtraEditors.SimpleButton btnAdmin;
        private System.Windows.Forms.Panel panel1;
    }
}