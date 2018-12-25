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
    public partial class FormPersonelEkleme : DevExpress.XtraEditors.XtraForm
    {
        public FormPersonelEkleme()
        {
            InitializeComponent();
        }

        private void FormPersonelEkleme_Load(object sender, EventArgs e)
        {
            this.Location = new Point(50, 100);
            Araclar.ComboBoxDepartmanGetir(cmbDepartmanSec);
            cmbDepartmanSec.SelectedItem = null;
            cmbDepartmanSec.SelectedText = "Departman Seçiniz...";
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime selectedDate = Convert.ToDateTime(calendarControl2.SelectionStart.ToShortDateString());
                if (string.IsNullOrEmpty(cmbDepartmanSec.SelectedValue.ToString()))
                {
                    MessageBox.Show("Lütfen Departman Bilgilerini Kontrol Ediniz !");

                }
                if (string.IsNullOrEmpty(cmbDepartmanSec.Text))
                {
                    MessageBox.Show("Lütfen Departman Seçiniz !");
                }
                if (string.IsNullOrEmpty(txtPersonelAd.Text))
                {
                    MessageBox.Show("Lütfen Ad Bilgisini Kontrol Ediniz !");
                }
                if (string.IsNullOrEmpty(txtPersonelSoyad.Text))
                {
                    MessageBox.Show("Lütfen Soyad Bilgisini Kontrol Ediniz !");
                }
                if (selectedDate > DateTime.Now)
                {
                    MessageBox.Show("İşe giriş tarihi bugünden daha sonraki bir tarih olamaz!");
                }

                Personeller personel = new Personeller
                {
                    adi = txtPersonelAd.Text,
                    soyadi = txtPersonelSoyad.Text,
                    cepTelefonu = txtCepTelefonu.Text,
                    departmanID= Convert.ToInt32(cmbDepartmanSec.SelectedValue),
                    iseGirisTarihi = selectedDate
                };

                PersonelController.PersonelEkle(personel);
                MessageBox.Show("Personel Başarıyla Eklendi !", "Personel Eklendi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Dikkat !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtPersonelAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void txtPersonelSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void txtCepTelefonu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}