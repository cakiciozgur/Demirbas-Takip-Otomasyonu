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
    }
}
