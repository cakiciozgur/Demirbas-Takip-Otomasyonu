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
        private void ZimmetEkleRenklendir()
        {
            try

            {
                for (int i = 0; i < dgwZimmetListesi.Rows.Count; i++)         
                {
                    Application.DoEvents();
                    DataGridViewCellStyle rowColor = new DataGridViewCellStyle();
                    if (Convert.ToInt32(dgwZimmetListesi.Rows[i].Cells[2].Value) >=6)
                    {
                        rowColor.BackColor = Color.LightGreen;
                        rowColor.ForeColor = Color.Black;
                    }
                    else if(Convert.ToInt32(dgwZimmetListesi.Rows[i].Cells[2].Value) >=3 && Convert.ToInt32(dgwZimmetListesi.Rows[i].Cells[2].Value) <=5)
                    {
                        rowColor.BackColor = Color.LightSkyBlue;
                        rowColor.ForeColor = Color.Black;
                    }
                    else if(Convert.ToInt32(dgwZimmetListesi.Rows[i].Cells[2].Value) <3)
                    {
                        rowColor.BackColor = Color.LightCoral;                
                        rowColor.ForeColor = Color.Black;
                    }
                    dgwZimmetListesi.Rows[i].DefaultCellStyle = rowColor;   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " +ex);
            }
        }
        private void FormZimmetEkle_Load(object sender, EventArgs e)
        {
            this.Location = new Point(50, 100);
            Araclar.ComboBoxKullaniciGetir(cmbKullanici);
            Araclar.ComboBoxPersonelGetir(cmbPersonel);
            ZimmetUrunListele();
            cmbPersonel.SelectedItem = null;
            cmbPersonel.SelectedText = "Personel Seçiniz...";
            cmbKullanici.SelectedItem = null;
            cmbKullanici.SelectedText = "Kullanıcı Seçiniz...";
        }
        private void ZimmetUrunListele()
        {
            DemirbasTakipEntitiess db = new DemirbasTakipEntitiess();
            var data = (from d in db.sp_UrunListele() select new { d.urunID, d.urunAd, d.stokMiktari, d.fiyat, d.satınAlınmaTarihi, d.stokDurum });
            dgwZimmetListesi.DataSource = data.ToList();
            ZimmetEkleRenklendir();
        }

        private void DgwZimmetListesi_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtUrunID.Text = dgwZimmetListesi.CurrentRow.Cells[0].Value.ToString();
            txtUrunAd.Text = dgwZimmetListesi.CurrentRow.Cells[1].Value.ToString();
        }

        private void BtnZimemetKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime selectedDate = Convert.ToDateTime(calendarControl.SelectionStart.ToShortDateString());
                if (string.IsNullOrEmpty(cmbKullanici.Text) || string.IsNullOrEmpty(txtAdet.Text) || string.IsNullOrEmpty(cmbPersonel.Text))
                {
                    throw new ValidationException("Lütfen Bilgileri Kontrol Ediniz !");

                }
                if ((short.Parse(txtAdet.Text) <= 0) || (int.Parse(txtAdet.Text) > Convert.ToInt16(dgwZimmetListesi.CurrentRow.Cells[2].Value)))
                {
                    throw new ValidationException("Adet Değeri Sıfır veya Daha Düşük Değerler Olamaz !");
                }
                if (selectedDate > DateTime.Now)
                {
                    throw new ValidationException("Satın alma tarihi bugünden daha sonraki bir tarih olamaz!");
                }
                    Zimmetler zimmet = new Zimmetler
                    {
                        urunID = int.Parse(txtUrunID.Text),
                        zimmetAdet = int.Parse(txtAdet.Text),
                        personelID = Convert.ToInt32(cmbPersonel.SelectedValue),
                        kullaniciID = Convert.ToInt32(cmbKullanici.SelectedValue),
                        zimmetTarihi = selectedDate
                    };
                    ZimmetController.ZimmetEkle(zimmet);
                    MessageBox.Show("Zimmet Başarıyla Eklendi !", "Zimmet Eklendi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ZimmetUrunListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Dikkat !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtAdet_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
