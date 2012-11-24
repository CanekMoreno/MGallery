using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Ichkan.Web.Data.Models.Mapping
{
    public class CON_CONTRACTSMap : EntityTypeConfiguration<CON_CONTRACTS>
    {
        public CON_CONTRACTSMap()
        {
            // Primary Key
            this.HasKey(t => t.CON_ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("CON_CONTRACTS");
            this.Property(t => t.CON_ID).HasColumnName("CON_ID");
            this.Property(t => t.CON_DATE).HasColumnName("CON_DATE");
            this.Property(t => t.CON_EXPIRATION_DATE).HasColumnName("CON_EXPIRATION_DATE");
            this.Property(t => t.USR_ID).HasColumnName("USR_ID");
            this.Property(t => t.OBJ_ID).HasColumnName("OBJ_ID");
            this.Property(t => t.STA_ID).HasColumnName("STA_ID");
            this.Property(t => t.TYP_ID).HasColumnName("TYP_ID");
            this.Property(t => t.CON_QUANTITY_DOWNLOADS).HasColumnName("CON_QUANTITY_DOWNLOADS");
            this.Property(t => t.CON_UPDATE_DATE).HasColumnName("CON_UPDATE_DATE");
        }
    }
}
