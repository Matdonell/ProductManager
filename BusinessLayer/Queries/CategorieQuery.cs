using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.ProductManager;
using Modele.ProductManager.Entities;

namespace BusinessLayer.ProductManager.Queries
{
    /// <summary>
    /// QUERY pour récupérer des entités de types Categorie
    /// </summary>
    public class CategorieQuery
    {
        private readonly MonContexte _contexte;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="contexte">Contexte EF à utiliser</param>
        public CategorieQuery(MonContexte contexte)
        {
            _contexte = contexte;
        }

        /// <summary>
        /// Récupérer tous les produits
        /// </summary>
        /// <returns>IQueryable de Produit</returns>
        public IQueryable<Categorie> GetAll()
        {
            return _contexte.Categories;
        }

        /// <summary>
        /// Récupérer un produit par son ID
        /// </summary>
        /// <param name="id">Identifiant du produit à récupérer</param>
        /// <returns>IQueryable de Produit</returns>
        public IQueryable<Categorie> GetByID(int id)
        {
            return _contexte.Categories.Where(p => p.ID == id);
        }
    }
}
