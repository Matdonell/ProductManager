using Modele.ProductManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.ProductManager.Entities
{
    public class LogProduit
    {
        public int ID { get; set; }
        public string Date { get; set; }
        public string LogInfo { get; set; }
        public Produit Produit { get; set; }
        public int ProduitId { get; set; }
    }
}
