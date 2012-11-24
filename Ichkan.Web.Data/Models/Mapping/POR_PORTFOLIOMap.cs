using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Ichkan.Web.Data.Models.Mapping
{
    public class POR_PORTFOLIOMap : EntityTypeConfiguration<POR_PORTFOLIO>
    {
        public POR_PORTFOLIOMap()
        {
            // Primary Key
            this.HasKey(t => t.POR_ID);

            // Properties
            this.Property(t => t.POR_NAME)
                .HasMaxLength(100);

            this.Property(t => t.POR_DESC)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("POR_PORTFOLIO");
            this.Property(t => t.POR_ID).HasColumnName("POR_ID");
            this.Property(t => t.POR_NAME).HasColumnName("POR_NAME");
            this.Property(t => t.POR_DESC).HasColumnName("POR_DESC");
            this.Property(t => t.OBJ_ID).HasColumnName("OBJ_ID");
            this.Property(t => t.STA_ID).HasColumnName("STA_ID");

            // Relationships
            this.HasOptional(t => t.STA_STATE)
                .WithMany(t => t.POR_PORTFOLIO)
                .HasForeignKey(d => new { d.OBJ_ID, d.STA_ID });

        }
    }
}
