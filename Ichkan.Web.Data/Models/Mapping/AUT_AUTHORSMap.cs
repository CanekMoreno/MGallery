using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Ichkan.Web.Data.Models.Mapping
{
    public class AUT_AUTHORSMap : EntityTypeConfiguration<AUT_AUTHORS>
    {
        public AUT_AUTHORSMap()
        {
            // Primary Key
            this.HasKey(t => t.AUT_ID);

            // Properties
            this.Property(t => t.AUT_NAME)
                .HasMaxLength(100);

            this.Property(t => t.AUT_NICKNAME)
                .HasMaxLength(100);

            this.Property(t => t.AUT_MAIL)
                .HasMaxLength(300);

            // Table & Column Mappings
            this.ToTable("AUT_AUTHORS");
            this.Property(t => t.AUT_ID).HasColumnName("AUT_ID");
            this.Property(t => t.AUT_NAME).HasColumnName("AUT_NAME");
            this.Property(t => t.AUT_NICKNAME).HasColumnName("AUT_NICKNAME");
            this.Property(t => t.AUT_MAIL).HasColumnName("AUT_MAIL");
            this.Property(t => t.OBJ_ID).HasColumnName("OBJ_ID");
            this.Property(t => t.STA_ID).HasColumnName("STA_ID");

            // Relationships
            this.HasOptional(t => t.STA_STATE)
                .WithMany(t => t.AUT_AUTHORS)
                .HasForeignKey(d => new { d.OBJ_ID, d.STA_ID });

        }
    }
}
