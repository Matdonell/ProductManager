using BusinessLayer.ProductManager;
using Modele.ProductManager.Entities;
using System;
using System.Collections.Generic;

namespace CommandeWCF
{
    public class Service1 : IServiceCommandes
    {
        /**
         * Method to return all the commands from the business layer
         */
        public string GetCommandes()
        {
            List<Commande> commandes = BusinessManager.Instance.getAllCommandes();
            var javaScriptSerializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            return javaScriptSerializer.Serialize(commandes);
        }

        /**
         * Method to return all the command for a client id from the business layer
         */
        public string getClientCommandes(string idClient)
        {
            if (String.IsNullOrWhiteSpace(idClient))
            {
                throw new ArgumentNullException("idClient");
            }

            List<Commande> commandes = BusinessManager.Instance.GetByClientID(int.Parse(idClient));
            var javaScriptSerializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            return javaScriptSerializer.Serialize(commandes);

        }
    }
}
