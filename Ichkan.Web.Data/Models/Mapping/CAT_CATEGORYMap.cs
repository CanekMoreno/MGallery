using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Ichkan.Web.Data.Models.Mapping
{
    public class CAT_CATEGORYMap : EntityTypeConfiguration<CAT_CATEGORY>
    {
        public CAT_CATEGORYMap()
        {
            // Primary Key
            this.HasKey(t => t.CAT_ID);

            // Properties
            this.Property(t => t.CAT_NAME)
                .HasMaxLength(100);

            this.Property(t => t.CAT_DESC)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("CAT_CATEGORY");
            this.Property(t => t.CAT_ID).HasColumnName("CAT_ID");
            this.Property(t => t.CAT_NAME).HasColumnName("CAT_NAME");
            this.Property(t => t.CAT_DESC).HasColumnName("CAT_DESC");
            this.Property(t => t.OBJ_ID).HasColumnName("OBJ_ID");
            this.Property(t => t.STA_ID).HasColumnName("STA_ID");

            // Relationships
            this.HasOptional(t => t.STA_STATE)
                .WithMany(t => t.CAT_CATEGORY)
                .HasForeignKey(d => new { d.OBJ_ID, d.STA_ID });

        }
    }
}
