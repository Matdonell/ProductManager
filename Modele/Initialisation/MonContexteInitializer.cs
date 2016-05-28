using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele.ProductManager.Entities;

namespace Modele.ProductManager.Initialisation
{
    /// <summary>
    /// Initializer réutilisable pour supprimer et recréer la base à chaque création de contexte
    /// La méthode Seed permet d'initialiser un certains nombre de données
    /// </summary>
    public class MonContexteInitializer : DropCreateDatabaseIfModelChanges<MonContexte>
    {
        /// <summary>
        /// Initialiser des données à la création du contexte
        /// </summary>
        /// <param name="context"></param>
        protected override void Seed(MonContexte context)
        {
            IList<Categorie> defaultCategories = new List<Categorie>();

            defaultCategories.Add(new Categorie() { Libelle = "Charcuterie" });
            defaultCategories.Add(new Categorie() { Libelle = "Produits laitiers" });
            defaultCategories.Add(new Categorie() { Libelle = "Liquides" });

            foreach (Categorie categ in defaultCategories)
                context.Categories.Add(categ);

            base.Seed(context);
        }
    }
}
