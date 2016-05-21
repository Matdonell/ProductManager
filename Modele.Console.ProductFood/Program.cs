using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using BusinessLayer.ProductFood;
using Modele.ProductFood.Entities;

namespace Modele.Console.ProductFood
{
    /// <summary>
    /// Point d'entrée de l'application
    /// </summary>
    class Program
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
