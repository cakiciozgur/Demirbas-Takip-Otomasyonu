using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemirbasOtomasyon.Model;

namespace DemirbasOtomasyon.Controller
{
    public static class KullaniciController
    {
        public static List<Kullanıcılar> KullanicilariListele()
        {
            using (var context = new DemirbasTakipEntitiess())
            {
                var result = context.Kullanıcılar.ToList();
                return result.ToList();
            }
        }
    }
}
