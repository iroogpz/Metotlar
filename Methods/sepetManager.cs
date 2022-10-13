using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class sepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Ürün sepete eklendi : " + urun.Adi);
        }

        public void Ekle2(string urunadi,string urunaciklama,double urunfiyat,int stokadedi)
        {
            Console.WriteLine("Eklenen Ürün Adı : "+ urunadi);
        }
    }
}
