using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.ProductManager;
using Modele.ProductManager.Entities;

namespace Modele.ProductManager.Console
{
    /// <summary>
    /// Point d'entrée de l'application
    /// </summary>
    public class Program
    {
        /// <summary>
        ///  Main
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            BusinessManager bm = BusinessManager.Instance;
            List<Categorie> categories = bm.GetAllCategorie();

            /**
             * DATA TEST insert into databse with the first launch
             */
            int PierreID = bm.AjouterClient(new Client() { Nom = "CHARLES", Prenom = "Pierre", Email = "pierre.charles@gmail.com" });
            int julienID = bm.AjouterClient(new Client() { Nom = "BRAT", Prenom = "Julien", Email = "bratjulien@gmail.com" });

            int commandePierre = bm.AjouterCommande(new Commande() { Reference = "CMD001", Description = "Commande de Pierre", Date = "18/06/16", ClientId = PierreID });
            int commandeJulien = bm.AjouterCommande(new Commande() { Reference = "CMD002", Description = "Commande de Julien", Date = "18/06/16", ClientId = julienID });


            int productDDID0 = bm.AjouterProduit(new Produit() { Code = "X001", Nom = "Disque Dur", Status = "En Stock", Stock = 10, Prix = 255.5F, CategorieID = 1, CommandeID = commandeJulien });
            int productDDID1 = bm.AjouterProduit(new Produit() { Code = "X002", Nom = "Carte graphique", Status = "En Stock", Stock = 5, Prix = 560.5F, CategorieID = 1, CommandeID = commandePierre });
            int productDDID2 = bm.AjouterProduit(new Produit() { Code = "X003", Nom = "Alimentation", Status = "Destockage", Stock = 2, Prix = 120.5F, CategorieID = 1, CommandeID = commandePierre });

            bm.AjouterProduit(new Produit() { Code = "Y001", Nom = "Jambon cru", Status = "En Stock", Stock = 50, Prix = 10.5F, CategorieID = 2, CommandeID = commandeJulien });
            bm.AjouterProduit(new Produit() { Code = "Y002", Nom = "Pâte de campagne", Status = "En Stock", Stock = 10, Prix = 5.5F, CategorieID = 2, CommandeID = commandeJulien });
            bm.AjouterProduit(new Produit() { Code = "Y003", Nom = "Rôti de veau", Status = "En Stock", Stock = 5, Prix = 20.5F, CategorieID = 2, CommandeID = commandeJulien });

            bm.AjouterProduit(new Produit() { Code = "Z001", Nom = "Baguette au céréal", Status = "En Stock", Stock = 5, Prix = 0.80F, CategorieID = 3, CommandeID = commandePierre });
            bm.AjouterProduit(new Produit() { Code = "Z002", Nom = "Pain de campagne", Status = "En Stock", Stock = 2, Prix = 2.2F, CategorieID = 3, CommandeID = commandePierre });
            bm.AjouterProduit(new Produit() { Code = "Z003", Nom = "Pain au figue", Status = "En Stock", Stock = 20, Prix = 1.5F, CategorieID = 3, CommandeID = commandeJulien });


            bm.AjouterLogProduit(new LogProduit() { Date = "15/06/2016", LogInfo = "Ajout d'un disque !", ProduitId = productDDID0 });
            bm.AjouterLogProduit(new LogProduit() { Date = "18/06/2016", LogInfo = "Entré d'un Western Digital CB !", ProduitId = productDDID0 });
            bm.AjouterLogProduit(new LogProduit() { Date = "15/06/2016", LogInfo = "Ajout d'un disque !", ProduitId = productDDID1 });
            bm.AjouterLogProduit(new LogProduit() { Date = "18/06/2016", LogInfo = "Entré d'un Western Digital CB !", ProduitId = productDDID1 });
            bm.AjouterLogProduit(new LogProduit() { Date = "15/06/2016", LogInfo = "Ajout d'un disque !", ProduitId = productDDID1 });
            bm.AjouterLogProduit(new LogProduit() { Date = "18/06/2016", LogInfo = "Entré d'un Western Digital CB !", ProduitId = productDDID2 });
            bm.AjouterLogProduit(new LogProduit() { Date = "15/06/2016", LogInfo = "Ajout d'un disque !", ProduitId = productDDID2 });
            bm.AjouterLogProduit(new LogProduit() { Date = "18/06/2016", LogInfo = "Entré d'un Western Digital CB !", ProduitId = productDDID2 });
            bm.AjouterLogProduit(new LogProduit() { Date = "15/06/2016", LogInfo = "Ajout d'un disque !", ProduitId = productDDID2 });
            bm.AjouterLogProduit(new LogProduit() { Date = "18/06/2016", LogInfo = "Entré d'un Western Digital CB !", ProduitId = productDDID2 });


            System.Console.WriteLine("---- LISTE DES CATEGORIES -----");
            foreach (Categorie c in categories)
            {
                System.Console.WriteLine("Catégorie ID {0} : {1}", c.ID, c.Libelle);
            }
            System.Console.ReadKey();
        }
    }
}
