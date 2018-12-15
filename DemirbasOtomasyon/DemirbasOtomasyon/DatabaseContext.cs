using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;

namespace DemirbasOtomasyon
{

    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("name=DatabaseContext")
        { 
        }
        public DbSet<Urunler> Urunler { get; set; }
    }
}
