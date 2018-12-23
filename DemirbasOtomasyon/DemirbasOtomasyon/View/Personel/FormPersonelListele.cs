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
    public partial class FormPersonelListele : DevExpress.XtraEditors.XtraForm
    {
        public FormPersonelListele()
        {
            InitializeComponent();
        }
        private void PersonelListele()
        {
            DemirbasTakipEntitiess db = new DemirbasTakipEntitiess();
            var data = db.sp_PersonelListele2();
            dgwPersonelListele.DataSource = data.ToList();
            PersonelRenklendir();
        }
        private void PersonelRenklendir()
        {
            try
            {
                for (int i = 0; i < dgwPersonelListele.Rows.Count; i++)
                {
                    Application.DoEvents();
                    DataGridViewCellStyle rowColor = new DataGridViewCellStyle();
                    if (Convert.ToInt32(dgwPersonelListele.Rows[i].Cells[0].Value) >= 1)
                    {
                        rowColor.BackColor = Color.LightSkyBlue;
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
        private void FormPersonelListele_Load(object sender, EventArgs e)
        {
            Araclar.ComboBoxDepartmanGetir(cmbDepartmanTip);
            cmbDepartmanTip.SelectedItem = null;
            cmbDepartmanTip.SelectedText = "Departman Seçiniz...";
            PersonelListele();   
        }

        private void BtnPersonelBul_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPersonelID.Text))
            {
               MessageBox.Show("Personel ID Giriniz !");
            }
            else
            {
                DemirbasTakipEntitiess db = new DemirbasTakipEntitiess();
                var data = db.sp_PersonelBul2(int.Parse(txtPersonelID.Text));
                dgwPersonelListele.DataSource = data.ToList();
                PersonelRenklendir();
            }
            
        }

        private void BtnTumPersonel_Click(object sender, EventArgs e)
        {
            PersonelListele();
        }
        private void cmbDepartmanTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            DemirbasTakipEntitiess db = new DemirbasTakipEntitiess();
            var data = db.sp_DepartmanaGoreListele(Convert.ToInt32(cmbDepartmanTip.SelectedIndex + 1));
            dgwPersonelListele.DataSource = data.ToList();
            PersonelRenklendir();
        }
        private void BtnRapor_Click(object sender, EventArgs e)
        {
            ppdDialog.ShowDialog();
        }
        Font Baslik = new Font("Corbel", 18, FontStyle.Bold);
        Font Govde = new Font("Corbel", 12);
        SolidBrush sb = new SolidBrush(Color.Black);

        private void pdYazici_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringFormat Format = new StringFormat();
            Format.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("ÜRÜNLER RAPORU", Baslik, sb, 310, 200);
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------------------------------------", Govde, sb, 50, 230);
            e.Graphics.DrawString("PERSONEL ID        ADI                SOYADI               CEP TELEFONU               DEPARTMAN                   İŞE GİRİŞ TARİHİ            ", Govde, sb, 50, 300);
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------------------------------------", Govde, sb, 50, 320);
            int i;
            for (i = 0; i < dgwPersonelListele.Rows.Count; i++)
            {
                e.Graphics.DrawString(dgwPersonelListele.Rows[i].Cells[0].Value.ToString(), Govde, sb, 80, 340 + (i * 30));
                e.Graphics.DrawString(dgwPersonelListele.Rows[i].Cells[1].Value.ToString(), Govde, sb, 170, 340 + (i * 30));
                e.Graphics.DrawString(dgwPersonelListele.Rows[i].Cells[2].Value.ToString(), Govde, sb, 260, 340 + (i * 30));
                e.Graphics.DrawString(dgwPersonelListele.Rows[i].Cells[3].Value.ToString(), Govde, sb, 370, 340 + (i * 30));
                e.Graphics.DrawString(dgwPersonelListele.Rows[i].Cells[4].Value.ToString(), Govde, sb, 525, 340 + (i * 30));
                e.Graphics.DrawString(dgwPersonelListele.Rows[i].Cells[5].Value.ToString(), Govde, sb, 680, 340 + (i * 30));

            }
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------------------------------------", Govde, sb, 50, 350 + (i * 30));
            e.Graphics.DrawString("TOPLAM PERSONEL :  "+i, Govde, sb, 600, 370 + (i * 30));
            e.Graphics.DrawString("ÇAKAN LTD.ŞTİ - 2018", Govde, sb, 600, 1000);
        }
    }
}