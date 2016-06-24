using Modele.ProductManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Models
{
    public class ListProductViewModel
    {
        public List<Produit> Products { get; set; }

        public List<Categorie> Categories { get; set; }

        public int SelectedCategory { get; set; }

        public String Search { get; set; }

    }
}