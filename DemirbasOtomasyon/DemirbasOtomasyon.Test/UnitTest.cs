using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;
using DemirbasOtomasyon.Model;
using DemirbasOtomasyon.Controller;
using DemirbasOtomasyon.View;

namespace DemirbasOtomasyon.Test
{
    [TestClass]
    public class TestHesapla
    {
        [TestMethod]
        public void UrunEkleme()
        {
            FormUrunEkleme u = new FormUrunEkleme();

            u.txtUrunAd.Text = "Kulaklık";
            u.txtAdet.Text = "4";
            u.txtFiyat.Text = "30";
            u.calendarControl1.Text = "2018/03/05";
            u.btnEkle.PerformClick();

        }

        [TestMethod]
        public void PersonelEkleme()
        {
            FormPersonelEkleme p = new FormPersonelEkleme();

            p.txtPersonelAd.Text = "Sait Faik";
            p.txtPersonelSoyad.Text = "Abasıyanık";
            p.txtCepTelefonu.Text = "05892544896";
            p.cmbDepartmanSec.Text = "2";
            p.calendarControl2.Text = "2018/09/05";
            p.btnPersonelEkle.PerformClick();
        }
        [TestMethod]
        public void ZimmetEkleme()
        {
            FormZimmetEkle z = new FormZimmetEkle();

            z.txtUrunAd.Text = "Klavye";
            z.txtAdet.Text = "2";
            z.cmbPersonel.Text = "İbrahim";
            z.cmbKullanici.Text = "Haci";
            z.calendarControl.Text = "2018/11/26";
            z.btnZimemetKaydet.PerformClick();
        }
        [TestMethod]
        public void UrunGuncelle()
        {
            FormUrunGuncelle z = new FormUrunGuncelle();

            z.txtUrunAd.Text = "Klavye";
            z.txtAdet.Text = "2";
            z.txtFiyat.Text = "5000";
            z.calendarControl1.Text = "2018/10/26";
            z.btnGuncelle.PerformClick();
        }
        [TestMethod]
        public void PersonelSil()
        {
            FormPersonelGuncelleme p = new FormPersonelGuncelleme();

            p.txtAdi.Text = "Emin";
            p.txtSoyadi.Text = "Borandağ";
            p.txtTelefon.Text = "05536987000";
            p.cmbDepartmanGuncelle.Text = "3";
            p.calendarControl.Text = "2018/8/16";
            p.btnPersonelSil.PerformClick();
        }
    }
}
