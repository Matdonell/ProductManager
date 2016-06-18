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
    /// Configuration Fluent d'une Commande
    /// </summary>
    public class CommandeFluent : EntityTypeConfiguration<Commande>
    {
        /// <summary>
        /// Constructeur et définition du maping
        /// </summary>
        public CommandeFluent()
        {
            ToTable("APP_COMMANDE");
            HasKey(p => p.ID);

            Property(p => p.ID).HasColumnName("PRD_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Reference).HasColumnName("PRD_REFERENCE").IsRequired().HasMaxLength(100);
            Property(p => p.Description).HasColumnName("PRD_DESCRIPTION").IsRequired().HasMaxLength(100);
            Property(p => p.Date).HasColumnName("PRD_DATE").IsRequired();

            HasRequired(p => p.Client).WithMany(c => c.Commandes).HasForeignKey(p => p.ClientId);
        }
    }
}
