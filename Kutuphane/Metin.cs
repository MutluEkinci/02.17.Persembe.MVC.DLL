using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane
{
    public class Metin//default class için private dll için internal .dll(dinamik link kütüphanesi)
    {
        public string Eko(int tekrarSayisi, string mesaj)
        {
            string str = "";
            for (int i = 0; i < tekrarSayisi; i++)
            {
                str += mesaj + " ";
            }
            return str;
        }
        public string TersÇevir(string mesaj)
        {
            string str = "";
            for (int i = mesaj.Length - 1; i >= 0; i--)
            {
                str += mesaj[i];
            }
            return str;
        }
    }
}
