using Modele.ProductManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.ProductManager.Entities;

namespace BusinessLayer.ProductManager.Commands
{
    /// <summary>
    /// COMMAND pour ajouter / modifier et supprimer un LogProduit
    /// </summary>
    public class LogProduitCommand
    {
        private readonly MonContexte _contexte;

        /// <summary>
        /// Constructeur de LogProduitCommand
        /// </summary>
        /// <param name="contexte">Contexte EF à utiliser</param>

        public LogProduitCommand(MonContexte contexte)
        {
            _contexte = contexte;
        }

        /// <summary>
        /// Ajouter le LogProduit en base
        /// </summary>
        /// <param name="p">LogProduit à ajouter</param>
        /// <returns>Identifiant du LogProduit ajouté</returns>
        public int Ajouter(LogProduit logProd)
        {
            _contexte.LogProduits.Add(logProd);
            return _contexte.SaveChanges();
        }

        /// <summary>
        /// Modifier un LogProduit
        /// </summary>
        /// <param name="p">LogProduit à modifier</param>
        public void Modifier(LogProduit logProd)
        {
            LogProduit upLogProduit = _contexte.LogProduits.Where(log => log.ID == logProd.ID).FirstOrDefault();
            if (upLogProduit != null)
            {
                upLogProduit.LogInfo = logProd.LogInfo;
                upLogProduit.Date = logProd.Date;
                upLogProduit.ProduitId = logProd.ProduitId;
            }
            _contexte.SaveChanges();
        }

        /// <summary>
        /// Supprimer un LogProduit
        /// </summary>
        /// <param name="LogProduitID">Identifiant du LogProduit à supprimer</param>
        public void Supprimer(int LogProduitID)
        {
            LogProduit delLogProduit = _contexte.LogProduits.Where(log => log.ID == LogProduitID).FirstOrDefault();
            if (delLogProduit != null)
            {
                _contexte.LogProduits.Remove(delLogProduit);
            }
            _contexte.SaveChanges();
        }

    }
}
