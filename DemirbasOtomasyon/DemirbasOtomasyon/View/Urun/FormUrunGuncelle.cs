using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using DemirbasOtomasyon.Controller;
using DemirbasOtomasyon.Model;
using DemirbasOtomasyon.View;

namespace DemirbasOtomasyon.View
{
    public partial class FormUrunGuncelle : DevExpress.XtraEditors.XtraForm
    {
       
        
        public FormUrunGuncelle()
        {
            InitializeComponent();
        }
        private void UrunListele()
        {
            DemirbasTakipEntitiess db = new DemirbasTakipEntitiess();
            var data = (from d in db.sp_UrunListele() select new { d.urunID,d.urunAd,d.stokMiktari,d.fiyat,d.satınAlınmaTarihi,d.stokDurum} );
            dgwUrunListele.DataSource = data.ToList();
            UrunGuncelleRenklendir();
        }
        private void FormUrunGuncelle_Load(object sender, EventArgs e)
        {
            this.Location = new Point(50, 100);
            UrunListele();
            UrunGuncelleRenklendir();
        }
        private void UrunGuncelleRenklendir()
        {
            try

            {
                for (int i = 0; i < dgwUrunListele.Rows.Count; i++)
                {
                    Application.DoEvents();
                    DataGridViewCellStyle rowColor = new DataGridViewCellStyle();
                    if (Convert.ToInt32(dgwUrunListele.Rows[i].Cells[2].Value) >= 6)
                    {
                        rowColor.BackColor = Color.LightGreen;
                        rowColor.ForeColor = Color.Black;
                    }
                    else if (Convert.ToInt32(dgwUrunListele.Rows[i].Cells[2].Value) >= 3 && Convert.ToInt32(dgwUrunListele.Rows[i].Cells[2].Value) <= 5)
                    {
                        rowColor.BackColor = Color.LightSkyBlue;
                        rowColor.ForeColor = Color.Black;
                    }
                    else if (Convert.ToInt32(dgwUrunListele.Rows[i].Cells[2].Value) < 3)
                    {
                        rowColor.BackColor = Color.LightCoral;
                        rowColor.ForeColor = Color.Black;
                    }
                    dgwUrunListele.Rows[i].DefaultCellStyle = rowColor;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex);
            }
        }

        private void DgwUrunListele_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtUrunID.Text = dgwUrunListele.CurrentRow.Cells[0].Value.ToString();
            txtUrunAd.Text = dgwUrunListele.CurrentRow.Cells[1].Value.ToString();
            txtAdet.Text = dgwUrunListele.CurrentRow.Cells[2].Value.ToString();
            txtFiyat.Text = dgwUrunListele.CurrentRow.Cells[3].Value.ToString();
            calendarControl1.EditValue = dgwUrunListele.CurrentRow.Cells[4].Value;
        }
        private void VeriGuncelle()
        {
            try
            {
                DateTime selectedDate = Convert.ToDateTime(calendarControl1.SelectionStart.ToShortDateString());
                if (string.IsNullOrEmpty(txtUrunAd.Text) || string.IsNullOrEmpty(txtFiyat.Text) || string.IsNullOrEmpty(txtAdet.Text))
                {
                    MessageBox.Show("Ürün Bilgileri Boş Geçilemez !");
                }
                try
                {
                    if (int.Parse(txtAdet.Text) <= 0)
                    {
                        MessageBox.Show("Stok Değeri Sıfır veya Daha Düşük Değerler Olamaz !");
                        txtAdet.Text = "";
                        txtAdet.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("Adet için geçerli bir değer girin");
                    txtAdet.Text = "";
                    txtAdet.Focus();
                }
                try
                {
                    if (decimal.Parse(txtFiyat.Text) <= 0)
                    {
                        MessageBox.Show("Fiyat Değeri Sıfır veya Daha Düşük Değerler Olamaz !");
                        txtFiyat.Text = "";
                        txtFiyat.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("Fiyat için geçerli bir değer girin");
                    txtFiyat.Text = "";
                    txtFiyat.Focus();
                }
                if (selectedDate > DateTime.Now)
                {
                    MessageBox.Show("Satın alma tarihi bugünden daha sonraki bir tarih olamaz!");
                }

                Urunler urun = new Urunler
                {
                    urunID = int.Parse(txtUrunID.Text),
                    urunAd = txtUrunAd.Text,
                    fiyat = decimal.Parse(txtFiyat.Text),
                    stokMiktari = int.Parse(txtAdet.Text),
                    satınAlınmaTarihi = selectedDate
                };
                UrunController.urunDuzenle(urun);
                MessageBox.Show("Ürün Başarıyla Düzenlendi !", "İşlem Başarılı !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UrunListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Meydana Geldi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            VeriGuncelle();
            UrunGuncelleRenklendir();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show(txtUrunAd.Text + " İsimli Ürün Silinsin Mi ?", "Karar ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                UrunController.UrunSil(int.Parse(txtUrunID.Text));
                MessageBox.Show(txtUrunAd.Text + " İsimli Ürün Silindi !", "İşlem Başarılı !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Thread.Sleep(500);
                UrunListele();
            }
        }

     
    }
}