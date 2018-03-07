using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MVCWebAPI.Models;

namespace MVCWebAPI.Controllers
{
    public class UrunController : ApiController
    {
        private List<Urun> _urunler = new List<Urun>
        {
            new Urun { Id=1,Ad="Masaüstü Bilgisayar",Fiyat=1300,KategoriAd="Bilgisayar",StokMiktari=650},
            new Urun { Id=2,Ad="Dizüstü Bilgisayar",Fiyat=2200,KategoriAd="Bilgisayar",StokMiktari=4800},
            new Urun { Id=3,Ad="Tablet",Fiyat=1000,KategoriAd="Bilgisayar",StokMiktari=1900},
            new Urun { Id=4,Ad="Akilli Telefon",Fiyat=1300,KategoriAd="Telefon",StokMiktari=3200},
            new Urun { Id=5,Ad="Ev Telefonu",Fiyat=1300,KategoriAd="Telefon",StokMiktari=100},
            new Urun { Id=6,Ad="Klasik Cep Telefonu",Fiyat=1300,KategoriAd="Telefon",StokMiktari=850},

        };

        public IEnumerable<Urun> GetAllUrun()
        {
            return _urunler;
        }
        public IHttpActionResult GetUrun(int id)
        {
            //id si gelen urunu ekranda gostermeye calisicaz
            var arananUrunler = (from u in _urunler where u.Id == id select u);
            if (arananUrunler.Count() == 0)
                return NotFound();
            else
                return Ok(arananUrunler.FirstOrDefault());
        }
    }
}
