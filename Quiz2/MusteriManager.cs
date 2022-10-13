using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2
{
    internal class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri ID : {0} --- Müşteri Adı ve Soyadı : {1}{2} ---Başarıyla Ekledi"
                ,musteri.ID,musteri.Ad,musteri.Soyad);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri ID : {0} --- Müşteri Adı ve Soyadı : {1}{2} ---Başarıyla Silindi"
                , musteri.ID, musteri.Ad, musteri.Soyad);
        }
        public void Guncelle(Musteri musteri)
        {
            Console.WriteLine("Müşteri ID : {0} --- Müşteri Adı ve Soyadı : {1}{2} ---Başarıyla Güncellendi"
                , musteri.ID, musteri.Ad, musteri.Soyad);
        }
    }
}
