using Modele.ProductManager;
using Modele.ProductManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ProductManager.Commands
{
    /// <summary>
    /// COMMAND pour ajouter / modifier et supprimer une commande
    /// </summary>
    class CommandeCommand
    {
        private readonly MonContexte _contexte;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="contexte">Contexte EF à utiliser</param>
        public CommandeCommand(MonContexte contexte)
        {
            _contexte = contexte;
        }

        /// <summary>
        /// Ajouter la commande en base à partir du contexte
        /// </summary>
        /// <param name="p">Commande à ajouter</param>
        /// <returns>Identifiant de la commande ajouté</returns>
        public int Ajouter(Commande cmd)
        {
            _contexte.Commandes.Add(cmd);
            return _contexte.SaveChanges();
        }

        /// <summary>
        /// Modifier un produit déjà présent en base à partir du cotnexte
        /// </summary>
        /// <param name="p">Produit à modifier</param>
        public void Modifier(Commande commande)
        {
            Commande upCommande = _contexte.Commandes.Where(cmd => cmd.ID == commande.ID).FirstOrDefault();
            if (upCommande != null)
            {
                upCommande.Reference = commande.Reference;
                upCommande.Description = commande.Description;
                upCommande.Date = commande.Date;
                upCommande.ClientId = commande.ClientId;
            }
            _contexte.SaveChanges();
        }

        /// <summary>
        /// Supprimer une commande en base à partir du contexte et de son identifiant
        /// </summary>
        /// <param name="commandeID">Identifiant de la commande à supprimer</param>
        public void Supprimer(int commandeID)
        {
            Commande delCommande = _contexte.Commandes.Where(prd => prd.ID == commandeID).FirstOrDefault();
            {
                _contexte.Commandes.Remove(delCommande);
            }
            _contexte.SaveChanges();
        }
    }
}
