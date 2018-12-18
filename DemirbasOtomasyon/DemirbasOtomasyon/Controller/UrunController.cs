using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemirbasOtomasyon.Model;
namespace DemirbasOtomasyon.Controller
{
        public static class UrunController
    {
        public static void UrunEkle(Urunler urun)
        {
            if (urun==null)
            {
                throw new Exception("HATA");
            }
            using (var context=new DemirbasTakipEntitiess())
            {
                context.sp_UrunEkle(urun.urunAd, urun.fiyat, urun.stokMiktari, urun.satınAlınmaTarihi);
            }
        }
            public static void urunDuzenle(Urunler urun)
        {
            using (var context = new DemirbasTakipEntitiess())
            {
                context.sp_UrunGuncelle(urun.urunID, urun.urunAd, urun.fiyat, urun.stokMiktari, urun.satınAlınmaTarihi);
            }
        }
            /*public static void UrunSil(int urunId)
            {
                using (var context = new DemirbasTakipEntitiess())
                {
                    var result = context.Urunler.FirstOrDefault(x => x.urunID == urunId);
                    context.Entry(result).State = EntityState.Deleted;
                    context.SaveChanges();
                }
            }*/
            public static UrunViewModel UrunGetir(int urunId)
            {
                using (var context = new DemirbasTakipEntitiess())
                {
                    var result = from urun in context.Urunler
                                 select new UrunViewModel
                                 {
                                     Urun=urun
                                 };
                    return result.FirstOrDefault(x => x.Urun.urunID == urunId);
                }
            }
    }
}
