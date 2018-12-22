namespace DemirbasOtomasyon.View
{
    partial class FormPersonelGuncelleme
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlUrunGrs = new System.Windows.Forms.Label();
            this.dgwPersonelListesi = new System.Windows.Forms.DataGridView();
            this.grbZimmetIslemleri = new System.Windows.Forms.GroupBox();
            this.cmbDepartmanGuncelle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPersonelSil = new DevExpress.XtraEditors.SimpleButton();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.calendarControl = new DevExpress.XtraEditors.Controls.CalendarControl();
            this.btnPersonelGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPersonelListesi)).BeginInit();
            this.grbZimmetIslemleri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calendarControl.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.pnlUrunGrs);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1339, 78);
            this.panel1.TabIndex = 18;
            // 
            // pnlUrunGrs
            // 
            this.pnlUrunGrs.AutoSize = true;
            this.pnlUrunGrs.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnlUrunGrs.Location = new System.Drawing.Point(407, 18);
            this.pnlUrunGrs.Name = "pnlUrunGrs";
            this.pnlUrunGrs.Size = new System.Drawing.Size(508, 37);
            this.pnlUrunGrs.TabIndex = 0;
            this.pnlUrunGrs.Text = "PERSONEL GÜNCELLEME İŞLEMLERİ";
            // 
            // dgwPersonelListesi
            // 
            this.dgwPersonelListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwPersonelListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPersonelListesi.Location = new System.Drawing.Point(433, 96);
            this.dgwPersonelListesi.Name = "dgwPersonelListesi";
            this.dgwPersonelListesi.RowTemplate.Height = 24;
            this.dgwPersonelListesi.Size = new System.Drawing.Size(885, 601);
            this.dgwPersonelListesi.TabIndex = 19;
            this.dgwPersonelListesi.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgwPersonelListele_CellMouseDoubleClick);
            // 
            // grbZimmetIslemleri
            // 
            this.grbZimmetIslemleri.Controls.Add(this.cmbDepartmanGuncelle);
            this.grbZimmetIslemleri.Controls.Add(this.label1);
            this.grbZimmetIslemleri.Controls.Add(this.btnPersonelSil);
            this.grbZimmetIslemleri.Controls.Add(this.txtTelefon);
            this.grbZimmetIslemleri.Controls.Add(this.label5);
            this.grbZimmetIslemleri.Controls.Add(this.txtSoyadi);
            this.grbZimmetIslemleri.Controls.Add(this.label2);
            this.grbZimmetIslemleri.Controls.Add(this.txtAdi);
            this.grbZimmetIslemleri.Controls.Add(this.calendarControl);
            this.grbZimmetIslemleri.Controls.Add(this.btnPersonelGuncelle);
            this.grbZimmetIslemleri.Controls.Add(this.txtPersonelID);
            this.grbZimmetIslemleri.Controls.Add(this.label6);
            this.grbZimmetIslemleri.Controls.Add(this.label3);
            this.grbZimmetIslemleri.Controls.Add(this.label7);
            this.grbZimmetIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbZimmetIslemleri.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grbZimmetIslemleri.Location = new System.Drawing.Point(12, 84);
            this.grbZimmetIslemleri.Name = "grbZimmetIslemleri";
            this.grbZimmetIslemleri.Size = new System.Drawing.Size(415, 619);
            this.grbZimmetIslemleri.TabIndex = 20;
            this.grbZimmetIslemleri.TabStop = false;
            this.grbZimmetIslemleri.Text = "Personel Bilgileri";
            // 
            // cmbDepartmanGuncelle
            // 
            this.cmbDepartmanGuncelle.FormattingEnabled = true;
            this.cmbDepartmanGuncelle.Location = new System.Drawing.Point(149, 213);
            this.cmbDepartmanGuncelle.Name = "cmbDepartmanGuncelle";
            this.cmbDepartmanGuncelle.Size = new System.Drawing.Size(200, 30);
            this.cmbDepartmanGuncelle.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(37, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 21);
            this.label1.TabIndex = 27;
            this.label1.Text = "Departman:";
            // 
            // btnPersonelSil
            // 
            this.btnPersonelSil.Appearance.BackColor = System.Drawing.Color.White;
            this.btnPersonelSil.Appearance.BackColor2 = System.Drawing.Color.DodgerBlue;
            this.btnPersonelSil.Appearance.BorderColor = System.Drawing.Color.White;
            this.btnPersonelSil.Appearance.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelSil.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnPersonelSil.Appearance.Options.UseBackColor = true;
            this.btnPersonelSil.Appearance.Options.UseBorderColor = true;
            this.btnPersonelSil.Appearance.Options.UseFont = true;
            this.btnPersonelSil.Appearance.Options.UseForeColor = true;
            this.btnPersonelSil.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnPersonelSil.Location = new System.Drawing.Point(32, 572);
            this.btnPersonelSil.Name = "btnPersonelSil";
            this.btnPersonelSil.Size = new System.Drawing.Size(161, 41);
            this.btnPersonelSil.TabIndex = 26;
            this.btnPersonelSil.Text = "PERSONEL SİL";
            this.btnPersonelSil.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Cursor;
            this.btnPersonelSil.Click += new System.EventHandler(this.BtnPersonelSil_Click);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTelefon.Location = new System.Drawing.Point(149, 173);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(200, 28);
            this.txtTelefon.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(9, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 21);
            this.label5.TabIndex = 24;
            this.label5.Text = "Personel Soyadı:";
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyadi.Location = new System.Drawing.Point(149, 130);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(200, 28);
            this.txtSoyadi.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(28, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "Personel Adı:";
            // 
            // txtAdi
            // 
            this.txtAdi.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdi.Location = new System.Drawing.Point(149, 85);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(200, 28);
            this.txtAdi.TabIndex = 16;
            // 
            // calendarControl
            // 
            this.calendarControl.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calendarControl.Location = new System.Drawing.Point(103, 285);
            this.calendarControl.Name = "calendarControl";
            this.calendarControl.Size = new System.Drawing.Size(246, 261);
            this.calendarControl.TabIndex = 15;
            // 
            // btnPersonelGuncelle
            // 
            this.btnPersonelGuncelle.Appearance.BackColor = System.Drawing.Color.White;
            this.btnPersonelGuncelle.Appearance.BackColor2 = System.Drawing.Color.DodgerBlue;
            this.btnPersonelGuncelle.Appearance.BorderColor = System.Drawing.Color.White;
            this.btnPersonelGuncelle.Appearance.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelGuncelle.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnPersonelGuncelle.Appearance.Options.UseBackColor = true;
            this.btnPersonelGuncelle.Appearance.Options.UseBorderColor = true;
            this.btnPersonelGuncelle.Appearance.Options.UseFont = true;
            this.btnPersonelGuncelle.Appearance.Options.UseForeColor = true;
            this.btnPersonelGuncelle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnPersonelGuncelle.Location = new System.Drawing.Point(248, 572);
            this.btnPersonelGuncelle.Name = "btnPersonelGuncelle";
            this.btnPersonelGuncelle.Size = new System.Drawing.Size(161, 41);
            this.btnPersonelGuncelle.TabIndex = 12;
            this.btnPersonelGuncelle.Text = "GÜNCELLE";
            this.btnPersonelGuncelle.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Cursor;
            this.btnPersonelGuncelle.Click += new System.EventHandler(this.BtnPersonelGuncelle_Click);
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Enabled = false;
            this.txtPersonelID.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelID.Location = new System.Drawing.Point(149, 39);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(200, 28);
            this.txtPersonelID.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "İşe Giriş Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(39, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Personel ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(28, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cep Telefonu:";
            // 
            // FormPersonelGuncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 714);
            this.Controls.Add(this.grbZimmetIslemleri);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgwPersonelListesi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormPersonelGuncelleme";
            this.Load += new System.EventHandler(this.FormPersonelGuncelleme_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPersonelListesi)).EndInit();
            this.grbZimmetIslemleri.ResumeLayout(false);
            this.grbZimmetIslemleri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calendarControl.CalendarTimeProperties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label pnlUrunGrs;
        private System.Windows.Forms.DataGridView dgwPersonelListesi;
        private System.Windows.Forms.GroupBox grbZimmetIslemleri;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdi;
        private DevExpress.XtraEditors.Controls.CalendarControl calendarControl;
        private DevExpress.XtraEditors.SimpleButton btnPersonelGuncelle;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SimpleButton btnPersonelSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDepartmanGuncelle;
    }
}