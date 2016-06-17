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
    /// Configuration Fluent d'un Client
    /// </summary>
    public class ClientFluent : EntityTypeConfiguration<Client>
    {
        /// <summary>
        /// Constructeur et définition du maping
        /// </summary>
        public ClientFluent()
        {
            ToTable("APP_CLIENT");
            HasKey(p => p.ID);

            Property(p => p.ID).HasColumnName("PRD_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Nom).HasColumnName("PRD_NOM").IsRequired().HasMaxLength(100);
            Property(p => p.Prenom).HasColumnName("PRD_PRENOM").IsRequired().HasMaxLength(100);
            Property(p => p.Email).HasColumnName("PRD_EMAIL").IsRequired().HasMaxLength(100);
        }
    }
}
