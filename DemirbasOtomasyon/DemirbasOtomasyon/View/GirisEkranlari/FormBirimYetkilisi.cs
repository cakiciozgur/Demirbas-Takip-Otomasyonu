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

namespace DemirbasOtomasyon.View
{
    public partial class FormBirimYetkilisi : DevExpress.XtraEditors.XtraForm
    {
        public FormBirimYetkilisi()
        {
            InitializeComponent();
        }
        private void BtnPersonelListele_Click(object sender, EventArgs e)
        {
            FormPersonelListele fpl = new FormPersonelListele();
            fpl.ShowDialog();
        }
        private void BtnZimmetListele_Click_1(object sender, EventArgs e)
        {
            FormZimmetListele fzl = new FormZimmetListele();
            fzl.ShowDialog();
        }

        private void FormBirimYetkilisi_Load(object sender, EventArgs e)
        {
            this.Location = new Point(50, 100);
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            FormKullaniciSecim fks = new FormKullaniciSecim();
            fks.Show();
            this.Close();
        }
    }
}