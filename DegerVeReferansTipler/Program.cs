using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegerVeReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // stack heap
            int sayi1 = 15;
            int sayi2 = 40;
            sayi1 = sayi2;
            sayi2 = 34;
            //Sayı 1 = ?
            //int bir değer tipi olduğu için cevap 40 Tır
            Console.WriteLine("Sayı 1 : {0} --- Sayı 2 : {1} ",sayi1,sayi2);


            int[] sayılar1 = new int[] { 10, 20, 30 };
            int[] sayılar2 = new int[] { 100, 200, 300 };
            sayılar1 = sayılar2;
            sayılar2[0] = 999;
            //sayılar1[0] = ? 
            //Arrayler bir referans tip olduğu için sonuç 999'dur

            Console.WriteLine("Sayılar1[0] : {0} ", sayılar1[0]);


            Console.ReadLine();

        }
    }
}
