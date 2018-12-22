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
    public partial class FormUrunListele : DevExpress.XtraEditors.XtraForm
    {
        public FormUrunListele()
        {
            InitializeComponent();
        }
        private void UrunListele()
        {
            DemirbasTakipEntitiess db = new DemirbasTakipEntitiess();
            var data = db.sp_UrunListele(); 
            dgwUrunListesi.DataSource = data.ToList();
            UrunRenklendir();
        }

        private void FormUrunListele_Load(object sender, EventArgs e)
        {
            UrunListele();
        }
        private void UrunRenklendir()
        {
            try

            {
                for (int i = 0; i < dgwUrunListesi.Rows.Count; i++)
                {
                    Application.DoEvents();
                    DataGridViewCellStyle rowColor = new DataGridViewCellStyle();
                    if (Convert.ToInt32(dgwUrunListesi.Rows[i].Cells[2].Value) >= 6)
                    {
                        rowColor.BackColor = Color.LightGreen;
                        rowColor.ForeColor = Color.Black;
                    }
                    else if (Convert.ToInt32(dgwUrunListesi.Rows[i].Cells[2].Value) >= 3 && Convert.ToInt32(dgwUrunListesi.Rows[i].Cells[2].Value) <= 5)
                    {
                        rowColor.BackColor = Color.LightSkyBlue;
                        rowColor.ForeColor = Color.Black;
                    }
                    else if (Convert.ToInt32(dgwUrunListesi.Rows[i].Cells[2].Value) < 3)
                    {
                        rowColor.BackColor = Color.LightCoral;
                        rowColor.ForeColor = Color.Black;
                    }
                    dgwUrunListesi.Rows[i].DefaultCellStyle = rowColor;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex);
            }
        }
    }
}