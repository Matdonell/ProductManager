using Modele.ProductManager.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.ProductManager.Configurations
{
    /// <summary>
    /// Configuration Fluent d'un LogProduit
    /// </summary>
    public class LogProduiFluent : EntityTypeConfiguration<LogProduit>
    {
        /// <summary>
        /// Constructeur et définition du maping
        /// </summary>
        public LogProduiFluent()
        {
            ToTable("APP_LOGPRODUIT");
            HasKey(p => p.ID);

            Property(p => p.ID).HasColumnName("PRD_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Date).HasColumnName("PRD_DATE").IsRequired().HasMaxLength(100);
            Property(p => p.LogInfo).HasColumnName("PRD_LOGINFO").IsRequired().HasMaxLength(100);

            HasRequired(p => p.Produit).WithMany(c => c.LogProduits).HasForeignKey(f => f.ProduitId);
        }
    }
}
