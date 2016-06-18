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

            int PierreID = bm.AjouterClient(new Client() { Nom = "CHARLES", Prenom = "Pierre", Email = "pierre.charles@gmail.com" });
            int julienID = bm.AjouterClient(new Client() { Nom = "BRAT", Prenom = "Julien", Email = "bratjulien@gmail.com" });

            int commandePierre = bm.AjouterCommande(new Commande() { Reference="CMD001", Description="Commande de Pierre", Date="18/06/16", ClientId = PierreID});
            int commandeJulien = bm.AjouterCommande(new Commande() { Reference = "CMD002", Description = "Commande de Julien", Date = "18/06/16", ClientId = julienID });


            bm.AjouterProduit(new Produit() { Nom="Disque Dur", Status="En Stock", Stock=10, Prix=255.5F, CategorieID = 1});
            bm.AjouterProduit(new Produit() { Nom = "Carte graphique", Status = "En Stock", Stock = 5, Prix = 560.5F, CategorieID = 1 });
            bm.AjouterProduit(new Produit() { Nom = "Alimentation", Status = "Destockage", Stock = 2, Prix = 120.5F, CategorieID = 1 });

            bm.AjouterProduit(new Produit() { Nom = "Jambon cru", Status = "En Stock", Stock = 50, Prix = 10.5F, CategorieID = 2 });
            bm.AjouterProduit(new Produit() { Nom = "Pâte de campagne", Status = "En Stock", Stock = 10, Prix = 5.5F, CategorieID = 2 });
            bm.AjouterProduit(new Produit() { Nom = "Rôti de veau", Status = "En Stock", Stock = 5, Prix = 20.5F, CategorieID = 2 });

            bm.AjouterProduit(new Produit() { Nom = "Baguette au céréal", Status = "En Stock", Stock = 5, Prix = 0.80F, CategorieID = 3 });
            bm.AjouterProduit(new Produit() { Nom = "Pain de campagne", Status = "En Stock", Stock = 2, Prix = 2.2F, CategorieID = 3 });
            bm.AjouterProduit(new Produit() { Nom = "Pain au figue", Status = "En Stock", Stock = 20, Prix = 1.5F, CategorieID = 3 });



            System.Console.WriteLine("---- LISTE DES CATEGORIES -----");
            foreach (Categorie c in categories)
            {
                System.Console.WriteLine("Catégorie ID {0} : {1}", c.ID, c.Libelle);
            }
            System.Console.ReadKey();
        }
    }
}
