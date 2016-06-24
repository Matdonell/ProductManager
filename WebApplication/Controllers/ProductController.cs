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
            DetailsProductViewModel detailsProductViewModel = new DetailsProductViewModel();
            detailsProductViewModel.Products = businessManager.GetProductById(id);
            detailsProductViewModel.Log = businessManager.getAllLogProduit();
            return View(detailsProductViewModel);
        }

        /// <summary>
        /// GET: Product/Update/ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Update(int id)
        {
            UpdateProductViewModel updateProductViewModel = new UpdateProductViewModel();
            updateProductViewModel.Product = businessManager.GetProductById(id);
            return View(updateProductViewModel);
        }

        /// <summary>
        /// POST: Product/Update/ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="collection"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Update(int id, UpdateProductViewModel updateProductViewModel)
        {
            try
            {
                if (updateProductViewModel == null || !ModelState.IsValid)
                {
                    return View(updateProductViewModel);
                }

                businessManager.ModifierProduit(updateProductViewModel.Product);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(updateProductViewModel);
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
            return View(new AddProductViewModel());
        }

        /// <summary>
        /// POST: Product/Add
        /// </summary>
        /// <param name="addProductViewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Add(AddProductViewModel addProductViewModel)
        {
            try
            {
                if (addProductViewModel == null || !ModelState.IsValid)
                {
                    return View(addProductViewModel);
                }
                businessManager.AjouterProduit(addProductViewModel.Product);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(addProductViewModel);
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
            Boolean searchForm = listProductViewModel.Search != null;

            if (!searchForm)
            {
                listProductViewModel.Products = getAllProducts();
            }
            else if (searchForm)
            {
                listProductViewModel.Products = businessManager.GetProductsByNameSearch(listProductViewModel.Search);
            }

            return View("Index", listProductViewModel);
        }
    }
}
