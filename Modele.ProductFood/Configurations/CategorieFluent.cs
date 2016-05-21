using Modele.ProductFood.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.ProductFood.Configurations
{
    /// <summary>
    /// Configuration Fluent d'une Categorie
    /// </summary>
    public class CategorieFluent : EntityTypeConfiguration<Categorie>
    {
        /// <summary>
        /// Constructeur et définition du maping
        /// </summary>
        public CategorieFluent()
        {
            ToTable("APP_CATEGORIE");
            HasKey(c => c.ID);

            Property(c => c.ID).HasColumnName("CAT_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Libelle).HasColumnName("CAT_NOM").IsRequired().HasMaxLength(100);
        }
    }
}
