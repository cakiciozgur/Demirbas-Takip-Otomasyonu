namespace DemirbasOtomasyon.View
{
    partial class FormZimmetGuncelleme
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
            this.grbUrunIslemleri = new System.Windows.Forms.GroupBox();
            this.cmbKullaniciGuncelle = new System.Windows.Forms.ComboBox();
            this.cmbPersonelGuncelle = new System.Windows.Forms.ComboBox();
            this.btnKaldır = new DevExpress.XtraEditors.SimpleButton();
            this.calendarControl1 = new DevExpress.XtraEditors.Controls.CalendarControl();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.txtZimmetID = new System.Windows.Forms.TextBox();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgwZimmetGuncellemeListele = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.grbUrunIslemleri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calendarControl1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwZimmetGuncellemeListele)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.pnlUrunGrs);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1265, 78);
            this.panel1.TabIndex = 18;
            // 
            // pnlUrunGrs
            // 
            this.pnlUrunGrs.AutoSize = true;
            this.pnlUrunGrs.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnlUrunGrs.Location = new System.Drawing.Point(406, 20);
            this.pnlUrunGrs.Name = "pnlUrunGrs";
            this.pnlUrunGrs.Size = new System.Drawing.Size(470, 37);
            this.pnlUrunGrs.TabIndex = 0;
            this.pnlUrunGrs.Text = "ZİMMET GÜNCELLEME İŞLEMLERİ";
            // 
            // grbUrunIslemleri
            // 
            this.grbUrunIslemleri.Controls.Add(this.cmbKullaniciGuncelle);
            this.grbUrunIslemleri.Controls.Add(this.cmbPersonelGuncelle);
            this.grbUrunIslemleri.Controls.Add(this.btnKaldır);
            this.grbUrunIslemleri.Controls.Add(this.calendarControl1);
            this.grbUrunIslemleri.Controls.Add(this.btnGuncelle);
            this.grbUrunIslemleri.Controls.Add(this.txtZimmetID);
            this.grbUrunIslemleri.Controls.Add(this.txtAdet);
            this.grbUrunIslemleri.Controls.Add(this.label6);
            this.grbUrunIslemleri.Controls.Add(this.label1);
            this.grbUrunIslemleri.Controls.Add(this.label4);
            this.grbUrunIslemleri.Controls.Add(this.label3);
            this.grbUrunIslemleri.Controls.Add(this.label7);
            this.grbUrunIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbUrunIslemleri.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grbUrunIslemleri.Location = new System.Drawing.Point(13, 90);
            this.grbUrunIslemleri.Name = "grbUrunIslemleri";
            this.grbUrunIslemleri.Size = new System.Drawing.Size(413, 551);
            this.grbUrunIslemleri.TabIndex = 20;
            this.grbUrunIslemleri.TabStop = false;
            this.grbUrunIslemleri.Text = "Zimmet Detayları";
            // 
            // cmbKullaniciGuncelle
            // 
            this.cmbKullaniciGuncelle.FormattingEnabled = true;
            this.cmbKullaniciGuncelle.Location = new System.Drawing.Point(139, 162);
            this.cmbKullaniciGuncelle.Name = "cmbKullaniciGuncelle";
            this.cmbKullaniciGuncelle.Size = new System.Drawing.Size(200, 30);
            this.cmbKullaniciGuncelle.TabIndex = 22;
            // 
            // cmbPersonelGuncelle
            // 
            this.cmbPersonelGuncelle.FormattingEnabled = true;
            this.cmbPersonelGuncelle.Location = new System.Drawing.Point(139, 121);
            this.cmbPersonelGuncelle.Name = "cmbPersonelGuncelle";
            this.cmbPersonelGuncelle.Size = new System.Drawing.Size(200, 30);
            this.cmbPersonelGuncelle.TabIndex = 21;
            // 
            // btnKaldır
            // 
            this.btnKaldır.Appearance.BackColor = System.Drawing.Color.White;
            this.btnKaldır.Appearance.BackColor2 = System.Drawing.Color.DodgerBlue;
            this.btnKaldır.Appearance.BorderColor = System.Drawing.Color.White;
            this.btnKaldır.Appearance.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaldır.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnKaldır.Appearance.Options.UseBackColor = true;
            this.btnKaldır.Appearance.Options.UseBorderColor = true;
            this.btnKaldır.Appearance.Options.UseFont = true;
            this.btnKaldır.Appearance.Options.UseForeColor = true;
            this.btnKaldır.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnKaldır.Location = new System.Drawing.Point(31, 495);
            this.btnKaldır.Name = "btnKaldır";
            this.btnKaldır.Size = new System.Drawing.Size(161, 41);
            this.btnKaldır.TabIndex = 15;
            this.btnKaldır.Text = "ZİMMET KALDIR";
            this.btnKaldır.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Cursor;
            this.btnKaldır.Click += new System.EventHandler(this.BtnKaldır_Click);
            // 
            // calendarControl1
            // 
            this.calendarControl1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calendarControl1.Location = new System.Drawing.Point(142, 207);
            this.calendarControl1.Name = "calendarControl1";
            this.calendarControl1.Size = new System.Drawing.Size(246, 261);
            this.calendarControl1.TabIndex = 14;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Appearance.BackColor = System.Drawing.Color.White;
            this.btnGuncelle.Appearance.BackColor2 = System.Drawing.Color.DodgerBlue;
            this.btnGuncelle.Appearance.BorderColor = System.Drawing.Color.White;
            this.btnGuncelle.Appearance.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnGuncelle.Appearance.Options.UseBackColor = true;
            this.btnGuncelle.Appearance.Options.UseBorderColor = true;
            this.btnGuncelle.Appearance.Options.UseFont = true;
            this.btnGuncelle.Appearance.Options.UseForeColor = true;
            this.btnGuncelle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnGuncelle.Location = new System.Drawing.Point(227, 495);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(161, 41);
            this.btnGuncelle.TabIndex = 12;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Cursor;
            this.btnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // txtZimmetID
            // 
            this.txtZimmetID.Enabled = false;
            this.txtZimmetID.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtZimmetID.Location = new System.Drawing.Point(139, 44);
            this.txtZimmetID.Name = "txtZimmetID";
            this.txtZimmetID.Size = new System.Drawing.Size(200, 28);
            this.txtZimmetID.TabIndex = 2;
            // 
            // txtAdet
            // 
            this.txtAdet.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdet.Location = new System.Drawing.Point(139, 81);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(200, 28);
            this.txtAdet.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(13, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Zimmet Tarihi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(37, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Zimmet ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(56, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Personel:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(82, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Adet:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(56, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Kullanıcı:";
            // 
            // dgwZimmetGuncellemeListele
            // 
            this.dgwZimmetGuncellemeListele.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwZimmetGuncellemeListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwZimmetGuncellemeListele.Location = new System.Drawing.Point(432, 100);
            this.dgwZimmetGuncellemeListele.Name = "dgwZimmetGuncellemeListele";
            this.dgwZimmetGuncellemeListele.RowTemplate.Height = 24;
            this.dgwZimmetGuncellemeListele.Size = new System.Drawing.Size(821, 541);
            this.dgwZimmetGuncellemeListele.TabIndex = 19;
            this.dgwZimmetGuncellemeListele.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgwZimmetGuncellemeListele_CellMouseDoubleClick);
            // 
            // FormZimmetGuncelleme
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 651);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grbUrunIslemleri);
            this.Controls.Add(this.dgwZimmetGuncellemeListele);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormZimmetGuncelleme";
            this.Load += new System.EventHandler(this.FormZimmetGuncelleme_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grbUrunIslemleri.ResumeLayout(false);
            this.grbUrunIslemleri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calendarControl1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwZimmetGuncellemeListele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label pnlUrunGrs;
        private System.Windows.Forms.GroupBox grbUrunIslemleri;
        private DevExpress.XtraEditors.SimpleButton btnKaldır;
        private DevExpress.XtraEditors.Controls.CalendarControl calendarControl1;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private System.Windows.Forms.TextBox txtZimmetID;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgwZimmetGuncellemeListele;
        private System.Windows.Forms.ComboBox cmbKullaniciGuncelle;
        private System.Windows.Forms.ComboBox cmbPersonelGuncelle;
    }
}