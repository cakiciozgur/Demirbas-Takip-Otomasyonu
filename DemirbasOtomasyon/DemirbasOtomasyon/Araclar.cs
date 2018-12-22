using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DemirbasOtomasyon.Model;
using DemirbasOtomasyon.Controller;

namespace DemirbasOtomasyon
{
    public static class Araclar
    {
        private static ComboBox ComboBoxDoldur(List<object> dataSource, string valueMember, string displayMember)
        {
            ComboBox cmb = new ComboBox
            {
                DataSource = dataSource,
                ValueMember = valueMember,
                DisplayMember = displayMember
            };
            return cmb;
        }

        public static void ComboBoxKullaniciGetir(ComboBox cmb)
        {
            cmb.DataSource = KullaniciController.KullanicilariListele();
            cmb.DisplayMember = "kullaniciAdi";
            cmb.ValueMember = "kullaniciID";
        }

        public static void ComboBoxPersonelGetir(ComboBox cmb)
        {
            cmb.DataSource = PersonelController.PersonelListele();
            cmb.DisplayMember = "adi";
            cmb.ValueMember = "personelID";
        }
        public static void ComboBoxDepartmanGetir(ComboBox cmb)
        {
            cmb.DataSource = DepartmanController.DepartmanlariGetir();
            cmb.DisplayMember = "departmanAdi";
            cmb.ValueMember = "departmanID";
        }
    }
}
