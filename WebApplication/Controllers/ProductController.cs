using BusinessLayer;
using BusinessLayer.ProductManager;
using Modele.ProductManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class ProductController : Controller
    {
        private BusinessManager businessManager = BusinessManager.Instance;

        // GET: Product
        public ActionResult Index(ProductViewModel productViewModel)
        {
            productViewModel.Categories = businessManager.GetAllCategorie();
            productViewModel.Products = businessManager.GetAllProduit();
            productViewModel.Search = "";
            return View(productViewModel);
        }

        [HttpPost]
        public ActionResult Search(ProductViewModel productViewModel)
        {
            productViewModel.Categories = businessManager.GetAllCategorie();

            bool category = productViewModel.SelectedCategory != 0;
            bool search = productViewModel.Search != null;

            if (!category && !search)
            {
                productViewModel.Products = getAllProducts();
            }
            else
            {
                if (category && search)
                {
                    // model.Products = businessManager.GetProductsByCategoryIdAndName(model.SelectedCategory, model.Search);                    
                }
                else if (category)
                {
                    //model.Products = businessManager.GetProductsByCategoryId(model.SelectedCategory);
                }
                else if (search)
                {
                    // model.Products = businessManager.GetProductsByName(model.Search);
                }
            }

            return View("Index", productViewModel);
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            ProductDetailsViewModel productDetailsViewModel = new ProductDetailsViewModel();
            // TODO - verifier methode getby id
            //productDetailsViewModel.Products = businessManager.GetByProductID(id);
            return View(productDetailsViewModel);
        }

        // GET: Product/Update/5
        public ActionResult Update(int id)
        {
            // TODO - Add update logic here
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO - Add update logic here
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO -  Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        private List<Produit> getAllProducts()
        {
            return businessManager.GetAllProduit();
        }


        // GET: Product/Add
        public ActionResult Add()
        {
            return View();
        }

        // POST: Product/Add
        [HttpPost]
        public ActionResult Add(Models.ProductViewModel productViewModel)
        {
            try
            {
                // TODO - Add insert logic here
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
