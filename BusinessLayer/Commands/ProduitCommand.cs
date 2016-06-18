using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.ProductManager;
using Modele.ProductManager.Entities;

namespace BusinessLayer.ProductManager.Commands
{
    /// <summary>
    /// COMMAND pour ajouter / modifier et supprimer un produit
    /// </summary>
    public class ProduitCommand
    {
        private readonly MonContexte _contexte;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="contexte">Contexte EF à utiliser</param>
        public ProduitCommand(MonContexte contexte)
        {
            _contexte = contexte;
        }

        /// <summary>
        /// Ajouter le produit en base à partir du contexte
        /// </summary>
        /// <param name="p">Produit à ajouter</param>
        /// <returns>Identifiant du produit ajouté</returns>
        public int Ajouter(Produit p)
        {
            _contexte.Produits.Add(p);
            return _contexte.SaveChanges();
        }

        /// <summary>
        /// Modifier un produit déjà présent en base à partir du cotnexte
        /// </summary>
        /// <param name="p">Produit à modifier</param>
        public void Modifier(Produit p)
        {
            Produit upPrd = _contexte.Produits.Where(prd => prd.ID == p.ID).FirstOrDefault();
            if (upPrd != null)
            {
                upPrd.Code = p.Code;
                upPrd.Nom = p.Nom;
                upPrd.Prix = p.Prix;
                upPrd.Status = p.Status;
                upPrd.Stock = p.Stock;
                upPrd.CategorieID = p.CategorieID;
            }
            _contexte.SaveChanges();
        }

        /// <summary>
        /// Supprimer un produit en base à partir du contexte et de son identifiant
        /// </summary>
        /// <param name="produitID">Identifiant du produit à supprimer</param>
        public void Supprimer(int produitID)
        {
            Produit delPrd = _contexte.Produits.Where(prd => prd.ID == produitID).FirstOrDefault();
            if (delPrd != null)
            {
                _contexte.Produits.Remove(delPrd);
            }
            _contexte.SaveChanges();
        }
    }
}
