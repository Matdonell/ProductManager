using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.ProductManager.Commands;
using BusinessLayer.ProductManager.Queries;
using Modele.ProductManager;
using Modele.ProductManager.Entities;

namespace BusinessLayer.ProductManager
{
    /// <summary>
    /// BusinessManager de la BusinessLayer
    /// Cette classe est un singleton est instancie un contexte EF dans son constructeur
    /// </summary>
    public class BusinessManager
    {
        private readonly MonContexte contexte;
        private static BusinessManager _businessManager = null;

        /// <summary>
        /// Constructeur, initialisation du contexte EF
        /// </summary>
        private BusinessManager()
        {
            contexte = new MonContexte();
        }

        /// <summary>
        /// Récupérer l'instance du pattern Singleton
        /// </summary>
        public static BusinessManager Instance
        {
            get
            {
                if (_businessManager == null)
                    _businessManager = new BusinessManager();
                return _businessManager;
            }
        }

        #region Produit

        /// <summary>
        /// Récupérer une liste de produit en base
        /// </summary>
        /// <returns>Liste de Produit</returns>
        public List<Produit> GetAllProduit()
        {
            ProduitQuery pq = new ProduitQuery(contexte);
            return pq.GetAll().ToList();
        }

        /// <summary>
        /// Ajouter un produit en base
        /// </summary>
        /// <param name="produit">Produit à ajouter</param>
        /// <returns>identifiant du nouveau produit</returns>
        public int AjouterProduit(Produit produit)
        {
            // TODO : ajouter des contrôles sur le produit (exemple : vérification de champ, etc.)
            ProduitCommand productCommand = new ProduitCommand(contexte);
            return productCommand.Ajouter(produit);
        }


        public int GetMaxProductId()
        {
            ProduitQuery productQuery = new ProduitQuery(contexte);
            return productQuery.GetMaxProductID();
        }

        /// <summary>
        /// Modifier un produit en base
        /// </summary>
        /// <param name="p">Produit à modifier</param>
        public void ModifierProduit(Produit p)
        {
            // TODO : ajouter des contrôles sur le produit (exemple : vérification de champ, etc.)
            ProduitCommand pc = new ProduitCommand(contexte);
            pc.Modifier(p);
        }

        /// <summary>
        /// Supprimer une produit en base
        /// </summary>
        /// <param name="produitID">Identifiant du produit à supprimer</param>
        public void SupprimerProduit(int produitID)
        {
            ProduitCommand pc = new ProduitCommand(contexte);
            pc.Supprimer(produitID);
        }

        /// <summary>
        /// récupérer un produit avec son id
        /// </summary>
        /// <param name="produitID">Identifiant du produit à récupérer</param>
        public Produit GetProductById(int produitID)
        {
            ProduitQuery prdQuery = new ProduitQuery(contexte);
            return prdQuery.GetByID(produitID);
        }

        /// <summary>
        /// Récupérer les produits d'une categorie avec son nom et un id
        /// </summary>
        /// <param name="categID">Identifiant de la categorie</param>
        /// <param name="categName">Nom de la categorie</param>
        public List<Produit> GetProductsByCategoryIdAndName(int categID, string categName)
        {
            ProduitQuery prdQuery = new ProduitQuery(contexte);
            return prdQuery.GetByCategNameAndId(categID, categName).ToList();
        }

        /// <summary>
        /// Récupérer les produits avec une partie de son nom
        /// </summary>
        /// <param name="partStringme">Partie de string</param>
        public List<Produit> GetProductsByNameSearch(String partStringme)
        {
            ProduitQuery produitQuery = new ProduitQuery(contexte);
            return produitQuery.GetByNameSearch(partStringme).ToList();
        }

        /// <summary>
        /// Récupérer les produits d'une categorie avec son id
        /// </summary>
        /// <param name="categID">Identifiant de la categorie</param>
        public List<Produit> GetProductsByCategoryId(int categID)
        {
            ProduitQuery prdQuery = new ProduitQuery(contexte);
            return prdQuery.GetByIdCategorie(categID).ToList();
        }

        /// <summary>
        /// Récupérer un produit avec son nom
        /// </summary>
        /// <param name="productName">Nom du produit</param>
        public Produit GetProductsByName(String productName)
        {
            ProduitQuery prdQuery = new ProduitQuery(contexte);
            return prdQuery.GetByName(productName);
        }


        #endregion

        #region Categorie

        /// <summary>
        /// Récupérer une liste de catégories en base
        /// </summary>
        /// <returns>Liste de Categorie</returns>
        public List<Categorie> GetAllCategorie()
        {
            try
            {
                CategorieQuery pq = new CategorieQuery(contexte);
                return pq.GetAll().ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.InnerException);
            }
            return null;
        }


        #endregion

