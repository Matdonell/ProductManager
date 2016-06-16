using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFProductManager.Mock
{
    /// <summary>
    ///  Classe MOCK
    /// </summary>
    public class Produit
    {
        public string Code { get; set; }
        public string Nom { get; set; }
        public string Status { get; set; }
        public int Stock { get; set; }
        public float Prix { get; set; }
    }
}
