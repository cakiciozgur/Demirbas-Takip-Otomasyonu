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
using DemirbasOtomasyon.Model;
namespace DemirbasOtomasyon.View
{
    
    public partial class FormUrunEkleme : DevExpress.XtraEditors.XtraForm
    {
        //Urunler u = new Urunler();
        //DemirbasTakipEntities dt = new DemirbasTakipEntities();
        public FormUrunEkleme()
        {
            InitializeComponent();
        }

        private void FormUrunEkleme_Load(object sender, EventArgs e)
        {
            //u.fiyat = 5;
            //u.urunAd = "LAPTOP";
            //u.urunID = 1;
            //u.stokMiktari = 5;
            //u.stokDurum = false;
            //u.stokAltLimit = 1;
            //dt.Urunler.Add(u);
            //dt.SaveChanges();   
        }
    }
}