        #region LogProduit
        /// <summary>
        /// Récupérer une liste de logProduit en base
        /// </summary>
        /// <returns>Liste de LogProduits</returns>
        public List<LogProduit> getAllLogProduit()
        {
            LogProduitQuery logQuery = new LogProduitQuery(contexte);
            return logQuery.GetAll().ToList();
        }

        /// <summary>
        /// Ajouter un LogProduit en base
        /// </summary>
        /// <param name="p">LogProduit à ajouter</param>
        /// <returns>identifiant du nouveau LogProduit</returns>
        public int AjouterLogProduit(LogProduit log)
        {
            LogProduitCommand logCmd = new LogProduitCommand(contexte);
            return logCmd.Ajouter(log);
        }

        /// <summary>
        /// Modifier un LogProduit en base
        /// </summary>
        /// <param name="p">LogProduit à modifier</param>
        public void ModifierLogProduit(LogProduit log)
        {
            // Contôle des champs
            LogProduitCommand logCmd = new LogProduitCommand(contexte);
            logCmd.Modifier(log);
        }

        /// <summary>
        /// Supprimer une logProduit en base
        /// </summary>
        /// <param name="logProduitID">Identifiant du logProduit à supprimer</param>
        public void SupprimerLogProduit(int logProduitID)
        {
            LogProduitCommand logCmd = new LogProduitCommand(contexte);
            logCmd.Supprimer(logProduitID);
        }

        /// <summary>
        /// récupérer les logs d'un produit
        /// </summary>
        /// <param name="ProduitID">Identifiant du produit</param>
        public List<LogProduit> GetByProductID(int ProduitID)
        {
            LogProduitQuery logQuery = new LogProduitQuery(contexte);
            return logQuery.GetByProductID(ProduitID).ToList();
        }
        #endregion

        #region Commande
        /// <summary>
        /// Récupérer une liste de commandes en base
        /// </summary>
        /// <returns>Liste de Commandes</returns>
        public List<Commande> getAllCommandes()
        {
            CommandeQuery commandeQuery = new CommandeQuery(contexte);
            return commandeQuery.GetAll().ToList();
        }

        /// <summary>
        /// Ajouter une commande en base
        /// </summary>
        /// <param name="p">Commande à ajouter</param>
        /// <returns>identifiant de la nouvelle commande</returns>
        public int AjouterCommande(Commande cmd)
        {
            CommandeCommand commandeCmd = new CommandeCommand(contexte);
            return commandeCmd.Ajouter(cmd);
        }

        /// <summary>
        /// Modifier une commande en base
        /// </summary>
        /// <param name="p">Commande à modifier</param>
        public void ModifierCommande(Commande cmd)
        {
            // Contôle des champs
            CommandeCommand commandeCmd = new CommandeCommand(contexte);
            commandeCmd.Modifier(cmd);
        }

        /// <summary>
        /// Supprimer une commande en base
        /// </summary>
        /// <param name="commandeID">Identifiant d'une commande à supprimer</param>
        public void SupprimerCommande(int commandeID)
        {
            LogProduitCommand commandeCmd = new LogProduitCommand(contexte);
            commandeCmd.Supprimer(commandeID);
        }

        /// <summary>
        /// récupérer les commandes d'un client
        /// </summary>
        /// <param name="ClientID">Identifiant du client</param>
        public List<Commande> GetByClientID(int clientID)
        {
            CommandeQuery commandeQuery = new CommandeQuery(contexte);
            return commandeQuery.GetByIDClient(clientID).ToList();
        }
        #endregion

        #region Client
        /// <summary>
        /// Récupérer une liste de clients en base
        /// </summary>
        /// <returns>Liste de Clients</returns>
        public List<Client> getAllClients()
        {
            ClientQuery clientQuery = new ClientQuery(contexte);
            return clientQuery.GetAll().ToList();
        }

        /// <summary>
        /// Ajouter d'un client en base
        /// </summary>
        /// <param name="p">client à ajouter</param>
        /// <returns>identifiant du nouveau client</returns>
        public int AjouterClient(Client cli)
        {
            ClientCommand clientCmd = new ClientCommand(contexte);
            return clientCmd.Ajouter(cli);
        }

        /// <summary>
        /// Modifier un client en base
        /// </summary>
        /// <param name="p">Client à modifier</param>
        public void ModifierClient(Client cli)
        {
            // Contôle des champs
            ClientCommand clientCmd = new ClientCommand(contexte);
            clientCmd.Modifier(cli);
        }

        /// <summary>
        /// Supprimer un client en base
        /// </summary>
        /// <param name="clientID">Identifiant d'un client à supprimer</param>
        public void SupprimerClient(int clientID)
        {
            ClientCommand clientCmd = new ClientCommand(contexte);
            clientCmd.Supprimer(clientID);
        }
        #endregion
    }
}
