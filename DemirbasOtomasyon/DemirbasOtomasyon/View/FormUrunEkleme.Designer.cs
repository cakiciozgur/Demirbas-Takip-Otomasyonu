namespace DemirbasOtomasyon.View
{
    partial class FormUrunEkleme
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
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.dtpAlimTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grbUrunIslemleri = new System.Windows.Forms.GroupBox();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlUrunGrs = new System.Windows.Forms.Label();
            this.dgwUrun = new System.Windows.Forms.DataGridView();
            this.grbUrunIslemleri.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrun)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunAd.Location = new System.Drawing.Point(134, 42);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(200, 28);
            this.txtUrunAd.TabIndex = 2;
            // 
            // dtpAlimTarihi
            // 
            this.dtpAlimTarihi.Location = new System.Drawing.Point(134, 185);
            this.dtpAlimTarihi.Name = "dtpAlimTarihi";
            this.dtpAlimTarihi.Size = new System.Drawing.Size(200, 29);
            this.dtpAlimTarihi.TabIndex = 8;
            // 
            // txtAdet
            // 
            this.txtAdet.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdet.Location = new System.Drawing.Point(134, 86);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(200, 28);
            this.txtAdet.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(69, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tarih:";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFiyat.Location = new System.Drawing.Point(134, 136);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(200, 28);
            this.txtFiyat.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(65, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Adet:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(41, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ürün Adı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(69, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fiyat:";
            // 
            // grbUrunIslemleri
            // 
            this.grbUrunIslemleri.Controls.Add(this.btnEkle);
            this.grbUrunIslemleri.Controls.Add(this.txtUrunAd);
            this.grbUrunIslemleri.Controls.Add(this.dtpAlimTarihi);
            this.grbUrunIslemleri.Controls.Add(this.txtAdet);
            this.grbUrunIslemleri.Controls.Add(this.label6);
            this.grbUrunIslemleri.Controls.Add(this.txtFiyat);
            this.grbUrunIslemleri.Controls.Add(this.label4);
            this.grbUrunIslemleri.Controls.Add(this.label3);
            this.grbUrunIslemleri.Controls.Add(this.label7);
            this.grbUrunIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbUrunIslemleri.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grbUrunIslemleri.Location = new System.Drawing.Point(61, 98);
            this.grbUrunIslemleri.Name = "grbUrunIslemleri";
            this.grbUrunIslemleri.Size = new System.Drawing.Size(1017, 224);
            this.grbUrunIslemleri.TabIndex = 12;
            this.grbUrunIslemleri.TabStop = false;
            this.grbUrunIslemleri.Text = "Ürün Satın Alma İşlemleri";
            // 
            // btnEkle
            // 
            this.btnEkle.Appearance.BackColor = System.Drawing.Color.White;
            this.btnEkle.Appearance.BackColor2 = System.Drawing.Color.DodgerBlue;
            this.btnEkle.Appearance.BorderColor = System.Drawing.Color.White;
            this.btnEkle.Appearance.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnEkle.Appearance.Options.UseBackColor = true;
            this.btnEkle.Appearance.Options.UseBorderColor = true;
            this.btnEkle.Appearance.Options.UseFont = true;
            this.btnEkle.Appearance.Options.UseForeColor = true;
            this.btnEkle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnEkle.Location = new System.Drawing.Point(381, 173);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(161, 41);
            this.btnEkle.TabIndex = 12;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Cursor;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.pnlUrunGrs);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1147, 78);
            this.panel1.TabIndex = 13;
            // 
            // pnlUrunGrs
            // 
            this.pnlUrunGrs.AutoSize = true;
            this.pnlUrunGrs.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnlUrunGrs.Location = new System.Drawing.Point(435, 21);
            this.pnlUrunGrs.Name = "pnlUrunGrs";
            this.pnlUrunGrs.Size = new System.Drawing.Size(249, 37);
            this.pnlUrunGrs.TabIndex = 0;
            this.pnlUrunGrs.Text = "ÜRÜN İŞLEMLERİ";
            // 
            // dgwUrun
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwUrun.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwUrun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUrun.Location = new System.Drawing.Point(61, 342);
            this.dgwUrun.Name = "dgwUrun";
            this.dgwUrun.RowTemplate.Height = 24;
            this.dgwUrun.Size = new System.Drawing.Size(1017, 282);
            this.dgwUrun.TabIndex = 11;
            // 
            // FormUrunEkleme
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 637);
            this.Controls.Add(this.grbUrunIslemleri);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgwUrun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "FormUrunEkleme";
            this.Text = "Ürün Ekleme";
            this.Load += new System.EventHandler(this.FormUrunEkleme_Load);
            this.grbUrunIslemleri.ResumeLayout(false);
            this.grbUrunIslemleri.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrun)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.DateTimePicker dtpAlimTarihi;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grbUrunIslemleri;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label pnlUrunGrs;
        private System.Windows.Forms.DataGridView dgwUrun;
    }
}