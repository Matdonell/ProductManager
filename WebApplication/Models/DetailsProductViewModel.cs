using Modele.ProductManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class DetailsProductViewModel
    {
        public Produit Products { get; set; }

        public List<LogProduit> Log { get; set; }
    }
}