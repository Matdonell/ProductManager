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
    /// QUERY pour récupérer des entités de types Commande
    /// </summary>
    public class CommandeQuery
    {
        private readonly MonContexte _contexte;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="contexte">Contexte EF à utiliser</param>
        public CommandeQuery(MonContexte contexte)
        {
            _contexte = contexte;
        }

        /// <summary>
        /// Récupérer tous les produits
        /// </summary>
        /// <returns>IQueryable de Produit</returns>
        public IQueryable<Commande> GetAll()
        {
            return _contexte.Commandes;
        }

        /// <summary>
        /// Récupérer une commande par son ID
        /// </summary>
        /// <param name="id">Identifiant de la commande à récupérer</param>
        /// <returns>IQueryable de Commande</returns>
        public IQueryable<Commande> GetByID(int id)
        {
            return _contexte.Commandes.Where(p => p.ID == id);
        }

        /// <summary>
        /// Récupérer les commandes d'un client
        /// </summary>
        /// <param name="id">Identifiant du client à récupérer</param>
        /// <returns>IQueryable de Commande</returns>
        public IQueryable<Commande> GetByIDClient(int id)
        {
            return _contexte.Commandes.Where(p => p.ClientId == id);
        }
    }
}
