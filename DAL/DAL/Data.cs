using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Model;
namespace DAL.DAL
{
    public class Data
    {
        List<Kategori> listk = new List<Kategori>();
        Kategori k = new Kategori() { KategoriID = 1, KategoriAdi = "Meyve" };
        Kategori k1 = new Kategori() { KategoriID = 2, KategoriAdi = "Sebze" };

        public List<Urun> UrunGetir()
        {

            return new List<Urun> { new Urun() { UrunID = 1, UrunAdi = "Portakal", KategoriID = 1 },new Urun() { UrunID = 2, UrunAdi = "Elma", KategoriID = 1 },
            new Urun() { UrunID = 3, UrunAdi = "Armut", KategoriID = 1 } };
        }
        public List<Kategori> KategoriGetir()
        {
            return new List<Kategori> { new Kategori() { KategoriID = 1, KategoriAdi = "Meyve" }, new Kategori() { KategoriID = 2, KategoriAdi = "Sebze" } };
        }
    }

}

