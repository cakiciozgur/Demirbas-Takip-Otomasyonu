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

namespace DemirbasOtomasyon
{
    
    public partial class UrunGiris : DevExpress.XtraEditors.XtraForm
    {
        public UrunGiris()
        {
            InitializeComponent();
        }

        private void UrunGiris_Load(object sender, EventArgs e)
        {
            DatabaseContext db = new DatabaseContext();

            Urunler u = new Urunler();
            u.urunAd = "LAPTOP";
            u.fiyat = 50;
            u.urunID = 1;
            u.stokMiktari = 10;
            u.stokDurum = false;
            u.stokAltLimit = 1;
            u.satinAlinmaTarihi = DateTime.Parse("2018-09-01");
            db.Urunler.Add(u);
            db.SaveChanges();
        }
    }
}