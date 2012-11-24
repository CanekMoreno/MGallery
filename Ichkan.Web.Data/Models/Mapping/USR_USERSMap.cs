using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Ichkan.Web.Data.Models.Mapping
{
    public class USR_USERSMap : EntityTypeConfiguration<USR_USERS>
    {
        public USR_USERSMap()
        {
            // Primary Key
            this.HasKey(t => t.USR_ID);

            // Properties
            this.Property(t => t.USR_NAME)
                .HasMaxLength(100);

            this.Property(t => t.USR_NICKNAME)
                .HasMaxLength(100);

            this.Property(t => t.USR_MAIL)
                .HasMaxLength(200);

            this.Property(t => t.USR_PHONE)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("USR_USERS");
            this.Property(t => t.USR_ID).HasColumnName("USR_ID");
            this.Property(t => t.USR_NAME).HasColumnName("USR_NAME");
            this.Property(t => t.USR_NICKNAME).HasColumnName("USR_NICKNAME");
            this.Property(t => t.USR_PASSWORD).HasColumnName("USR_PASSWORD");
            this.Property(t => t.USR_MAIL).HasColumnName("USR_MAIL");
            this.Property(t => t.USR_CREATE_DATE).HasColumnName("USR_CREATE_DATE");
            this.Property(t => t.TYP_ID).HasColumnName("TYP_ID");
            this.Property(t => t.OBJ_ID).HasColumnName("OBJ_ID");
            this.Property(t => t.STA_ID).HasColumnName("STA_ID");
            this.Property(t => t.USR_PHONE).HasColumnName("USR_PHONE");

            // Relationships
            this.HasOptional(t => t.STA_STATE)
                .WithMany(t => t.USR_USERS)
                .HasForeignKey(d => new { d.OBJ_ID, d.STA_ID });
            this.HasOptional(t => t.TYP_TYPES)
                .WithMany(t => t.USR_USERS)
                .HasForeignKey(d => d.TYP_ID);

        }
    }
}
