using Modele.ProductManager;
using Modele.ProductManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ProductManager.Queries
{
    /// <summary>
    /// QUERY pour récupérer des entités de types LogProduit
    /// </summary>
    class LogProduitQuery
    {
        private readonly MonContexte _contexte;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="contexte">Contexte EF à utiliser</param>
        public LogProduitQuery(MonContexte contexte)
        {
            _contexte = contexte;
        }

        /// <summary>
        /// Récupérer tous les LogProduits
        /// </summary>
        /// <returns>IQueryable de Produit</returns>
        public IQueryable<LogProduit> GetAll()
        {
            return _contexte.LogProduits;
        }

        /// <summary>
        /// Récupérer un LogProduit par son ID
        /// </summary>
        /// <param name="id">Identifiant d'un LogProduit à récupérer</param>
        /// <returns>IQueryable de LogProduit</returns>
        public IQueryable<LogProduit> GetByID(int id)
        {
            return _contexte.LogProduits.Where(p => p.ID == id);
        }

        /// <summary>
        /// Récupérer les LogsProduits pour un ProductId
        /// </summary>
        /// <param name="id">Identifiant d'un Produit à récupérer</param>
        /// <returns>IQueryable de LogProduit</returns>
        public IQueryable<LogProduit> GetByProductID(int id)
        {
            return _contexte.LogProduits.Where(p => p.ProduitId == id);
        }
    }
}
