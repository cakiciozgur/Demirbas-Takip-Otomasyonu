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
            this.btnPersonelEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnPersonelDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnZimmetListele = new DevExpress.XtraEditors.SimpleButton();
            this.btnZimmetEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnZimmetGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.grbZimmet = new System.Windows.Forms.GroupBox();
            this.grbPersonel = new System.Windows.Forms.GroupBox();
            this.grbZimmet.SuspendLayout();
            this.grbPersonel.SuspendLayout();
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
            this.btnPersonelListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnPersonelListele.Location = new System.Drawing.Point(15, 30);
            this.btnPersonelListele.Name = "btnPersonelListele";
            this.btnPersonelListele.Size = new System.Drawing.Size(200, 180);
            this.btnPersonelListele.TabIndex = 0;
            this.btnPersonelListele.Text = "Personel Listele";
            this.btnPersonelListele.Click += new System.EventHandler(this.BtnPersonelListele_Click);
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.Appearance.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelEkle.Appearance.Options.UseFont = true;
            this.btnPersonelEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btnPersonelEkle.Location = new System.Drawing.Point(221, 30);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(200, 85);
            this.btnPersonelEkle.TabIndex = 1;
            this.btnPersonelEkle.Text = "Personel Ekle";
            this.btnPersonelEkle.Click += new System.EventHandler(this.BtnPersonelEkle_Click);
            // 
            // btnPersonelDuzenle
            // 
            this.btnPersonelDuzenle.Appearance.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelDuzenle.Appearance.Options.UseFont = true;
            this.btnPersonelDuzenle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.btnPersonelDuzenle.Location = new System.Drawing.Point(221, 125);
            this.btnPersonelDuzenle.Name = "btnPersonelDuzenle";
            this.btnPersonelDuzenle.Size = new System.Drawing.Size(200, 85);
            this.btnPersonelDuzenle.TabIndex = 2;
            this.btnPersonelDuzenle.Text = "Personel Düzenle";
            this.btnPersonelDuzenle.Click += new System.EventHandler(this.BtnPersonelDuzenle_Click);
            // 
            // btnZimmetListele
            // 
            this.btnZimmetListele.Appearance.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnZimmetListele.Appearance.Options.UseFont = true;
            this.btnZimmetListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton6.ImageOptions.Image")));
            this.btnZimmetListele.Location = new System.Drawing.Point(14, 33);
            this.btnZimmetListele.Name = "btnZimmetListele";
            this.btnZimmetListele.Size = new System.Drawing.Size(200, 180);
            this.btnZimmetListele.TabIndex = 3;
            this.btnZimmetListele.Text = "Zimmet Listele";
            this.btnZimmetListele.Click += new System.EventHandler(this.BtnZimmetListele_Click);
            // 
            // btnZimmetEkle
            // 
            this.btnZimmetEkle.Appearance.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnZimmetEkle.Appearance.Options.UseFont = true;
            this.btnZimmetEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.ImageOptions.Image")));
            this.btnZimmetEkle.Location = new System.Drawing.Point(220, 33);
            this.btnZimmetEkle.Name = "btnZimmetEkle";
            this.btnZimmetEkle.Size = new System.Drawing.Size(200, 85);
            this.btnZimmetEkle.TabIndex = 4;
            this.btnZimmetEkle.Text = "Zimmet Ekle";
            this.btnZimmetEkle.Click += new System.EventHandler(this.BtnZimmetEkle_Click);
            // 
            // btnZimmetGuncelle
            // 
            this.btnZimmetGuncelle.Appearance.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnZimmetGuncelle.Appearance.Options.UseFont = true;
            this.btnZimmetGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.btnZimmetGuncelle.Location = new System.Drawing.Point(220, 128);
            this.btnZimmetGuncelle.Name = "btnZimmetGuncelle";
            this.btnZimmetGuncelle.Size = new System.Drawing.Size(200, 85);
            this.btnZimmetGuncelle.TabIndex = 5;
            this.btnZimmetGuncelle.Text = "Zimmet Düzenle";
            this.btnZimmetGuncelle.Click += new System.EventHandler(this.BtnZimmetGuncelle_Click);
            // 
            // grbZimmet
            // 
            this.grbZimmet.BackColor = System.Drawing.Color.LightSteelBlue;
            this.grbZimmet.Controls.Add(this.btnZimmetListele);
            this.grbZimmet.Controls.Add(this.btnZimmetEkle);
            this.grbZimmet.Controls.Add(this.btnZimmetGuncelle);
            this.grbZimmet.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grbZimmet.Location = new System.Drawing.Point(29, 139);
            this.grbZimmet.Name = "grbZimmet";
            this.grbZimmet.Size = new System.Drawing.Size(434, 223);
            this.grbZimmet.TabIndex = 10;
            this.grbZimmet.TabStop = false;
            this.grbZimmet.Text = "Zimmet İşlemleri";
            // 
            // grbPersonel
            // 
            this.grbPersonel.BackColor = System.Drawing.Color.LavenderBlush;
            this.grbPersonel.Controls.Add(this.btnPersonelListele);
            this.grbPersonel.Controls.Add(this.btnPersonelEkle);
            this.grbPersonel.Controls.Add(this.btnPersonelDuzenle);
            this.grbPersonel.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grbPersonel.ForeColor = System.Drawing.Color.Black;
            this.grbPersonel.Location = new System.Drawing.Point(469, 139);
            this.grbPersonel.Name = "grbPersonel";
            this.grbPersonel.Size = new System.Drawing.Size(434, 223);
            this.grbPersonel.TabIndex = 13;
            this.grbPersonel.TabStop = false;
            this.grbPersonel.Text = "Personel İşlemleri";
            // 
            // FormBirimYetkilisi
            // 
            this.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 503);
            this.Controls.Add(this.grbZimmet);
            this.Controls.Add(this.grbPersonel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormBirimYetkilisi";
            this.grbZimmet.ResumeLayout(false);
            this.grbPersonel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnPersonelListele;
        private DevExpress.XtraEditors.SimpleButton btnPersonelEkle;
        private DevExpress.XtraEditors.SimpleButton btnPersonelDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnZimmetListele;
        private DevExpress.XtraEditors.SimpleButton btnZimmetEkle;
        private DevExpress.XtraEditors.SimpleButton btnZimmetGuncelle;
        private System.Windows.Forms.GroupBox grbZimmet;
        private System.Windows.Forms.GroupBox grbPersonel;
    }
}