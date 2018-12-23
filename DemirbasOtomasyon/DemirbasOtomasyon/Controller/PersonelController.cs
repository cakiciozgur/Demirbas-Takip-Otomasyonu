using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemirbasOtomasyon.Model;

namespace DemirbasOtomasyon.Controller
{
    public static class PersonelController
    {
        public static List<Personeller> PersonelListele()
        {
            using (var context = new DemirbasTakipEntitiess())
            {
                var result = context.Personeller.ToList();
                return result.ToList();
            }
        }
        public static void PersonelEkle(Personeller personel)
        {
            if (personel == null)
            {
                throw new Exception("HATA");
            }
            using (var context = new DemirbasTakipEntitiess())
            {
                context.sp_PersonelEkle(personel.adi,personel.soyadi,personel.cepTelefonu,personel.departmanID,personel.iseGirisTarihi);
            }
        }
        public static void PersonelGuncelle(Personeller personel)
        {
            using (var context = new DemirbasTakipEntitiess())
            {
                context.sp_PersonelGuncelle(personel.personelID, personel.adi, personel.soyadi, personel.cepTelefonu, personel.departmanID, personel.iseGirisTarihi);
            }
        }
        public static void PersonelSil(int personelID)
        {
            using (var context = new DemirbasTakipEntitiess())
            {
                context.sp_PersonelSil(personelID);
            }
        }

    }

}
