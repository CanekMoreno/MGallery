using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Ichkan.Web.Data.Models.Mapping
{
    public class TYP_TYPESMap : EntityTypeConfiguration<TYP_TYPES>
    {
        public TYP_TYPESMap()
        {
            // Primary Key
            this.HasKey(t => t.TYP_ID);

            // Properties
            this.Property(t => t.TYP_NAME)
                .HasMaxLength(100);

            this.Property(t => t.TYP_DESC)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("TYP_TYPES");
            this.Property(t => t.TYP_ID).HasColumnName("TYP_ID");
            this.Property(t => t.TYP_NAME).HasColumnName("TYP_NAME");
            this.Property(t => t.TYP_DESC).HasColumnName("TYP_DESC");
            this.Property(t => t.OBJ_ID).HasColumnName("OBJ_ID");
            this.Property(t => t.STA_ID).HasColumnName("STA_ID");

            // Relationships
            this.HasOptional(t => t.OBJ_OBJECTS)
                .WithMany(t => t.TYP_TYPES)
                .HasForeignKey(d => d.OBJ_ID);

        }
    }
}
