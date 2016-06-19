using Modele.ProductManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class ProductDetailsViewModel
    {
        public List<Produit> Products { get; set; }

        public List<Categorie> Categories { get; set; }
    }
}