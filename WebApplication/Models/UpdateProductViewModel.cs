using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Modele.ProductManager.Entities;
using System.Web.Mvc;

namespace WebApplication.Models
{
    public class UpdateProductViewModel
    {
        public Produit Product
        {
            get; set;
        }
    }
}