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
                        rowColor.BackColor = Color.LightCoral;
                        rowColor.ForeColor = Color.Black;
                    }
                    else if(Convert.ToInt32(dgwZimmetListesi.Rows[i].Cells[2].Value) >=3 && Convert.ToInt32(dgwZimmetListesi.Rows[i].Cells[2].Value) <=5)
                    {
                        rowColor.BackColor = Color.LightSkyBlue;
                        rowColor.ForeColor = Color.Black;
                    }
                    else if(Convert.ToInt32(dgwZimmetListesi.Rows[i].Cells[2].Value) <3)
                    {
                        rowColor.BackColor = Color.LightSteelBlue;                
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
            Araclar.comboBoxKullaniciGetir(cmbKullanici);
            Araclar.comboBoxPersonelGetir(cmbPersonel);
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

        private void dgwZimmetListesi_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtUrunID.Text = dgwZimmetListesi.CurrentRow.Cells[0].Value.ToString();
            txtUrunAd.Text = dgwZimmetListesi.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnZimemetKaydet_Click(object sender, EventArgs e)
        {

        }
    }
}