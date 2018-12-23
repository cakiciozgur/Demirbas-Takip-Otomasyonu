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
        
        private void BtnUrunBul_Click(object sender, EventArgs e)
        {
            DemirbasTakipEntitiess db = new DemirbasTakipEntitiess();
            var data = db.sp_UrunBul(int.Parse(txtUrunID.Text));
            dgwUrunListesi.DataSource = data.ToList();
            UrunRenklendir();
        }

        private void BtnTumUrunler_Click(object sender, EventArgs e)
        {
            UrunListele();
        }
        Font Baslik = new Font("Corbel", 18, FontStyle.Bold);
        Font Govde = new Font("Corbel", 12);
        SolidBrush sb = new SolidBrush(Color.Black);

        private void pdYazici_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int i;
            decimal ToplamStok = 0,ToplamGider=0;
            StringFormat Format = new StringFormat();
            Format.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("ÜRÜNLER RAPORU", Baslik, sb, 310, 200);
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------------------------------------", Govde, sb, 50, 230);
            e.Graphics.DrawString("ÜRÜN ID         ÜRÜN ADI            STOK MİKTARI                 FİYAT               SATIN ALINMA TARİHİ         STOK DURUMU          ", Govde, sb, 50, 300);
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------------------------------------", Govde, sb, 50, 320);
            for (i = 0; i < dgwUrunListesi.Rows.Count; i++)
            {
                e.Graphics.DrawString(dgwUrunListesi.Rows[i].Cells[0].Value.ToString(), Govde, sb, 70, 340 + (i * 30));
                e.Graphics.DrawString(dgwUrunListesi.Rows[i].Cells[1].Value.ToString(), Govde, sb, 150, 340 + (i * 30));
                e.Graphics.DrawString(dgwUrunListesi.Rows[i].Cells[2].Value.ToString(), Govde, sb, 300, 340 + (i * 30));
                e.Graphics.DrawString(dgwUrunListesi.Rows[i].Cells[3].Value.ToString(), Govde, sb, 410, 340 + (i * 30));
                e.Graphics.DrawString(dgwUrunListesi.Rows[i].Cells[4].Value.ToString(), Govde, sb, 525, 340 + (i * 30));
                e.Graphics.DrawString(dgwUrunListesi.Rows[i].Cells[5].Value.ToString(), Govde, sb, 750, 340 + (i * 30));
                ToplamStok+=Convert.ToDecimal(dgwUrunListesi.Rows[i].Cells[2].Value);
                ToplamGider+= Convert.ToDecimal(dgwUrunListesi.Rows[i].Cells[3].Value);
            }
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------------------------------------", Govde, sb, 50, 350 + (i * 30));
            e.Graphics.DrawString("STOKTAKİ TOPLAM ÜRÜN :  "+ToplamStok, Govde, sb, 525, 375 + (i * 30));
            e.Graphics.DrawString("TOPLAM ÜRÜN GİDERLERİ : "+ToplamGider, Govde, sb, 525, 395 + (i * 30));
            e.Graphics.DrawString("ÇAKAN LTD.ŞTİ - 2018", Govde, sb, 600, 1000);
        }

        private void BtnRapor_Click(object sender, EventArgs e)
        {
            ppdDialog.ShowDialog();
        }
    }
}