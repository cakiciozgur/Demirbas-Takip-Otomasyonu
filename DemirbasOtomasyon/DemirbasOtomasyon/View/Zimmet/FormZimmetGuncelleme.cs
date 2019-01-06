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
    public partial class FormZimmetGuncelleme : DevExpress.XtraEditors.XtraForm
    {
        public FormZimmetGuncelleme()
        {
            InitializeComponent();
        }
        int _zimmetID = 0;
        int _urunID = 0;
        int _stokAdet = 0;
        private void GuncelleZimmetUrunListele()
        {
            DemirbasTakipEntitiess db = new DemirbasTakipEntitiess();
            var data = db.sp_ZimmetListele2();
            dgwZimmetGuncellemeListele.DataSource = data.ToList();
            ZimmetGuncelleRenklendir();
        }
        private void ZimmetGuncelleRenklendir()
        {
            try

            {
                for (int i = 0; i < dgwZimmetGuncellemeListele.Rows.Count; i++)
                {
                    Application.DoEvents();
                    DataGridViewCellStyle rowColor = new DataGridViewCellStyle();
                    if (Convert.ToInt32(dgwZimmetGuncellemeListele.Rows[i].Cells[2].Value) >= 6)
                    {
                        rowColor.BackColor = Color.LightGreen;
                        rowColor.ForeColor = Color.Black;
                    }
                    else if (Convert.ToInt32(dgwZimmetGuncellemeListele.Rows[i].Cells[2].Value) >= 3 && Convert.ToInt32(dgwZimmetGuncellemeListele.Rows[i].Cells[2].Value) <= 5)
                    {
                        rowColor.BackColor = Color.LightSkyBlue;
                        rowColor.ForeColor = Color.Black;
                    }
                    else if (Convert.ToInt32(dgwZimmetGuncellemeListele.Rows[i].Cells[2].Value) < 3)
                    {
                        rowColor.BackColor = Color.LightCoral;
                        rowColor.ForeColor = Color.Black;
                    }
                    dgwZimmetGuncellemeListele.Rows[i].DefaultCellStyle = rowColor;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex);
            }
        }
            
          private void FormZimmetGuncelleme_Load(object sender, EventArgs e)
        {
            this.Location = new Point(50, 100);
            Araclar.ComboBoxPersonelGetir(cmbPersonelGuncelle);
            cmbPersonelGuncelle.SelectedItem = null;
            cmbPersonelGuncelle.SelectedText = "Personel Seçiniz...";
            GuncelleZimmetUrunListele();
        }
        private void ZimmetGuncelle()
        {
            try
            {
                DateTime selectedDate = Convert.ToDateTime(calendarControl1.SelectionStart.ToShortDateString());
                if (string.IsNullOrEmpty(txtAdet.Text) || string.IsNullOrEmpty(txtAdet.Text))
                {
                    MessageBox.Show("Zimmet Bilgileri Boş Geçilemez !");
                }
                try
                {
                    if ((Convert.ToInt32(txtAdet.Text) <=0))
                    {
                        MessageBox.Show("Adet Değeri Sıfır veya Daha Düşük Değerler Olamaz !");
                        txtAdet.Text = "";
                        txtAdet.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("Geçerli bir değer girin");
                    txtAdet.Text = "";
                    txtAdet.Focus();
                }
                if (selectedDate > DateTime.Now)
                {
                    MessageBox.Show("Zimmet tarihi bugünden daha sonraki bir tarih olamaz!");
                }

                DemirbasTakipEntitiess db = new DemirbasTakipEntitiess();
                var urunler = db.sp_UrunListele();

                foreach (var urun in urunler)
                {
                    if (urun.urunID == _urunID)
                    {
                        _stokAdet = Convert.ToInt32(urun.stokMiktari);
                    }
                }
                if ((Convert.ToInt32(txtAdet.Text) > _stokAdet + (Convert.ToInt32(txtAdet.Text))))
                {
                    MessageBox.Show("Stok Yetersiz!");
                    txtAdet.Text = "";
                    txtAdet.Focus();
                }
                Zimmetler zimmet = new Zimmetler
                {
                    zimmetID = _zimmetID,
                    urunID = _urunID,
                    zimmetAdet = int.Parse(txtAdet.Text),
                    zimmetTarihi = selectedDate,
                    personelID = Convert.ToInt32(cmbPersonelGuncelle.SelectedValue),
                    kullaniciID = FormKullaniciSecim._userIdSession
                };
                ZimmetController.ZimmetGuncelle(zimmet);
                MessageBox.Show("Zimmet Başarıyla Düzenlendi !", "İşlem Başarılı !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Meydana Geldi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DgwZimmetGuncellemeListele_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _urunID = Convert.ToInt32(dgwZimmetGuncellemeListele.CurrentRow.Cells[0].Value);
            _zimmetID = Convert.ToInt32(dgwZimmetGuncellemeListele.CurrentRow.Cells[1].Value);
            txtAdet.Text = dgwZimmetGuncellemeListele.CurrentRow.Cells[2].Value.ToString();
            cmbPersonelGuncelle.Text = dgwZimmetGuncellemeListele.CurrentRow.Cells[4].Value.ToString();
            calendarControl1.EditValue = dgwZimmetGuncellemeListele.CurrentRow.Cells[6].Value;
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            ZimmetGuncelle();
            GuncelleZimmetUrunListele();
        }

        private void BtnKaldır_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show(_zimmetID + " ID'li Zimmet Silinsin Mi ?", "Karar ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                ZimmetController.ZimmetSil(_zimmetID);
                MessageBox.Show(_zimmetID + " ID'li Zimmet Silindi !", "İşlem Başarılı !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GuncelleZimmetUrunListele();
            }
            AtikController.AtikEkle(_zimmetID);
        }

        private void txtAdet_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}