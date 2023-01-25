using ServisProdukt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;

namespace ServisProdukt.Controllers
{
    public class ProduktiController : ApiController
    {
        Product[] produkti = new Product[]
            { 
            new Product{Id=1,Ime="Paradižnikova juha",Kategorija="Jestvine",Cena=1},
            new Product{Id=2,Ime="Žoga",Kategorija="Igrače",Cena=3.75m},
            new Product{Id=3,Ime="Kladivo",Kategorija="Železnina",Cena=16.99m}
            };
        public List<Product> GetProducts()
        {
            return produkti.ToList<Product>();
        }
        public Product GetProduct(int id)
        {
            var p = produkti.Where(a => a.Id == id).FirstOrDefault();
            return p;
        }
    }
}
