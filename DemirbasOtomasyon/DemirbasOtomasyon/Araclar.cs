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
            ComboBox cmb = new ComboBox();
            cmb.DataSource = dataSource;
            cmb.ValueMember = valueMember;
            cmb.DisplayMember = displayMember;
            return cmb;
        }

        public static void comboBoxKullaniciGetir(ComboBox cmb)
        {
            cmb.DataSource = KullaniciController.KullanicilariListele();
            cmb.DisplayMember = "kullaniciAdi";
            cmb.ValueMember = "kullaniciID";
        }

        public static void comboBoxPersonelGetir(ComboBox cmb)
        {
            cmb.DataSource = PersonelController.PersonelListele();
            cmb.DisplayMember = "adi";
            cmb.ValueMember = "personelID";
        }
        public static void comboBoxDepartmanGetir(ComboBox cmb)
        {
            cmb.DataSource = DepartmanController.DepartmanlariGetir();
            cmb.DisplayMember = "departmanAdi";
            cmb.ValueMember = "departmanID";
        }


    }
}
