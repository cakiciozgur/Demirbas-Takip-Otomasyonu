using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        public FormUrunEkleme()
        {
            InitializeComponent();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime selectedDate = Convert.ToDateTime(calendarControl1.SelectionStart.ToShortDateString());
                if (string.IsNullOrEmpty(txtUrunAd.Text) || string.IsNullOrEmpty(txtFiyat.Text) || string.IsNullOrEmpty(txtAdet.Text))
                {
                    throw new ValidationException("Ürün Bilgileri Boş Geçilemez !");
                }
                if (int.Parse(txtAdet.Text) <= 0)
                {
                    throw new ValidationException("Adet Değeri Sıfır veya Daha Düşük Değerler Olamaz !");
                }

                if (decimal.Parse(txtFiyat.Text) <= 0)
                {
                    throw new ValidationException("Fiyat Değeri Sıfır veya Daha Düşük Değerler Olamaz !");
                }
                if (selectedDate > DateTime.Now)
                {
                    throw new ValidationException("Satın alma tarihi bugünden daha sonraki bir tarih olamaz!");
                }

                Urunler urun = new Urunler
                {
                    urunAd = txtUrunAd.Text,
                    fiyat = decimal.Parse(txtFiyat.Text),
                    stokMiktari = int.Parse(txtAdet.Text),
                    satınAlınmaTarihi = selectedDate
                };
                UrunController.UrunEkle(urun);
                    MessageBox.Show("Ürün Başarıyla Stok'a Eklendi !", "İşlem Başarılı !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Meydana Geldi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormUrunEkleme_Load(object sender, EventArgs e)
        {
            this.Location = new Point(50, 100);
        }

        private void txtAdet_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtUrunAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsPunctuation(e.KeyChar);
        }
    }
}