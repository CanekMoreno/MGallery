using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Ichkan.Web.Data.Models.Mapping
{
    public class MIT_MENU_ITEMSMap : EntityTypeConfiguration<MIT_MENU_ITEMS>
    {
        public MIT_MENU_ITEMSMap()
        {
            // Primary Key
            this.HasKey(t => t.MIT_ID);

            // Properties
            this.Property(t => t.MIT_TITTLE)
                .HasMaxLength(200);

            this.Property(t => t.MIT_DESCRIPTION)
                .HasMaxLength(300);

            this.Property(t => t.MIT_PATH)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("MIT_MENU_ITEMS");
            this.Property(t => t.MIT_ID).HasColumnName("MIT_ID");
            this.Property(t => t.MIT_ORDER).HasColumnName("MIT_ORDER");
            this.Property(t => t.MIT_TITTLE).HasColumnName("MIT_TITTLE");
            this.Property(t => t.MIT_DESCRIPTION).HasColumnName("MIT_DESCRIPTION");
            this.Property(t => t.MIT_PATH).HasColumnName("MIT_PATH");
            this.Property(t => t.TYP_ID).HasColumnName("TYP_ID");
            this.Property(t => t.OBJ_ID).HasColumnName("OBJ_ID");
            this.Property(t => t.STA_ID).HasColumnName("STA_ID");

            // Relationships
            this.HasOptional(t => t.STA_STATE)
                .WithMany(t => t.MIT_MENU_ITEMS)
                .HasForeignKey(d => new { d.OBJ_ID, d.STA_ID });
            this.HasOptional(t => t.TYP_TYPES)
                .WithMany(t => t.MIT_MENU_ITEMS)
                .HasForeignKey(d => d.TYP_ID);

        }
    }
}
