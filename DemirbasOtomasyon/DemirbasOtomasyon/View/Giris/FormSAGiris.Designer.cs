namespace DemirbasOtomasyon.View
{
    partial class FormSAGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSAGiris));
            this.pbLock = new System.Windows.Forms.PictureBox();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.lblGiris = new System.Windows.Forms.Label();
            this.pnlGiris2 = new System.Windows.Forms.Panel();
            this.btnVazgec = new DevExpress.XtraEditors.SimpleButton();
            this.btnGiris = new DevExpress.XtraEditors.SimpleButton();
            this.pnlGiris1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.pnlGiris2.SuspendLayout();
            this.pnlGiris1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbLock
            // 
            this.pbLock.Image = ((System.Drawing.Image)(resources.GetObject("pbLock.Image")));
            this.pbLock.Location = new System.Drawing.Point(37, 168);
            this.pbLock.Name = "pbLock";
            this.pbLock.Size = new System.Drawing.Size(54, 50);
            this.pbLock.TabIndex = 22;
            this.pbLock.TabStop = false;
            // 
            // pbUser
            // 
            this.pbUser.Image = ((System.Drawing.Image)(resources.GetObject("pbUser.Image")));
            this.pbUser.Location = new System.Drawing.Point(37, 100);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(54, 50);
            this.pbUser.TabIndex = 21;
            this.pbUser.TabStop = false;
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.ForeColor = System.Drawing.Color.Black;
            this.txtSifre.Location = new System.Drawing.Point(97, 182);
            this.txtSifre.MaxLength = 8;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(281, 36);
            this.txtSifre.TabIndex = 20;
            this.txtSifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSifre_KeyPress);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.ForeColor = System.Drawing.Color.Black;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(97, 114);
            this.txtKullaniciAdi.MaxLength = 10;
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(281, 36);
            this.txtKullaniciAdi.TabIndex = 19;
            this.txtKullaniciAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKullaniciAdi_KeyPress);
            // 
            // lblGiris
            // 
            this.lblGiris.AutoSize = true;
            this.lblGiris.Font = new System.Drawing.Font("Corbel", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGiris.ForeColor = System.Drawing.Color.Black;
            this.lblGiris.Location = new System.Drawing.Point(28, 18);
            this.lblGiris.Name = "lblGiris";
            this.lblGiris.Size = new System.Drawing.Size(383, 46);
            this.lblGiris.TabIndex = 4;
            this.lblGiris.Text = "Satın Alma Birimi Giriş";
            // 
            // pnlGiris2
            // 
            this.pnlGiris2.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlGiris2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGiris2.Controls.Add(this.btnVazgec);
            this.pnlGiris2.Controls.Add(this.btnGiris);
            this.pnlGiris2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.pnlGiris2.Location = new System.Drawing.Point(-1, 240);
            this.pnlGiris2.Name = "pnlGiris2";
            this.pnlGiris2.Size = new System.Drawing.Size(430, 119);
            this.pnlGiris2.TabIndex = 24;
            // 
            // btnVazgec
            // 
            this.btnVazgec.Appearance.BackColor = System.Drawing.Color.White;
            this.btnVazgec.Appearance.BackColor2 = System.Drawing.Color.White;
            this.btnVazgec.Appearance.Font = new System.Drawing.Font("Corbel", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVazgec.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnVazgec.Appearance.Options.UseBackColor = true;
            this.btnVazgec.Appearance.Options.UseFont = true;
            this.btnVazgec.Appearance.Options.UseForeColor = true;
            this.btnVazgec.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnVazgec.Location = new System.Drawing.Point(82, 15);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(145, 49);
            this.btnVazgec.TabIndex = 5;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.Click += new System.EventHandler(this.BtnVazgec_Click);
            // 
            // btnGiris
            // 
            this.btnGiris.Appearance.BackColor = System.Drawing.Color.White;
            this.btnGiris.Appearance.BackColor2 = System.Drawing.Color.White;
            this.btnGiris.Appearance.Font = new System.Drawing.Font("Corbel", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnGiris.Appearance.Options.UseBackColor = true;
            this.btnGiris.Appearance.Options.UseFont = true;
            this.btnGiris.Appearance.Options.UseForeColor = true;
            this.btnGiris.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnGiris.Location = new System.Drawing.Point(233, 15);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(145, 49);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // pnlGiris1
            // 
            this.pnlGiris1.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlGiris1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGiris1.Controls.Add(this.lblGiris);
            this.pnlGiris1.ForeColor = System.Drawing.Color.Black;
            this.pnlGiris1.Location = new System.Drawing.Point(-1, -1);
            this.pnlGiris1.Name = "pnlGiris1";
            this.pnlGiris1.Size = new System.Drawing.Size(430, 78);
            this.pnlGiris1.TabIndex = 23;
            // 
            // FormSAGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 358);
            this.Controls.Add(this.pbLock);
            this.Controls.Add(this.pbUser);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.pnlGiris2);
            this.Controls.Add(this.pnlGiris1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FormSAGiris";
            this.Load += new System.EventHandler(this.FormSAGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.pnlGiris2.ResumeLayout(false);
            this.pnlGiris1.ResumeLayout(false);
            this.pnlGiris1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLock;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label lblGiris;
        private System.Windows.Forms.Panel pnlGiris2;
        private DevExpress.XtraEditors.SimpleButton btnVazgec;
        private DevExpress.XtraEditors.SimpleButton btnGiris;
        private System.Windows.Forms.Panel pnlGiris1;
    }
}