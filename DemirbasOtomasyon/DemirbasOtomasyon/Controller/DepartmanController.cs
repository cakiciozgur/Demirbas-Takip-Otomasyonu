using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemirbasOtomasyon.Controller;
using DemirbasOtomasyon.Model;

namespace DemirbasOtomasyon.Controller
{
    public static class DepartmanController
    {
        public static List<Departmanlar> DepartmanlariGetir()
        {
            using (var context = new DemirbasTakipEntitiess())
            {
                var result = context.Departmanlar.ToList();
                return result.ToList();
            }
        }
    }
}
