namespace DemirbasOtomasyon
{
    partial class UserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl));
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.pbLock = new System.Windows.Forms.PictureBox();
            this.lblGiris = new System.Windows.Forms.Label();
            this.pnlGiris1 = new System.Windows.Forms.Panel();
            this.pnlGiris2 = new System.Windows.Forms.Panel();
            this.btnGiris = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLock)).BeginInit();
            this.pnlGiris1.SuspendLayout();
            this.pnlGiris2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtID.ForeColor = System.Drawing.Color.Black;
            this.txtID.Location = new System.Drawing.Point(98, 103);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(281, 50);
            this.txtID.TabIndex = 0;
            this.txtID.Text = "ID Giriniz...";
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.ForeColor = System.Drawing.Color.Black;
            this.txtSifre.Location = new System.Drawing.Point(98, 171);
            this.txtSifre.Multiline = true;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(281, 50);
            this.txtSifre.TabIndex = 1;
            this.txtSifre.Text = "Şifre Giriniz...";
            // 
            // pbUser
            // 
            this.pbUser.Image = ((System.Drawing.Image)(resources.GetObject("pbUser.Image")));
            this.pbUser.Location = new System.Drawing.Point(38, 101);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(54, 50);
            this.pbUser.TabIndex = 2;
            this.pbUser.TabStop = false;
            // 
            // pbLock
            // 
            this.pbLock.Image = ((System.Drawing.Image)(resources.GetObject("pbLock.Image")));
            this.pbLock.Location = new System.Drawing.Point(38, 169);
            this.pbLock.Name = "pbLock";
            this.pbLock.Size = new System.Drawing.Size(54, 50);
            this.pbLock.TabIndex = 3;
            this.pbLock.TabStop = false;
            // 
            // lblGiris
            // 
            this.lblGiris.AutoSize = true;
            this.lblGiris.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGiris.ForeColor = System.Drawing.Color.Black;
            this.lblGiris.Location = new System.Drawing.Point(139, 24);
            this.lblGiris.Name = "lblGiris";
            this.lblGiris.Size = new System.Drawing.Size(156, 29);
            this.lblGiris.TabIndex = 4;
            this.lblGiris.Text = "Kullanici Girişi";
            // 
            // pnlGiris1
            // 
            this.pnlGiris1.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlGiris1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGiris1.Controls.Add(this.lblGiris);
            this.pnlGiris1.ForeColor = System.Drawing.Color.Black;
            this.pnlGiris1.Location = new System.Drawing.Point(0, 0);
            this.pnlGiris1.Name = "pnlGiris1";
            this.pnlGiris1.Size = new System.Drawing.Size(430, 78);
            this.pnlGiris1.TabIndex = 5;
            // 
            // pnlGiris2
            // 
            this.pnlGiris2.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlGiris2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGiris2.Controls.Add(this.btnGiris);
            this.pnlGiris2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.pnlGiris2.Location = new System.Drawing.Point(0, 243);
            this.pnlGiris2.Name = "pnlGiris2";
            this.pnlGiris2.Size = new System.Drawing.Size(430, 115);
            this.pnlGiris2.TabIndex = 6;
            // 
            // btnGiris
            // 
            this.btnGiris.Appearance.BackColor = System.Drawing.Color.White;
            this.btnGiris.Appearance.BackColor2 = System.Drawing.Color.White;
            this.btnGiris.Appearance.Font = new System.Drawing.Font("Corbel", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnGiris.Appearance.Options.UseBackColor = true;
            this.btnGiris.Appearance.Options.UseFont = true;
            this.btnGiris.Appearance.Options.UseForeColor = true;
            this.btnGiris.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnGiris.Location = new System.Drawing.Point(144, 15);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(150, 45);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "Giriş Yap";
            // 
            // UserControl
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(426, 354);
            this.Controls.Add(this.pnlGiris2);
            this.Controls.Add(this.pnlGiris1);
            this.Controls.Add(this.pbLock);
            this.Controls.Add(this.pbUser);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "UserControl";
            this.Text = "UserControl";
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLock)).EndInit();
            this.pnlGiris1.ResumeLayout(false);
            this.pnlGiris1.PerformLayout();
            this.pnlGiris2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.PictureBox pbLock;
        private System.Windows.Forms.Label lblGiris;
        private System.Windows.Forms.Panel pnlGiris1;
        private System.Windows.Forms.Panel pnlGiris2;
        private DevExpress.XtraEditors.SimpleButton btnGiris;
    }
}