using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFProductManager.Mock
{
    /// <summary>
    /// Business MOCK
    /// </summary>
    public class BusinessManagerMock
    {
        private static BusinessManagerMock _businessManager = null;

        /// <summary>
        /// Constructeur
        /// </summary>
        private BusinessManagerMock()
        {
        }

        /// <summary>
        /// Récupérer l'instance du pattern Singleton
        /// </summary>
        public static BusinessManagerMock Instance
        {
            get
            {
                if (_businessManager == null)
                    _businessManager = new BusinessManagerMock();
                return _businessManager;
            }
        }

        /// <summary>
        /// Méthode pour simuler un appel au contexte pour renvoyer une liste de produits
        /// </summary>
        /// <returns></returns>
        public List<Produit> GetAllProduit()
        {
            List<Log> logs = new List<Log>();
            logs.Add(new Log { LogInfo = "Log information de test", Date = "17/06/2016" });
            logs.Add(new Log { LogInfo = "Log information de test 2", Date = "18/06/2016" });
            logs.Add(new Log { LogInfo = "Log information de test 3", Date = "19/06/2016" });
            logs.Add(new Log { LogInfo = "Log information de test 4", Date = "20/06/2016" });

            List<Produit> produits = new List<Produit>();
            produits.Add(new Produit { Logs = logs, Code = "2ER45", Nom = "Huile d'olive végétale" , Stock=10, Status= "TestStatus", Prix=50.2F });
            produits.Add(new Produit { Logs = logs, Code = "3ZZ21", Nom = "Magrets de canard" , Stock=120, Status= "TestStatus", Prix=85.5F});
            produits.Add(new Produit { Logs = logs, Code = "45WXB", Nom = "Terrine de truite", Stock=25, Status="TestStatus",Prix=120.2F });
            produits.Add(new Produit { Logs = logs, Code = "2E525", Nom = "Moutarde", Stock = 10, Status = "TestStatus", Prix = 50.2F });
            produits.Add(new Produit { Logs = logs, Code = "52221", Nom = "Patte carbonora", Stock = 120, Status = "TestStatus", Prix = 85.5F });
            produits.Add(new Produit { Logs = logs, Code = "4577B", Nom = "Epinards", Stock = 25, Status = "TestStatus", Prix = 120.2F });

            return produits;
        }
    }
}
