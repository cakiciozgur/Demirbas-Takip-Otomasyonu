namespace DemirbasOtomasyon.View
{
    partial class FormZimmetListele
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlUrunGrs = new System.Windows.Forms.Label();
            this.dgwZimmetListele = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwZimmetListele)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.pnlUrunGrs);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1147, 78);
            this.panel1.TabIndex = 22;
            // 
            // pnlUrunGrs
            // 
            this.pnlUrunGrs.AutoSize = true;
            this.pnlUrunGrs.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnlUrunGrs.Location = new System.Drawing.Point(483, 22);
            this.pnlUrunGrs.Name = "pnlUrunGrs";
            this.pnlUrunGrs.Size = new System.Drawing.Size(179, 37);
            this.pnlUrunGrs.TabIndex = 0;
            this.pnlUrunGrs.Text = "ZİMMETLER";
            // 
            // dgwZimmetListele
            // 
            this.dgwZimmetListele.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwZimmetListele.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwZimmetListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwZimmetListele.Location = new System.Drawing.Point(33, 98);
            this.dgwZimmetListele.Name = "dgwZimmetListele";
            this.dgwZimmetListele.RowTemplate.Height = 24;
            this.dgwZimmetListele.Size = new System.Drawing.Size(1082, 525);
            this.dgwZimmetListele.TabIndex = 20;
            // 
            // FormZimmetListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 637);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgwZimmetListele);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormZimmetListele";
            this.Text = "Zimmetler";
            this.Load += new System.EventHandler(this.FormZimmetListele_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwZimmetListele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label pnlUrunGrs;
        private System.Windows.Forms.DataGridView dgwZimmetListele;
    }
}