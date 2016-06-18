using Modele.ProductManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using WPFProductManager.ViewModels.Common;

namespace WPFProductManager.ViewModels
{
    /// <summary>
    /// ViewModel représentant un Produit (avec son détail)
    /// Hérite de BaseViewModel
    /// </summary>
    public class DetailProduitViewModel : BaseViewModel
    {
        #region Variables

        private string _code;
        private string _nom;
        private string _status;
        private float _prix;
        private int _stock;
        private List<LogProduit> _logs;

        private Views.AjoutProduit _addProductWindow;
        private Views.Operation _operationWindow;

        private RelayCommand _commandOpenOperationWindow;
        private RelayCommand _commandOpenAddProductWindow;
        private RelayCommand _commandAddProduct;
        private RelayCommand _actionAddOperation;
        private RelayCommand _closeOperationWindow;
        private RelayCommand _commandcloseAddProductWindow;
        private RelayCommand _commandRemoveProduct;
        private RelayCommand _commandRemoveAllLogsProduct;

        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur par défaut
        /// <param name="p">Produit à transformer en DetailProduitViewModel</param>
        /// </summary>
        public DetailProduitViewModel(Produit p)
        {
            _code = p.Code;
            _nom = p.Nom;
            _stock = p.Stock;
            _status = p.Status;
            _prix = p.Prix;
            _logs = p.LogProduits.ToList();
        }

        #endregion

        #region Data Bindings

        /// <summary>
        /// Code du produit
        /// </summary>
        public string Code 
        {
            get {
                return _code;
            }
            set {
                _code = value;
                OnPropertyChanged("Code");
            }
        }

        /// <summary>
        /// Nom du produit
        /// </summary>
        public string Nom
        {
            get {
                return _nom;
            }
            set {
                _nom = value;
                OnPropertyChanged("Nom");
            }
        }

        /// <summary>
        /// Stock du produit
        /// </summary>
        public int Stock
        {
            get
            {
                return _stock;
            }
            set
            {
                _stock = value;
                OnPropertyChanged("Stock");
            }
        }

        /// <summary>
        /// Status du produit
        /// </summary>
        public string Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Prix du produit
        /// </summary>
        public float Prix
        {
            get
            {
                return _prix;
            }
            set
            {
                _prix = value;
                OnPropertyChanged("Prix");
            }
        }


        /// <summary>
        /// List de logs du produit
        /// </summary>
        public List<LogProduit> Logs
        {
            get
            {
                return _logs;
            }
            set
            {
                _logs = value;
                OnPropertyChanged("Logs");
            }
        }

        #endregion

        #region Commandes

        /// <summary>
        /// Commande pour ouvrir la fenêtre pour ajouter un log
        /// </summary>
        public ICommand CommandOpenOperationWindow
        {
            get
            {
                if (_commandOpenOperationWindow == null)
                    _commandOpenOperationWindow = new RelayCommand(() => this.ShowWindowOperation());
                return _commandOpenOperationWindow;
            }
        }

        /// <summary>
        /// Commande pour ouvrir la fenêtre pour ajouter un produit
        /// </summary>
        public ICommand CommandOpenAddProductWindow
        {
            get
            {
                if (_commandOpenAddProductWindow == null)
                    _commandOpenAddProductWindow = new RelayCommand(() => this.ShowAddProductWindow());
                return _commandOpenAddProductWindow;
            }
        }

        /// <summary>
        /// Commande pour traiter l'ajout d'un produit
        /// </summary>
        public ICommand CommandAddProduct
        {
            get
            {
                if (_commandAddProduct == null)
                    _commandAddProduct = new RelayCommand(() => this.AddProduct());
                return _commandAddProduct;
            }
        }

        /// <summary>
        /// Ferme la fenetre d'ajout d'un produit
        /// </summary>
        public ICommand CommandCloseAddProductWindow
        {
            get
            {
                if (_commandcloseAddProductWindow == null)
                    _commandcloseAddProductWindow = new RelayCommand(() => this.CloseAddProductWindow());
                return _commandcloseAddProductWindow;
            }
        }

        /// <summary>
        /// Ferme la fenetre d'ajout d'une operation
        /// </summary>
        public ICommand CloseOperationWindow
        {
            get
            {
                if (_closeOperationWindow == null)
                    _closeOperationWindow = new RelayCommand(() => this.CloseAddOperationWindow());
                return _closeOperationWindow;
            }
        }


        /// <summary>
        /// Ajoute l'operation puis ferme la fenetre operation
        /// </summary>
        public ICommand ActionAddOperation
        {
            get
            {
                if (_actionAddOperation == null)
                    _actionAddOperation = new RelayCommand(() => this.AddOperationButton());
                return _actionAddOperation;
            }
        }

        /// <summary>
        /// Supprime un produit de la liste
        /// </summary>
        public ICommand CommandRemoveProduct
        {
            get
            {
                if (_commandRemoveProduct == null)
                    _commandRemoveProduct = new RelayCommand(() => this.RemoveProduct());
                return _commandRemoveProduct;
            }
        }

        /// <summary>
        /// Supprime les logs d'un produit
        /// </summary>
        public ICommand CommandRemoveAllLogsProduct
        {
            get
            {
                if (_commandRemoveAllLogsProduct == null)
                    _commandRemoveAllLogsProduct = new RelayCommand(() => this.RemoveAllLogsProduct());
                return _commandRemoveAllLogsProduct;
            }
        }


        /// <summary>
        /// Permet l'ouverture de la fenêtre
        /// </summary>
        private void ShowWindowOperation()
        {
            _operationWindow = new Views.Operation();
            _operationWindow.DataContext = this;
            _operationWindow.ShowDialog();
        }


        /// <summary>
        /// Permet l'ouverture de la fenêtre d'ajout d'un produit
        /// </summary>
        private void ShowAddProductWindow()
        {
            _addProductWindow = new Views.AjoutProduit();
            _addProductWindow.DataContext = this;
            _addProductWindow.ShowDialog();
        }

        /// <summary>
        /// Permet de fermer la fenetre d'ajout d'un produit
        /// </summary>
        private void CloseAddProductWindow()
        {
            _addProductWindow.Close();
        }

        /// <summary>
        /// Permet de fermer la fenetre d'ajout d'un produit
        /// </summary>
        private void CloseAddOperationWindow()
        {
            _operationWindow.Close();
        }

        /// <summary>
        /// Ajoute un produit a la liste view model
        /// </summary>
        private void AddProduct()
        {
            this.CloseAddProductWindow();
        }


        /// <summary>
        /// Ajoute un produit a la liste view model
        /// </summary>
        private void AddOperationButton()
        {
            this.CloseAddOperationWindow();
        }

        /// <summary>
        /// Supprime un produit de la liste
        /// </summary>
        private void RemoveProduct()
        {
            MessageBoxResult messageBoxResult = MessageBox.Show(
                "Etes-vous certain de vouloir supprimer ce produit ?", 
                "Confirmation de suppression d'un produit", 
                MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                /// TODO - code remove listview product
            }
                
        }

        /// <summary>
        /// Supprime les logs d'un produit
        /// </summary>
        private void RemoveAllLogsProduct()
        {
            MessageBoxResult messageBoxResult = MessageBox.Show(
                "Etes-vous certain de vouloir supprimer les logs de ce produit ?",
                "Confirmation de suppression des logs",
                MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {

                /// TODO - code remove listview logs product
            }

        }

        #endregion
    }
}
