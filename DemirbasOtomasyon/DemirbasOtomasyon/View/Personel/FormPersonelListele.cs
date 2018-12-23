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
                var data = db.sp_PersonelBul(int.Parse(txtPersonelID.Text));
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
    }
}