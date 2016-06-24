using BusinessLayer.ProductManager;
using Modele.ProductManager.Entities;
using System;
using System.Collections.Generic;

namespace CommandeWCF
{
    public class ServiceProductManager : IServiceCommandes
    {

        /// <summary>
        /// Method to return all the commands from the business layer
        /// </summary>
        /// <returns></returns>
        public List<Commande> GetCommandes()
        {
            return BusinessManager.Instance.getAllCommandes();
        }

        /// <summary>
        ///  Method to return all the command for a client id from the business layer
        /// </summary>
        /// <param name="idClient"></param>
        /// <returns></returns>
        public List<Commande> getClientCommandes(string idClient)
        {
            if (String.IsNullOrWhiteSpace(idClient))
            {
                throw new ArgumentNullException("idClient");
            }
            return BusinessManager.Instance.GetByClientID(int.Parse(idClient));

        }
    }
}
