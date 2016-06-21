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
    /// QUERY pour récupérer des entités de types Produit
    /// </summary>
    public class ProduitQuery
    {
        private readonly MonContexte _contexte;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="contexte">Contexte EF à utiliser</param>
        public ProduitQuery(MonContexte contexte)
        {
            _contexte = contexte;
        }

        /// <summary>
        /// Récupérer tous les produits
        /// </summary>
        /// <returns>IQueryable de Produit</returns>
        public IQueryable<Produit> GetAll()
        {
            return _contexte.Produits;
        }

        /// <summary>
        /// Récupérer un produit par son ID
        /// </summary>
        /// <param name="id">Identifiant du produit à récupérer</param>
        /// <returns>IQueryable de Produit</returns>
        public Produit GetByID(int id)
        {
            return _contexte.Produits.Where(p => p.ID == id).FirstOrDefault();
        }

        /// <summary>
        /// Récupérer un produit par son nom
        /// </summary>
        /// <param name="Name">Nom du produit à récupérer</param>
        /// <returns>IQueryable de Produits</returns>
        public Produit GetByName(string Name)
        {
            return _contexte.Produits.Where(p => p.Nom == Name).FirstOrDefault();
        }


        /// <summary>
        /// Récupérer un produit par uen partie de son nom
        /// </summary>
        /// <param name="Name">Nom du produit à récupérer</param>
        /// <returns>IQueryable de Produits</returns>
        public IQueryable<Produit> GetByNameSearch(string partName)
        {
            return _contexte.Produits.Where(p => p.Nom.Contains(partName));
        }


        

        /// <summary>
        /// Récupérer les produits avec l'id categorie
        /// </summary>
        /// <param name="categID">id categorie</param>
        public IQueryable<Produit> GetByIdCategorie(int categID)
        {
            return _contexte.Produits.Where(p => p.CategorieID == categID);
        }

        /// <summary>
        /// Récupérer les produits d'une categorie avec son nom et un id
        /// </summary>
        /// <param name="categID">Identifiant de la categorie</param>
        /// <param name="categName">Nom de la categorie</param>
        public IQueryable<Produit> GetByCategNameAndId(int categID, string categName)
        {
            return _contexte.Produits.Where(p => p.CategorieID == categID).Where(p => p.Categorie.Libelle == categName);
        }
    }
}
