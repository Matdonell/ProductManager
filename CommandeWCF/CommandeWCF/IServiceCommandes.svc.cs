using BusinessLayer.ProductManager;
using Modele.ProductManager.Entities;
using System;
using System.Collections.Generic;

namespace CommandeWCF
{
    public class ServiceProductManager : IServiceCommandes
    {
        /**
         * Method to return all the commands from the business layer
         */
        public List<Commande> GetCommandes()
        {
            List<Commande> commandes = BusinessManager.Instance.getAllCommandes();
            return commandes;
        }

        /**
         * Method to return all the command for a client id from the business layer
         */
        public List<Commande> getClientCommandes(string idClient)
        {
            if (String.IsNullOrWhiteSpace(idClient))
            {
                throw new ArgumentNullException("idClient");
            }

            List<Commande> commandes = BusinessManager.Instance.GetByClientID(int.Parse(idClient));
            return commandes;

        }
    }
}
