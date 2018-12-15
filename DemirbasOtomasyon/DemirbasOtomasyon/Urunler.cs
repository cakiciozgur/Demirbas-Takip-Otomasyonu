using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DemirbasOtomasyon
{
    public class Urunler
    {
        public int urunID { get; set; }
        public string urunAd { get; set; }
        public decimal fiyat { get; set; }
        public int stokAltLimit { get; set; }
        public int stokMiktari { get; set; }
        public DateTime satinAlinmaTarihi { get; set; }
        public bool stokDurum { get; set; }
    }
}
