using Modele.ProductManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Models
{
    public class AddProductViewModel
    {
        public Produit Product
        {
            get; set;
        }
    }
}