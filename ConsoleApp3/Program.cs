using Kutuphane;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Matematik m = new Matematik();
            Console.WriteLine(m.KareAl(4));

            Metin metin = new Metin();

            Console.WriteLine(metin.TersÇevir("Merhaba"));
            Console.WriteLine(metin.Eko(3, "Ses"));
        }
    }
}
