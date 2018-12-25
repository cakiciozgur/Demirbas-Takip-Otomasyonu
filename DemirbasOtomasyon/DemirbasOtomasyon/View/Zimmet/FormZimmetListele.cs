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
using DevExpress.XtraReports.UI;
namespace DemirbasOtomasyon.View
{
    public partial class FormZimmetListele : DevExpress.XtraEditors.XtraForm
    {
        public FormZimmetListele()
        {
            InitializeComponent();
        }
        private void ZimmetListele()
        {
            DemirbasTakipEntitiess db = new DemirbasTakipEntitiess();
            var data = db.sp_ZimmetListele2();
            dgwZimmetListele.DataSource = data.ToList();
            ZimmetRenklendir();
        }
        private void ZimmetRenklendir()
        {
            try
            {
                for (int i = 0; i < dgwZimmetListele.Rows.Count; i++)
                {
                    Application.DoEvents();
                    DataGridViewCellStyle rowColor = new DataGridViewCellStyle();
                    if (Convert.ToInt32(dgwZimmetListele.Rows[i].Cells[0].Value) >= 1)
                    {
                        rowColor.BackColor = Color.LightSkyBlue;
                        rowColor.ForeColor = Color.Black;
                    }
                    dgwZimmetListele.Rows[i].DefaultCellStyle = rowColor;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex);
            }
        }
        
        private void FormZimmetListele_Load(object sender, EventArgs e)
        {
            this.Location = new Point(50, 100);
            Araclar.ComboBoxDepartmanGetir(cmbDepartmanTip);
            cmbDepartmanTip.SelectedItem = null;
            cmbDepartmanTip.SelectedText = "Departman Seçiniz...";
            ZimmetListele();
        }

        private void BtnZimmetBul_Click(object sender, EventArgs e)
        {
            try
            {
                if ((Convert.ToInt32(txtZimmetID.Text) < 0 || Convert.ToInt32(txtZimmetID.Text) > 1000000000))
                {
                    MessageBox.Show("Geçerli bir ID Giriniz ! ");
                    txtZimmetID.Text = "";
                    txtZimmetID.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Geçerli bir değer girin");
                txtZimmetID.Text = "";
                txtZimmetID.Focus();
            }
            if (string.IsNullOrEmpty(txtZimmetID.Text))
            {
                txtZimmetID.Text = "";
            }
            else
            {
                DemirbasTakipEntitiess db = new DemirbasTakipEntitiess();
                var data = db.sp_ZimmetBul(int.Parse(txtZimmetID.Text));
                dgwZimmetListele.DataSource = data.ToList();
                ZimmetRenklendir();
            }


    }

        private void BtnTumZimmetler_Click(object sender, EventArgs e)
        {
            ZimmetListele();
        }
        private void cmbDepartmanTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            DemirbasTakipEntitiess db = new DemirbasTakipEntitiess();
            var data = db.sp_ZimmetListeleDepartmanaGore(Convert.ToInt32(cmbDepartmanTip.SelectedIndex + 1));
            dgwZimmetListele.DataSource = data.ToList();
            ZimmetRenklendir();
        }

        private void BtnRapor_Click(object sender, EventArgs e)
        {
            ppdDialog.ShowDialog();
        }
        Font Baslik = new Font("Corbel",18, FontStyle.Bold);
        Font Govde = new Font("Corbel", 12);
        SolidBrush sb = new SolidBrush(Color.Black);
        private void pdYazici_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            decimal ToplamZimmet = 0;
            int i;
            StringFormat Format = new StringFormat();
            Format.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("ZİMMET RAPORU", Baslik, sb, 310, 200);
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------------------------------------", Govde, sb, 50, 230);
            e.Graphics.DrawString("ZİMMET ID          ADET         ÜRÜN ADI          PERSONEL         DEPARTMAN               TARİH                           KULLANICI", Govde, sb, 50, 300);
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------------------------------------", Govde, sb, 50, 320);
            for (i = 0; i < dgwZimmetListele.Rows.Count; i++)
            {
                e.Graphics.DrawString(dgwZimmetListele.Rows[i].Cells[1].Value.ToString(), Govde, sb, 70, 340 + (i * 30));
                e.Graphics.DrawString(dgwZimmetListele.Rows[i].Cells[2].Value.ToString(), Govde, sb, 170, 340 + (i * 30));
                e.Graphics.DrawString(dgwZimmetListele.Rows[i].Cells[3].Value.ToString(), Govde, sb, 240, 340 + (i * 30));
                e.Graphics.DrawString(dgwZimmetListele.Rows[i].Cells[4].Value.ToString(), Govde, sb, 350, 340 + (i * 30));
                e.Graphics.DrawString(dgwZimmetListele.Rows[i].Cells[5].Value.ToString(), Govde, sb, 450, 340 + (i * 30));
                e.Graphics.DrawString(dgwZimmetListele.Rows[i].Cells[6].Value.ToString(), Govde, sb, 590, 340 + (i * 30));
                e.Graphics.DrawString(dgwZimmetListele.Rows[i].Cells[7].Value.ToString(), Govde, sb, 750, 340 + (i * 30));
                ToplamZimmet += Convert.ToDecimal(dgwZimmetListele.Rows[i].Cells[2].Value);
            }
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------------------------------------", Govde, sb, 50, 355+(i*30));
            e.Graphics.DrawString("TOPLAM ZİMMETLİ ÜRÜN : "+ToplamZimmet, Govde, sb, 525, 375 + (i * 30));
            e.Graphics.DrawString("ÇAKAN LTD.ŞTİ - 2018", Govde, sb, 600, 1000);
        }

        private void txtZimmetID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}