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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAtiklar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlUrunGrs = new System.Windows.Forms.Label();
            this.dgwAtikListele = new System.Windows.Forms.DataGridView();
            this.ppdDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.pdYazici = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAtikListele)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.pnlUrunGrs);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1147, 78);
            this.panel1.TabIndex = 25;
            // 
            // pnlUrunGrs
            // 
            this.pnlUrunGrs.AutoSize = true;
            this.pnlUrunGrs.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnlUrunGrs.Location = new System.Drawing.Point(418, 25);
            this.pnlUrunGrs.Name = "pnlUrunGrs";
            this.pnlUrunGrs.Size = new System.Drawing.Size(240, 37);
            this.pnlUrunGrs.TabIndex = 0;
            this.pnlUrunGrs.Text = "ATİKLAR LİSTESİ";
            // 
            // dgwAtikListele
            // 
            this.dgwAtikListele.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwAtikListele.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwAtikListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAtikListele.Location = new System.Drawing.Point(34, 105);
            this.dgwAtikListele.Name = "dgwAtikListele";
            this.dgwAtikListele.ReadOnly = true;
            this.dgwAtikListele.RowTemplate.Height = 24;
            this.dgwAtikListele.Size = new System.Drawing.Size(1082, 518);
            this.dgwAtikListele.TabIndex = 24;
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
            this.ClientSize = new System.Drawing.Size(1143, 638);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgwAtikListele);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormAtiklar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAtikListele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label pnlUrunGrs;
        private System.Windows.Forms.DataGridView dgwAtikListele;
        private System.Windows.Forms.PrintPreviewDialog ppdDialog;
        private System.Drawing.Printing.PrintDocument pdYazici;
    }
}