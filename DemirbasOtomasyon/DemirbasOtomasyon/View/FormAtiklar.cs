using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DemirbasOtomasyon.Controller;
using DemirbasOtomasyon.Model;

namespace DemirbasOtomasyon.View
{
    public partial class FormAtiklar : DevExpress.XtraEditors.XtraForm
    {
        public FormAtiklar()
        {
            InitializeComponent();
        }
        private void AtikRenklendir()
        {
            try
            {
                for (int i = 0; i < dgwAtikListele.Rows.Count; i++)
                {
                    Application.DoEvents();
                    DataGridViewCellStyle rowColor = new DataGridViewCellStyle();
                    if (Convert.ToInt32(dgwAtikListele.Rows[i].Cells[0].Value) >= 1)
                    {
                        rowColor.BackColor = Color.LightSkyBlue;
                        rowColor.ForeColor = Color.Black;
                    }
                    dgwAtikListele.Rows[i].DefaultCellStyle = rowColor;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex);
            }
        }

        private void FormAtiklar_Load(object sender, EventArgs e)
        {
            this.Location = new Point(50, 100);
            DemirbasTakipEntitiess db = new DemirbasTakipEntitiess();
            var data = db.sp_AtikListeleme();
            dgwAtikListele.DataSource = data.ToList();
            AtikRenklendir();
        }
    }
}