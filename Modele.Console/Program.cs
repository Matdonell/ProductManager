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
            System.Console.WriteLine("---- LISTE DES CATEGORIES -----");
            foreach (Categorie c in categories)
            {
                System.Console.WriteLine("Catégorie ID {0} : {1}", c.ID, c.Libelle);
            }
        }
    }
}
