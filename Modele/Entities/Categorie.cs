using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.ProductManager.Entities
{
    /// <summary>
    /// Entité Catégorie
    /// </summary>
    public class Categorie
    {
        public int ID { get; set; }
        public string Libelle { get; set; }
        public virtual ICollection<Produit> Produits { get; set; }
    }
}
