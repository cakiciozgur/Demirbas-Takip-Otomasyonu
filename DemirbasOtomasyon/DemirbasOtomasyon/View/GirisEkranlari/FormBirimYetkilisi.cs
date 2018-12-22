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

        private void BtnZimmetListele_Click(object sender, EventArgs e)
        {
            FormZimmetListele fzl = new FormZimmetListele();
            fzl.ShowDialog();
        }

        private void BtnZimmetEkle_Click(object sender, EventArgs e)
        {
            FormZimmetEkle fze = new FormZimmetEkle();
            fze.ShowDialog();
        }

        private void BtnZimmetGuncelle_Click(object sender, EventArgs e)
        {
            FormZimmetGuncelleme fzg = new FormZimmetGuncelleme();
            fzg.ShowDialog();
        }

        private void BtnPersonelListele_Click(object sender, EventArgs e)
        {
            FormPersonelListele fpl = new FormPersonelListele();
            fpl.ShowDialog();
        }

        private void BtnPersonelEkle_Click(object sender, EventArgs e)
        {
            FormPersonelEkleme fpe = new FormPersonelEkleme();
            fpe.ShowDialog();
        }

        private void BtnPersonelDuzenle_Click(object sender, EventArgs e)
        {
            FormPersonelGuncelleme fpg = new FormPersonelGuncelleme();
            fpg.ShowDialog();
        }
    }
}