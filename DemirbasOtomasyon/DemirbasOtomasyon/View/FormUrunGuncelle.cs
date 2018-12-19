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
        private void urunListele()
        {
            DemirbasTakipEntitiess db = new DemirbasTakipEntitiess();
            var data = (from d in db.Urunler select new { d.urunID,d.urunAd,d.stokMiktari,d.fiyat,d.satınAlınmaTarihi,d.stokDurum});
            dgwUrunListele.DataSource = data.ToList();
        }
        

        private void FormUrunGuncelle_Load(object sender, EventArgs e)
        {
            urunListele();
        }

        private void dgwUrunListele_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtUrunID.Text = dgwUrunListele.CurrentRow.Cells[0].Value.ToString();
            txtUrunAd.Text = dgwUrunListele.CurrentRow.Cells[1].Value.ToString();
            txtAdet.Text = dgwUrunListele.CurrentRow.Cells[2].Value.ToString();
            txtFiyat.Text = dgwUrunListele.CurrentRow.Cells[3].Value.ToString();
            calendarControl1.EditValue = dgwUrunListele.CurrentRow.Cells[4].Value;
        }
        private void veriGuncelle()
        {
            try
            {
                DateTime selectedDate = Convert.ToDateTime(calendarControl1.SelectionStart.ToShortDateString());
                if (string.IsNullOrEmpty(txtUrunAd.Text) || string.IsNullOrEmpty(txtFiyat.Text) || string.IsNullOrEmpty(txtAdet.Text))
                {
                    throw new Exception("Ürün Bilgileri Boş Geçilemez !");
                }
                if (int.Parse(txtAdet.Text) <= 0)
                {
                    throw new Exception("Stok Değeri Sıfır veya Daha Düşük Değerler Olamaz !");
                }
                if (selectedDate > DateTime.Now)
                {
                    throw new Exception("Satın alma tarihi bugünden daha sonraki bir tarih olamaz!");
                }

                Urunler urun = new Urunler();
                urun.urunAd = txtUrunAd.Text;
                urun.fiyat = decimal.Parse(txtFiyat.Text);
                urun.stokMiktari = int.Parse(txtAdet.Text);
                urun.satınAlınmaTarihi = selectedDate;
                urun.urunID = int.Parse(txtUrunID.Text);
                UrunController.urunDuzenle(urun);
                MessageBox.Show("Ürün Başarıyla Düzenlendi !", "İşlem Başarılı !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                urunListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Meydana Geldi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            veriGuncelle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show(txtUrunAd.Text + " İsimli Ürün Silinsin Mi ?", "Karar ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                UrunController.UrunSil(int.Parse(txtUrunID.Text));
                MessageBox.Show(txtUrunAd.Text + " İsimli Ürün Silindi !", "İşlem Başarılı !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Thread.Sleep(500);
                urunListele();
            }
        }

     
    }
}