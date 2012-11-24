using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Ichkan.Web.Data.Models.Mapping
{
    public class STA_STATEMap : EntityTypeConfiguration<STA_STATE>
    {
        public STA_STATEMap()
        {
            // Primary Key
            this.HasKey(t => new { t.OBJ_ID, t.STA_ID });

            // Properties
            this.Property(t => t.OBJ_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.STA_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.STA_NAME)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.STA_DESC)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("STA_STATE");
            this.Property(t => t.OBJ_ID).HasColumnName("OBJ_ID");
            this.Property(t => t.STA_ID).HasColumnName("STA_ID");
            this.Property(t => t.STA_NAME).HasColumnName("STA_NAME");
            this.Property(t => t.STA_DESC).HasColumnName("STA_DESC");
        }
    }
}
