using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;
using DemirbasOtomasyon.Test;
using DemirbasOtomasyon.Model;
using DemirbasOtomasyon.Controller;

namespace DemirbasOtomasyon.Test
{
    [TestClass]
    public class TestHesapla
    {
        [TestMethod]
        public void UrunEkleme()
        {
            Urunler urun = new Urunler
            {
                urunAd = "Kulaklık",
                stokMiktari = 4,
                fiyat = 30,
                satınAlınmaTarihi = Convert.ToDateTime("2018/03/05")
            };
            UrunController.UrunEkle(urun);
        }
        [TestMethod]
        public void PersonelEkleme()
        {
            Personeller per = new Personeller
            {
                adi = "Ahmet",
                soyadi = "Hamdi Tanpınar",
                cepTelefonu = "05426336958",
                departmanID = 2,
                iseGirisTarihi = Convert.ToDateTime("2015-03-03")
            };
            PersonelController.PersonelEkle(per);
        }
        [TestMethod]
        public void ZimmetEkleme()
        {
            Zimmetler z = new Zimmetler
            {
                urunID = 1,
                personelID = 1,
                kullaniciID = 2,
                zimmetTarihi = Convert.ToDateTime("2018-12-22")
            };
            ZimmetController.ZimmetEkle(z,1);
        }
    }
}
