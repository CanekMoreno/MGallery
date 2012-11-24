using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Ichkan.Web.Data.Models.Mapping
{
    public class IMA_IMAGESMap : EntityTypeConfiguration<IMA_IMAGES>
    {
        public IMA_IMAGESMap()
        {
            // Primary Key
            this.HasKey(t => t.IMA_ID);

            // Properties
            this.Property(t => t.IMA_NAME)
                .HasMaxLength(100);

            this.Property(t => t.IMA_TITTLE)
                .HasMaxLength(100);

            this.Property(t => t.IMA_KEY_WORDS)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("IMA_IMAGES");
            this.Property(t => t.IMA_ID).HasColumnName("IMA_ID");
            this.Property(t => t.IMA_NAME).HasColumnName("IMA_NAME");
            this.Property(t => t.IMA_TITTLE).HasColumnName("IMA_TITTLE");
            this.Property(t => t.IMA_DESC).HasColumnName("IMA_DESC");
            this.Property(t => t.IMA_KEY_WORDS).HasColumnName("IMA_KEY_WORDS");
            this.Property(t => t.IMA_PATH).HasColumnName("IMA_PATH");
            this.Property(t => t.IMA_IMAGE).HasColumnName("IMA_IMAGE");
            this.Property(t => t.IMA_UPLOAD_DATE).HasColumnName("IMA_UPLOAD_DATE");
            this.Property(t => t.IMA_UPDATE_DATE).HasColumnName("IMA_UPDATE_DATE");
            this.Property(t => t.AUT_ID).HasColumnName("AUT_ID");
            this.Property(t => t.OBJ_ID).HasColumnName("OBJ_ID");
            this.Property(t => t.STA_ID).HasColumnName("STA_ID");
            this.Property(t => t.TYP_ID).HasColumnName("TYP_ID");
            this.Property(t => t.CAT_ID).HasColumnName("CAT_ID");
            this.Property(t => t.POR_ID).HasColumnName("POR_ID");
            this.Property(t => t.USR_ID).HasColumnName("USR_ID");
            this.Property(t => t.IMA_DATE).HasColumnName("IMA_DATE");

            // Relationships
            this.HasOptional(t => t.AUT_AUTHORS)
                .WithMany(t => t.IMA_IMAGES)
                .HasForeignKey(d => d.AUT_ID);
            this.HasOptional(t => t.CAT_CATEGORY)
                .WithMany(t => t.IMA_IMAGES)
                .HasForeignKey(d => d.CAT_ID);
            this.HasOptional(t => t.POR_PORTFOLIO)
                .WithMany(t => t.IMA_IMAGES)
                .HasForeignKey(d => d.POR_ID);
            this.HasOptional(t => t.TYP_TYPES)
                .WithMany(t => t.IMA_IMAGES)
                .HasForeignKey(d => d.TYP_ID);
            this.HasOptional(t => t.USR_USERS)
                .WithMany(t => t.IMA_IMAGES)
                .HasForeignKey(d => d.USR_ID);
            this.HasOptional(t => t.STA_STATE)
                .WithMany(t => t.IMA_IMAGES)
                .HasForeignKey(d => new { d.OBJ_ID, d.STA_ID });

        }
    }
}
