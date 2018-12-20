namespace DemirbasOtomasyon.View
{
    partial class FormPersonelListele
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
            this.dgwPersonelListele = new System.Windows.Forms.DataGridView();
            this.pnlUrunGrs = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPersonelListele)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwPersonelListele
            // 
            this.dgwPersonelListele.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwPersonelListele.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwPersonelListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPersonelListele.Location = new System.Drawing.Point(32, 98);
            this.dgwPersonelListele.Name = "dgwPersonelListele";
            this.dgwPersonelListele.RowTemplate.Height = 24;
            this.dgwPersonelListele.Size = new System.Drawing.Size(1082, 525);
            this.dgwPersonelListele.TabIndex = 23;
            // 
            // pnlUrunGrs
            // 
            this.pnlUrunGrs.AutoSize = true;
            this.pnlUrunGrs.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnlUrunGrs.Location = new System.Drawing.Point(443, 23);
            this.pnlUrunGrs.Name = "pnlUrunGrs";
            this.pnlUrunGrs.Size = new System.Drawing.Size(217, 37);
            this.pnlUrunGrs.TabIndex = 0;
            this.pnlUrunGrs.Text = "PERSONELLER";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.pnlUrunGrs);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1147, 78);
            this.panel1.TabIndex = 24;
            // 
            // FormPersonelListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 637);
            this.Controls.Add(this.dgwPersonelListele);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormPersonelListele";
            this.Text = "Personel Listele";
            ((System.ComponentModel.ISupportInitialize)(this.dgwPersonelListele)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwPersonelListele;
        private System.Windows.Forms.Label pnlUrunGrs;
        private System.Windows.Forms.Panel panel1;
    }
}