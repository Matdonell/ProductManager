using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Modele.ProductManager.Entities;
using Modele.ProductManager.Initialisation;

namespace Modele.ProductManager
{
    /// <summary>
    /// Contexte EF héritant de la classe DbContext
    /// </summary>
    public class MonContexte : DbContext
    {
        /// <summary>
        /// Constructeur
        /// CAS 1 :
        /// Database.SetInitializer<MonContexte>(MonContexteInitializer) = > Supprimer et recréer la base en nitialisant ma base avec quelques données (idéal pour tester le contexte)
        /// CAS 2 :
        /// Database.SetInitializer<MonContexte>(null) => Utiliser la base définie dans la ConnectionStr telle qu'elle (utilisation "classique" une fois le contexte testé
        /// </summary>
        public MonContexte()
            : base("name=ConnectionStrPierre") 
        {
            Database.SetInitializer<MonContexte>(new MonContexteInitializer());
            //Database.SetInitializer<MonContexte>(null);
        }

        /// <summary>
        /// Surcharge du OnModelCreating pour ajouter ma configuration Fluent
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("dbo");
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
        }

        /// <summary>
        /// Mes Produits
        /// </summary>
        public DbSet<Produit> Produits { get; set; }

        /// <summary>
        /// Mes Catégories
        /// </summary>
        public DbSet<Categorie> Categories { get; set; }
    }
}
