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
    public partial class FormAtiklar : DevExpress.XtraEditors.XtraForm
    {
        public FormAtiklar()
        {
            InitializeComponent();
        }

        private void BtnAtikBul_Click(object sender, EventArgs e)
        {
            try
            {
                if ((Convert.ToInt32(txtUrunID.Text) < 0 || Convert.ToInt32(txtUrunID.Text) > 1000000000))
                {
                    MessageBox.Show("Geçerli bir ID Giriniz ! ");
                    txtUrunID.Text = "";
                    txtUrunID.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Geçerli bir değer girin");
                txtUrunID.Text = "";
                txtUrunID.Focus();
            }
            if (string.IsNullOrEmpty(txtUrunID.Text))
            {
                txtUrunID.Text = "";
            }
            else
            {
                DemirbasTakipEntitiess db = new DemirbasTakipEntitiess();
                var data = db.sp_AtikBul(int.Parse(txtUrunID.Text));
                dgwAtikListesi.DataSource = data.ToList();
            }
        }

        private void FormAtiklar_Load(object sender, EventArgs e)
        {
            DemirbasTakipEntitiess db = new DemirbasTakipEntitiess();
            var data = db.sp_AtikListele();
            dgwAtikListesi.DataSource = data.ToList();
        }
    }
}