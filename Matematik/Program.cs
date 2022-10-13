using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();
            dortIslem.topla(5, 6);
            dortIslem.cikar(20, 3);
            dortIslem.carp(2, 3);
            dortIslem.bol(6, 2);

            Console.ReadLine();
        }
    }
}
