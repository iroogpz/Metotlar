﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    internal class DortIslem
    {
        public void topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("{0} + {1} = {2}",sayi1,sayi2,toplam);
        }

        public void cikar(int sayi1, int sayi2)
        {
            int toplam = sayi1 - sayi2;
            Console.WriteLine("{0} - {1} = {2}", sayi1, sayi2, toplam);
        }

        public void carp(int sayi1, int sayi2)
        {
            int toplam = sayi1 * sayi2;
            Console.WriteLine("{0} * {1} = {2}", sayi1, sayi2, toplam);
        }

        public void bol(int sayi1, int sayi2)
        {
            int toplam = sayi1 / sayi2;
            Console.WriteLine("{0} / {1} = {2}", sayi1, sayi2, toplam);
        }

    }
}