using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DemirbasOtomasyon.Controller;
using DemirbasOtomasyon.Model;


namespace DemirbasOtomasyon.View
{
    public partial class FormZimmetEkle : DevExpress.XtraEditors.XtraForm
    {
        public FormZimmetEkle()
        {
            InitializeComponent();
        }
        //string adet = "";
        private void FormZimmetEkle_Load(object sender, EventArgs e)
        {
            Araclar.comboBoxKullaniciGetir(cmbKullanici);
            Araclar.comboBoxPersonelGetir(cmbPersonel);
            urunListele();
            cmbPersonel.SelectedItem = null;
            cmbPersonel.SelectedText = "Personel Seçiniz...";
            cmbKullanici.SelectedItem = null;
            cmbKullanici.SelectedText = "Kullanıcı Seçiniz...";
        }
        private void urunListele()
        {
            DemirbasTakipEntitiess db = new DemirbasTakipEntitiess();
            var data = (from d in db.sp_UrunListele() select new { d.urunID, d.urunAd, d.stokMiktari, d.fiyat, d.satınAlınmaTarihi, d.stokDurum });
            dgwZimmetListesi.DataSource = data.ToList();
        }

        private void dgwZimmetListesi_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtUrunID.Text = dgwZimmetListesi.CurrentRow.Cells[0].Value.ToString();
            txtUrunAd.Text = dgwZimmetListesi.CurrentRow.Cells[1].Value.ToString();
            //adet = dgwZimmetListesi.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime selectedDate = Convert.ToDateTime(calendarControl1.SelectionStart.ToShortDateString());
                if (string.IsNullOrEmpty(cmbKullanici.SelectedValue.ToString()))
                {
                    throw new Exception("Lütfen Kullanıcı Bilgilerini Kontrol Ediniz !");

                }
                if (string.IsNullOrEmpty(cmbKullanici.Text))
                {
                    throw new Exception("Lütfen Kullanıcı Seçiniz !");
                }
                if (string.IsNullOrEmpty(txtAdet.Text) || short.Parse(txtAdet.Text) == 0 || short.Parse(txtAdet.Text) < 0)
                {
                    throw new Exception("Lütfen Adet Bilgisini Kontrol Ediniz !");
                }
                /*if (short.Parse(txtAdet.Text) > int.Parse(adet))
                {
                    throw new Exception("Stok Miktarındakinden Fazla Ürün Zimmete Eklenemez ! !");
                }*/
                if (selectedDate > DateTime.Now)
                {
                    throw new Exception("Satın alma tarihi bugünden daha sonraki bir tarih olamaz!");
                }

                Zimmetler zimmet = new Zimmetler();
                zimmet.urunID = int.Parse(txtUrunID.Text);
                zimmet.zimmetAdet = int.Parse(txtAdet.Text);
                zimmet.personelID = Convert.ToInt32(cmbPersonel.SelectedValue);
                zimmet.kullaniciID = Convert.ToInt32(cmbKullanici.SelectedValue);
                zimmet.zimmetTarihi = selectedDate;
                  
                ZimmetController.ZimmetEkle(zimmet);
                MessageBox.Show("Zimmet Başarıyla Eklendi !", "Zimmet Eklendi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                urunListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Dikkat !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

       
    }
}