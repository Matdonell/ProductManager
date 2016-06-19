using Modele.ProductManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Models
{
    public class ProductViewModel
    {
        public List<Produit> Products { get; set; }

        public List<Categorie> Categories { get; set; }

        public int SelectedCategory { get; set; }

        public String Search { get; set; }

        public IEnumerable<SelectListItem> CategoryItems
        {
            get
            {
                List<Categorie> categories = new List<Categorie>();
                categories.Add(new Categorie()
                {
                    ID = 0,
                    Libelle = "ALL"
                });

                if (Categories.Count > 0)
                {
                    categories.AddRange(Categories);
                }
                return new SelectList(categories, "ID");
            }
        }

    }
}