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
                    MessageBox.Show("Ürün Bilgileri Boş Geçilemez !");
                }
                try
                {
                    if (int.Parse(txtAdet.Text) <= 0)
                    {
                        MessageBox.Show("Adet Değeri Sıfır veya Daha Düşük Değerler Olamaz !");
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

                Urunler urun = new Urunler();
                urun.urunAd = txtUrunAd.Text;
                urun.fiyat = decimal.Parse(txtFiyat.Text);
                urun.stokMiktari=int.Parse(txtAdet.Text);
                urun.satınAlınmaTarihi = selectedDate;
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
    }
}