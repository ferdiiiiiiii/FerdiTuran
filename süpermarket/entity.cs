using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace süpermarket
{
    public class urunler
    {

        public Guid urun_id { get; set; }
        public string urun_ad { get; set; }
        public string urun_fiyat { get; set; }
        public string stok_miktari { get; set; }
    }
    public class musteriler
    {

        public Guid musteri_id { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string telefon { get; set; }
    }
}
