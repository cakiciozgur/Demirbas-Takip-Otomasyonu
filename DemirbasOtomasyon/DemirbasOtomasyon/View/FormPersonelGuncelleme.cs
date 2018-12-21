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
    public partial class FormPersonelGuncelleme : DevExpress.XtraEditors.XtraForm
    {
        public FormPersonelGuncelleme()
        {
            InitializeComponent();
        }
        private void PersonelListele()
        {
            DemirbasTakipEntitiess db = new DemirbasTakipEntitiess();
            var data = db.sp_PersonelListele2();
            dgwPersonelListele.DataSource = data.ToList();
        }

        private void FormPersonelGuncelleme_Load(object sender, EventArgs e)
        {
            PersonelListele();
        }

        private void btnPersonelGuncelle_Click(object sender, EventArgs e)
        {

        }
        private void PersonelGuncelle()
        {
            try
            {
                DateTime selectedDate = Convert.ToDateTime(calendarControl.SelectionStart.ToShortDateString());
                if (string.IsNullOrEmpty(txtAdi.Text) || string.IsNullOrEmpty(txtSoyadi.Text) || string.IsNullOrEmpty(txtTelefon.Text))
                {
                    throw new Exception("Personel Bilgileri Boş Geçilemez !");
                }
                if (selectedDate > DateTime.Now)
                {
                    throw new Exception("İşe giriş  tarihi bugünden daha sonraki bir tarih olamaz!");
                }

                Personeller personel = new Personeller();
                personel.personelID = int.Parse(txtPersonelID.Text);
                personel.adi = txtAdi.Text;
                personel.soyadi = txtSoyadi.Text;
                personel.cepTelefonu = txtTelefon.Text;
                personel.iseGirisTarihi = selectedDate;
                PersonelController.PersonelGuncelle(personel);
                MessageBox.Show("Ürün Başarıyla Düzenlendi !", "İşlem Başarılı !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PersonelListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Meydana Geldi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgwPersonelListele_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtPersonelID.Text = dgwPersonelListele.CurrentRow.Cells[0].Value.ToString();
            txtAdi.Text = dgwPersonelListele.CurrentRow.Cells[1].Value.ToString();
            txtSoyadi.Text = dgwPersonelListele.CurrentRow.Cells[2].Value.ToString();
            txtTelefon.Text = dgwPersonelListele.CurrentRow.Cells[3].Value.ToString();
            calendarControl.EditValue = dgwPersonelListele.CurrentRow.Cells[4].Value;
        }

        private void btnPersonelSil_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show(txtAdi.Text + " İsimli Personel Silinsin Mi ?", "Karar ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                PersonelController.PersonelSil(int.Parse(txtPersonelID.Text));
                MessageBox.Show(txtAdi.Text +" "+ txtSoyadi.Text + " İsimli Personel Silindi !", "İşlem Başarılı !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PersonelListele();
            }
        }
    }
}