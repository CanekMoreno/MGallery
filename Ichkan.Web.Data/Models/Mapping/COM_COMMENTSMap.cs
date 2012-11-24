using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Ichkan.Web.Data.Models.Mapping
{
    public class COM_COMMENTSMap : EntityTypeConfiguration<COM_COMMENTS>
    {
        public COM_COMMENTSMap()
        {
            // Primary Key
            this.HasKey(t => t.COM_ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("COM_COMMENTS");
            this.Property(t => t.COM_ID).HasColumnName("COM_ID");
            this.Property(t => t.COM_CONTNIDO).HasColumnName("COM_CONTNIDO");
            this.Property(t => t.USR_ID).HasColumnName("USR_ID");
            this.Property(t => t.OBJ_ID).HasColumnName("OBJ_ID");
            this.Property(t => t.STA_ID).HasColumnName("STA_ID");
            this.Property(t => t.IMA_ID).HasColumnName("IMA_ID");
            this.Property(t => t.ART_ID).HasColumnName("ART_ID");

            // Relationships
            this.HasOptional(t => t.STA_STATE)
                .WithMany(t => t.COM_COMMENTS)
                .HasForeignKey(d => new { d.OBJ_ID, d.STA_ID });

        }
    }
}
