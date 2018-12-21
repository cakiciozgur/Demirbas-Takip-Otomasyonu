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
        private void PersonelRenklendir()
        {
            try

            {
                for (int i = 0; i < dgwPersonelListele.Rows.Count; i++)
                {
                    Application.DoEvents();
                    DataGridViewCellStyle rowColor = new DataGridViewCellStyle();
                    if (Convert.ToInt32(dgwPersonelListele.Rows[i].Cells[2].Value) >= 6)
                    {
                        rowColor.BackColor = Color.LightGreen;
                        rowColor.ForeColor = Color.Black;
                    }
                    else if (Convert.ToInt32(dgwPersonelListele.Rows[i].Cells[2].Value) >= 3 && Convert.ToInt32(dgwPersonelListele.Rows[i].Cells[2].Value) <= 5)
                    {
                        rowColor.BackColor = Color.LightSkyBlue;
                        rowColor.ForeColor = Color.Black;
                    }
                    else if (Convert.ToInt32(dgwPersonelListele.Rows[i].Cells[2].Value) < 3)
                    {
                        rowColor.BackColor = Color.LightCoral;
                        rowColor.ForeColor = Color.Black;
                    }
                    dgwPersonelListele.Rows[i].DefaultCellStyle = rowColor;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex);
            }
        }
        private void PersonelListele()
        {
            DemirbasTakipEntitiess db = new DemirbasTakipEntitiess();
            var data = db.sp_PersonelListele2();
            dgwPersonelListele.DataSource = data.ToList();
        }

        private void FormPersonelGuncelleme_Load(object sender, EventArgs e)
        {
            Araclar.comboBoxDepartmanGetir(cmbDepartmanGuncelle);
            cmbDepartmanGuncelle.SelectedItem = null;
            cmbDepartmanGuncelle.SelectedText = "Departman Seçiniz...";
            PersonelListele();
        }

        private void btnPersonelGuncelle_Click(object sender, EventArgs e)
        {
            PersonelGuncelle();
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

                Personeller personel = new Personeller
                {
                    personelID = int.Parse(txtPersonelID.Text),
                    adi = txtAdi.Text,
                    soyadi = txtSoyadi.Text,
                    cepTelefonu = txtTelefon.Text,
                    departmanID = Convert.ToInt32(cmbDepartmanGuncelle.SelectedValue),
                    iseGirisTarihi = selectedDate                   
                };
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
            cmbDepartmanGuncelle.Text = dgwPersonelListele.CurrentRow.Cells[4].Value.ToString();
            calendarControl.EditValue = dgwPersonelListele.CurrentRow.Cells[5].Value;
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