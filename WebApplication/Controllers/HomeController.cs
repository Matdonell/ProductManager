using BusinessLayer.ProductManager;
using Modele.ProductManager.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {

        private IndexProductViewModel _indexProduitViewModel = new IndexProductViewModel();

        // GET: Home
        public ActionResult Index()
        {
            // on appelle le mock pour initialiser une liste de produits
            List<Produit> listProduct = new List<Produit>();
            foreach (Produit p in BusinessManager.Instance.GetAllProduit())
            {
                listProduct.Add(p);
            }
            _indexProduitViewModel.Products = listProduct;
           
            return View("Index");
        }
    }
}