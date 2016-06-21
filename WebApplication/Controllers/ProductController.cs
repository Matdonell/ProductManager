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
    /// <summary>
    /// Product Web Application Controller : Controller
    /// </summary>
    public class ProductController : Controller
    {
        /// <summary>
        /// Instace of Business Manager
        /// </summary>
        private BusinessManager businessManager = BusinessManager.Instance;

        /// <summary>
        /// Méthode pour récuperer tout le sproduits de la list de business Manager
        /// </summary>
        /// <returns>Une liste de produit</returns>
        private List<Produit> getAllProducts()
        {
            return businessManager.GetAllProduit();
        }

        /// <summary>
        /// GET: Product
        /// </summary>
        /// <param name="listProductViewModel"></param>
        /// <returns></returns>
        public ActionResult Index(ListProductViewModel listProductViewModel)
        {
            listProductViewModel.Categories = businessManager.GetAllCategorie();
            listProductViewModel.Products = businessManager.GetAllProduit();
            listProductViewModel.Search = "";
            return View(listProductViewModel);
        }

        /// <summary>
        /// GET: Product/Details/ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public ActionResult Details(int id)
        {
            ProductDetailsViewModel productDetailsViewModel = new ProductDetailsViewModel();
            productDetailsViewModel.Products = businessManager.GetProductById(id);
            return View(productDetailsViewModel);
        }

        /// <summary>
        /// GET: Product/Update/ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Update(int id)
        {
            // TODO - Add update logic here
            return View();
        }

        /// <summary>
        /// POST: Product/Update/ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="collection"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Update(int id, FormCollection collection)
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

        /// <summary>
        /// GET: Product/Delete/ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Delete(int id)
        {
            businessManager.SupprimerProduit(id);
            return RedirectToAction("Index");
        }

        /// <summary>
        /// POST: Product/Delete/ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="collection"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                businessManager.SupprimerProduit(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        /// <summary>
        /// GET: Product/Add
        /// </summary>
        /// <returns></returns>

        public ActionResult Add()
        {
            return View();
        }

        /// <summary>
        /// POST: Product/Add
        /// </summary>
        /// <param name="listProductViewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Add(Models.ListProductViewModel listProductViewModel)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        /// <summary>
        /// POST: Product
        /// </summary>
        /// <param name="listProductViewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Search(ListProductViewModel listProductViewModel)
        {
            listProductViewModel.Categories = businessManager.GetAllCategorie();

            bool category = listProductViewModel.SelectedCategory != 0;
            bool search = listProductViewModel.Search != null;

            if (!category && !search)
            {
                listProductViewModel.Products = getAllProducts();
            }
            else
            {
                if (category && search)
                {
                    listProductViewModel.Products = businessManager.GetProductsByCategoryIdAndName(listProductViewModel.SelectedCategory, listProductViewModel.Search);
                }
                else if (category)
                {
                    listProductViewModel.Products = businessManager.GetProductsByCategoryId(listProductViewModel.SelectedCategory);
                }
            }

            return View("Index", listProductViewModel);
        }
    }
}
