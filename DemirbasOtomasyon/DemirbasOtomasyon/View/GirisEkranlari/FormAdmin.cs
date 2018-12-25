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
    public partial class FormAdmin : DevExpress.XtraEditors.XtraForm
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void BtnUrunListele_Click(object sender, EventArgs e)
        {
            FormUrunListele ful = new FormUrunListele();
            ful.ShowDialog();
        }

        private void BtnUrunEkle_Click(object sender, EventArgs e)
        {
            FormUrunEkleme fue = new FormUrunEkleme();
            fue.ShowDialog();
        }

        private void BtnUrunGuncelle_Click(object sender, EventArgs e)
        {
            FormUrunGuncelle fug = new FormUrunGuncelle();
            fug.ShowDialog();
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

        private void BtnPersonelGuncelle_Click(object sender, EventArgs e)
        {
            FormPersonelGuncelleme fpg = new FormPersonelGuncelleme();
            fpg.ShowDialog();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            this.Location = new Point(50, 100);
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            FormKullaniciSecim fks = new FormKullaniciSecim();
            fks.Show();
            this.Close();
        }

        private void BtnAtiklar_Click(object sender, EventArgs e)
        {
            FormAtiklar fa = new FormAtiklar();
            fa.ShowDialog();
        }
    }
}