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
        private void GuncelleZimmetUrunListele()
        {
            DemirbasTakipEntitiess db = new DemirbasTakipEntitiess();
            var data = from z in db.sp_ZimmetListele2() select new { z.Zimmet_ID,z.Zimmet_Adet,z.Personel_Adı,z.Kullanıcı_Adı,z.Zimmet_Tarihi};
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
                    if (Convert.ToInt32(dgwZimmetGuncellemeListele.Rows[i].Cells[1].Value) >= 6)
                    {
                        rowColor.BackColor = Color.LightGreen;
                        rowColor.ForeColor = Color.Black;
                    }
                    else if (Convert.ToInt32(dgwZimmetGuncellemeListele.Rows[i].Cells[1].Value) >= 3 && Convert.ToInt32(dgwZimmetGuncellemeListele.Rows[i].Cells[1].Value) <= 5)
                    {
                        rowColor.BackColor = Color.LightSkyBlue;
                        rowColor.ForeColor = Color.Black;
                    }
                    else if (Convert.ToInt32(dgwZimmetGuncellemeListele.Rows[i].Cells[1].Value) < 3)
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
            Araclar.ComboBoxKullaniciGetir(cmbKullaniciGuncelle);
            Araclar.ComboBoxPersonelGetir(cmbPersonelGuncelle);
            cmbPersonelGuncelle.SelectedItem = null;
            cmbPersonelGuncelle.SelectedText = "Personel Seçiniz...";
            cmbKullaniciGuncelle.SelectedItem = null;
            cmbKullaniciGuncelle.SelectedText = "Kullanıcı Seçiniz...";
            GuncelleZimmetUrunListele();
        }
        private void ZimmetGuncelle()
        {
            try
            {
                DateTime selectedDate = Convert.ToDateTime(calendarControl1.SelectionStart.ToShortDateString());
                if (string.IsNullOrEmpty(txtAdet.Text) || string.IsNullOrEmpty(txtAdet.Text))
                {
                    throw new Exception("Zimmet Bilgileri Boş Geçilemez !");
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
                    throw new Exception("Zimmet tarihi bugünden daha sonraki bir tarih olamaz!");
                }

                Zimmetler zimmet = new Zimmetler
                {
                    zimmetID = int.Parse(txtZimmetID.Text),
                    zimmetAdet = int.Parse(txtAdet.Text),
                    zimmetTarihi = selectedDate,
                    personelID = Convert.ToInt32(cmbPersonelGuncelle.SelectedValue),
                    kullaniciID = Convert.ToInt32(cmbKullaniciGuncelle.SelectedValue)
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
            txtZimmetID.Text = dgwZimmetGuncellemeListele.CurrentRow.Cells[0].Value.ToString();
            txtAdet.Text = dgwZimmetGuncellemeListele.CurrentRow.Cells[1].Value.ToString();
            cmbPersonelGuncelle.Text = dgwZimmetGuncellemeListele.CurrentRow.Cells[2].Value.ToString();
            cmbKullaniciGuncelle.Text = dgwZimmetGuncellemeListele.CurrentRow.Cells[3].Value.ToString();
            calendarControl1.EditValue = dgwZimmetGuncellemeListele.CurrentRow.Cells[4].Value;
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            ZimmetGuncelle();
            GuncelleZimmetUrunListele();
        }

        private void BtnKaldır_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show(txtZimmetID.Text + " ID'li Zimmet Silinsin Mi ?", "Karar ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                ZimmetController.ZimmetSil(int.Parse(txtZimmetID.Text));
                MessageBox.Show(txtZimmetID.Text + " ID'li Zimmet Silindi !", "İşlem Başarılı !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GuncelleZimmetUrunListele();
            }
            AtikController.AtikEkle(int.Parse(txtZimmetID.Text));
        }
    }
}