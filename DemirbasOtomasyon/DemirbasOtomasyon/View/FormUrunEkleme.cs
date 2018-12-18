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
using DemirbasOtomasyon.Model;
using DemirbasOtomasyon.Controller;
namespace DemirbasOtomasyon.View
{
    
    public partial class FormUrunEkleme : DevExpress.XtraEditors.XtraForm
    {
        //Urunler u = new Urunler();
        //DemirbasTakipEntities dt = new DemirbasTakipEntities();
        public FormUrunEkleme()
        {
            InitializeComponent();
        }

        private void FormUrunEkleme_Load(object sender, EventArgs e)
        {
            //u.fiyat = 5;
            //u.urunAd = "LAPTOP";
            //u.urunID = 1;
            //u.stokMiktari = 5;
            //u.stokDurum = false;
            //u.stokAltLimit = 1;
            //dt.Urunler.Add(u);
            //dt.SaveChanges();   
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUrunAd.Text) || string.IsNullOrEmpty(txtFiyat.Text) || string.IsNullOrEmpty(txtAdet.Text))
                {
                    throw new Exception("Ürün Bilgileri Boş Geçilemez !");
                }
                if (int.Parse(txtUrunAd.Text) <= 0)
                {
                    throw new Exception("Stok Değeri Sıfır veya Daha Düşük Değerler Olamaz !");
                }
               /* if (selectedDate > DateTime.Now)
                {
                    throw new ValidationException("Satın alma tarihi bugünden daha sonraki bir tarih olamaz!");
                }*/

                Urunler urun = new Urunler();
                urun.urunAd = txtUrunAd.Text;
                urun.fiyat = decimal.Parse(txtAdet.Text);
                urun.satınAlınmaTarihi = dtpAlimTarihi.Value.ToUniversalTime();

                UrunController.UrunEkle(urun);
                MessageBox.Show("Ürün Başarıyla Stok'a Eklendi !", "İşlem Başarılı !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Meydana Geldi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}