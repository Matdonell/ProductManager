using Modele.ProductManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.ProductManager.Entities
{
    public class Commande
    {
        public int ID { get; set; }
        public string Reference { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public virtual ICollection<Produit> Produits { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
