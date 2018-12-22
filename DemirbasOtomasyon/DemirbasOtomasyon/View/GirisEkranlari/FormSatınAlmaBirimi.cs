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
    public partial class FormSatınAlmaBirimi : DevExpress.XtraEditors.XtraForm
    {
        public FormSatınAlmaBirimi()
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
    }
}