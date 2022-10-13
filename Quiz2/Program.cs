using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();

            musteri1.ID = 1;
            musteri1.Ad = "Yakup";
            musteri1.Soyad = "Karaca";

            Musteri musteri2 = new Musteri { ID = 2, Ad = "Fatih", Soyad = "Altaş" };

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Guncelle(musteri1);

            Console.ReadLine();
        }
    }
}
