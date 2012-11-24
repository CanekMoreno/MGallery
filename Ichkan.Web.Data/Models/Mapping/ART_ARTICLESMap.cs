using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Ichkan.Web.Data.Models.Mapping
{
    public class ART_ARTICLESMap : EntityTypeConfiguration<ART_ARTICLES>
    {
        public ART_ARTICLESMap()
        {
            // Primary Key
            this.HasKey(t => t.ART_ID);

            // Properties
            this.Property(t => t.ART_TITTLE)
                .IsRequired();

            this.Property(t => t.ART_ORIGIN)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("ART_ARTICLES");
            this.Property(t => t.ART_ID).HasColumnName("ART_ID");
            this.Property(t => t.ART_TITTLE).HasColumnName("ART_TITTLE");
            this.Property(t => t.ART_SHORT_DESC).HasColumnName("ART_SHORT_DESC");
            this.Property(t => t.ART_LONG_DESC).HasColumnName("ART_LONG_DESC");
            this.Property(t => t.ART_CONTENT).HasColumnName("ART_CONTENT");
            this.Property(t => t.ART_REDACTION_DATE).HasColumnName("ART_REDACTION_DATE");
            this.Property(t => t.ART_PUBLICACION_DATE).HasColumnName("ART_PUBLICACION_DATE");
            this.Property(t => t.ART_ORIGIN).HasColumnName("ART_ORIGIN");
            this.Property(t => t.AUT_ID).HasColumnName("AUT_ID");
            this.Property(t => t.SEC_ID).HasColumnName("SEC_ID");
            this.Property(t => t.TAR_ID).HasColumnName("TAR_ID");
            this.Property(t => t.FUI_ID).HasColumnName("FUI_ID");
            this.Property(t => t.PLA_ID).HasColumnName("PLA_ID");
            this.Property(t => t.OBJ_ID).HasColumnName("OBJ_ID");
            this.Property(t => t.STA_ID).HasColumnName("STA_ID");

            // Relationships
            this.HasOptional(t => t.STA_STATE)
                .WithMany(t => t.ART_ARTICLES)
                .HasForeignKey(d => new { d.OBJ_ID, d.STA_ID });

        }
    }
}
