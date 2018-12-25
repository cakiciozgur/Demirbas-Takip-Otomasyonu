namespace DemirbasOtomasyon.View
{
    partial class FormBirimYetkilisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBirimYetkilisi));
            this.btnPersonelListele = new DevExpress.XtraEditors.SimpleButton();
            this.grbZimmet = new System.Windows.Forms.GroupBox();
            this.btnZimmetListele = new DevExpress.XtraEditors.SimpleButton();
            this.BtnCikis = new DevExpress.XtraEditors.SimpleButton();
            this.grbZimmet.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPersonelListele
            // 
            this.btnPersonelListele.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnPersonelListele.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.btnPersonelListele.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnPersonelListele.Appearance.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelListele.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnPersonelListele.Appearance.Options.UseBackColor = true;
            this.btnPersonelListele.Appearance.Options.UseBorderColor = true;
            this.btnPersonelListele.Appearance.Options.UseFont = true;
            this.btnPersonelListele.Appearance.Options.UseForeColor = true;
            this.btnPersonelListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonelListele.ImageOptions.Image")));
            this.btnPersonelListele.Location = new System.Drawing.Point(220, 33);
            this.btnPersonelListele.Name = "btnPersonelListele";
            this.btnPersonelListele.Size = new System.Drawing.Size(200, 180);
            this.btnPersonelListele.TabIndex = 0;
            this.btnPersonelListele.Text = "Personel Listele";
            this.btnPersonelListele.Click += new System.EventHandler(this.BtnPersonelListele_Click);
            // 
            // grbZimmet
            // 
            this.grbZimmet.BackColor = System.Drawing.Color.LightSteelBlue;
            this.grbZimmet.Controls.Add(this.btnPersonelListele);
            this.grbZimmet.Controls.Add(this.btnZimmetListele);
            this.grbZimmet.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grbZimmet.Location = new System.Drawing.Point(245, 141);
            this.grbZimmet.Name = "grbZimmet";
            this.grbZimmet.Size = new System.Drawing.Size(434, 223);
            this.grbZimmet.TabIndex = 12;
            this.grbZimmet.TabStop = false;
            this.grbZimmet.Text = "Zimmet ve Personel İşlemleri";
            // 
            // btnZimmetListele
            // 
            this.btnZimmetListele.Appearance.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnZimmetListele.Appearance.Options.UseFont = true;
            this.btnZimmetListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnZimmetListele.ImageOptions.Image")));
            this.btnZimmetListele.Location = new System.Drawing.Point(14, 33);
            this.btnZimmetListele.Name = "btnZimmetListele";
            this.btnZimmetListele.Size = new System.Drawing.Size(200, 180);
            this.btnZimmetListele.TabIndex = 3;
            this.btnZimmetListele.Text = "Zimmet Listele";
            this.btnZimmetListele.Click += new System.EventHandler(this.BtnZimmetListele_Click_1);
            // 
            // BtnCikis
            // 
            this.BtnCikis.Appearance.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCikis.Appearance.Options.UseFont = true;
            this.BtnCikis.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.BtnCikis.Location = new System.Drawing.Point(742, 12);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(166, 49);
            this.BtnCikis.TabIndex = 14;
            this.BtnCikis.Text = "ÇIKIŞ YAP";
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // FormBirimYetkilisi
            // 
            this.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 503);
            this.Controls.Add(this.BtnCikis);
            this.Controls.Add(this.grbZimmet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormBirimYetkilisi";
            this.Text = "Birim Yetkili Paneli";
            this.Load += new System.EventHandler(this.FormBirimYetkilisi_Load);
            this.grbZimmet.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnPersonelListele;
        private System.Windows.Forms.GroupBox grbZimmet;
        private DevExpress.XtraEditors.SimpleButton btnZimmetListele;
        private DevExpress.XtraEditors.SimpleButton BtnCikis;
    }
}