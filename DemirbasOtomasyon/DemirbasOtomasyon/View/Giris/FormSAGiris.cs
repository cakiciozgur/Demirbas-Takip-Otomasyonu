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
    public partial class FormSAGiris : DevExpress.XtraEditors.XtraForm
    {
        public FormSAGiris()
        {
            InitializeComponent();
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            FormKullaniciSecim fks = new FormKullaniciSecim();
            fks.Show();
            this.Hide();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                Kullanıcılar kullanici = new Kullanıcılar
                {
                    kullaniciAdi = txtKullaniciAdi.Text,
                    kullaniciSifre = int.Parse(txtSifre.Text)
                };
                if (string.IsNullOrEmpty(kullanici.kullaniciAdi) || string.IsNullOrEmpty(kullanici.kullaniciSifre.ToString()))
                {
                    throw new Exception("Kullanıcı Adı ve Şifre Boş Geçilemez !");
                }
                var result = KullaniciController.SatinAlmaYetkilisiGiris(kullanici);
                FormKullaniciSecim._session = eRoles.SatinAlmaBirimi.ToString();
                FormKullaniciSecim._userIdSession = result.kullaniciID;
                FormSatınAlmaBirimi sab = new FormSatınAlmaBirimi();
                sab.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Meydana Geldi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormSAGiris_Load(object sender, EventArgs e)
        {
            this.Location = new Point(200, 150);
        }
    }
}