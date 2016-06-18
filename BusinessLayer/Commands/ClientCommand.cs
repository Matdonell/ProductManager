using Modele.ProductManager;
using Modele.ProductManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ProductManager.Commands
{
    public class ClientCommand
    {
        private readonly MonContexte _contexte;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="contexte">Contexte EF à utiliser</param>
        public ClientCommand(MonContexte contexte)
        {
            _contexte = contexte;
        }

        /// <summary>
        /// Ajouter le client en base à partir du contexte
        /// </summary>
        /// <param name="p">Client à ajouter</param>
        /// <returns>Identifiant du produit ajouté</returns>
        public int Ajouter(Client cl)
        {
            _contexte.Clients.Add(cl);
            return _contexte.SaveChanges();
        }

        /// <summary>
        /// Modifier un client déjà présent en base à partir du cotnexte
        /// </summary>
        /// <param name="p">Client à modifier</param>
        public void Modifier(Client cl)
        {
            Client upClient = _contexte.Clients.Where(prd => prd.ID == cl.ID).FirstOrDefault();
            if (upClient != null)
            {
                upClient.Nom = cl.Nom;
                upClient.Email = cl.Email;
                upClient.Prenom = cl.Prenom;
            }
            _contexte.SaveChanges();
        }

        /// <summary>
        /// Supprimer un Client
        /// </summary>
        /// <param name="ClientID">Identifiant du Client à supprimer</param>
        public void Supprimer(int ClientID)
        {
            Client delClient = _contexte.Clients.Where(cli => cli.ID == ClientID).FirstOrDefault();
            if (delClient != null)
            {
                _contexte.Clients.Remove(delClient);
            }
            _contexte.SaveChanges();
        }

    }
}
