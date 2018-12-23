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
            Araclar.ComboBoxDepartmanGetir(cmbDepartmanTip);
            cmbDepartmanTip.SelectedItem = null;
            cmbDepartmanTip.SelectedText = "Departman Seçiniz...";
            ZimmetListele();
        }

        private void BtnZimmetBul_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtZimmetID.Text))
            {
               MessageBox.Show("Zimmet ID Giriniz !");
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
            ZimmetRapor zr = new ZimmetRapor();
            zr.ShowPreviewDialog();
        }
    }
}