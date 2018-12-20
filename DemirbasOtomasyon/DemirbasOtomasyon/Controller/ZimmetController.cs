using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemirbasOtomasyon.Controller;
using DemirbasOtomasyon.Model;

namespace DemirbasOtomasyon.Controller
{
    public static class ZimmetController
    {
        public static void ZimmetEkle(Zimmetler zimmet,int adet)
        {
            using (var context = new DemirbasTakipEntitiess())
            {
                context.sp_ZimmetEkle(zimmet.urunID, zimmet.zimmetTarihi, zimmet.zimmetAdet, zimmet.personelID, zimmet.kullaniciID,adet);
                context.SaveChanges();
            }
        }
    }
}
