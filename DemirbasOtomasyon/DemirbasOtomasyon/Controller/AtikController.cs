using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemirbasOtomasyon.Controller;
using DemirbasOtomasyon.Model;

namespace DemirbasOtomasyon.Controller
{
    public static class AtikController
    {
        public static void AtikEkle(int zimmetID)
        {
            using (var context = new DemirbasTakipEntitiess())
            {
                context.sp_AtikEkle(zimmetID);
                context.SaveChanges();
            }
        }
        public static void AtikBul(int atikID)
        {
            using (var context = new DemirbasTakipEntitiess())
            {
                context.sp_AtikBul(atikID);
                context.SaveChanges();
            }
        }
        public static void AtikGeriDondur(int urunID,int stokMiktari)
        {
            using (var context = new DemirbasTakipEntitiess())
            {
                context.sp_AtikGeriDondur(urunID,stokMiktari);
                context.SaveChanges();
            }
        }
        public static void AtikListele()
        {
            using (var context = new DemirbasTakipEntitiess())
            {
                context.sp_AtikListele();
                context.SaveChanges();
            }
        }
    }
}
