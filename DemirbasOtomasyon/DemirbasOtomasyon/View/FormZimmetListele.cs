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
    public partial class FormZimmetListele : DevExpress.XtraEditors.XtraForm
    {
        public FormZimmetListele()
        {
            InitializeComponent();
        }
        private void UrunListele()
        {
            DemirbasTakipEntitiess db = new DemirbasTakipEntitiess();
            var data = db.sp_ZimmetListele2();
            dgwZimmetListele.DataSource = data.ToList();
            ZimmetRenklendir();
        }
        private void ZimmetRenklendir()
        {
            try
            {
                for (int i = 0; i < dgwZimmetListele.Rows.Count; i++)
                {
                    Application.DoEvents();
                    DataGridViewCellStyle rowColor = new DataGridViewCellStyle();
                    if ((dgwZimmetListele.Rows[i].Cells[5].Value.ToString()) == "YAZILIM")
                    {
                        rowColor.BackColor = Color.LightSteelBlue;
                        rowColor.ForeColor = Color.Black;
                    }
                    else if ((dgwZimmetListele.Rows[i].Cells[5].Value.ToString()) == "TEKNIK SERVIS")
                    {
                        rowColor.BackColor = Color.LightCoral;
                        rowColor.ForeColor = Color.Black;
                    }
                    else if ((dgwZimmetListele.Rows[i].Cells[5].Value.ToString()) == "MUHASEBE")
                    {
                        rowColor.BackColor = Color.LightCyan;
                        rowColor.ForeColor = Color.Black;
                    }
                    dgwZimmetListele.Rows[i].DefaultCellStyle = rowColor;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex);
            }
        }
        private void FormZimmetListele_Load(object sender, EventArgs e)
        {
            UrunListele();
        }
    }
}