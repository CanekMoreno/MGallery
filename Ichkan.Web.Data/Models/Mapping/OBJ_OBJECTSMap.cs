using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Ichkan.Web.Data.Models.Mapping
{
    public class OBJ_OBJECTSMap : EntityTypeConfiguration<OBJ_OBJECTS>
    {
        public OBJ_OBJECTSMap()
        {
            // Primary Key
            this.HasKey(t => t.OBJ_ID);

            // Properties
            this.Property(t => t.OBJ_NAME)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.OBJ_DESC)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("OBJ_OBJECTS");
            this.Property(t => t.OBJ_ID).HasColumnName("OBJ_ID");
            this.Property(t => t.OBJ_NAME).HasColumnName("OBJ_NAME");
            this.Property(t => t.OBJ_DESC).HasColumnName("OBJ_DESC");
        }
    }
}
