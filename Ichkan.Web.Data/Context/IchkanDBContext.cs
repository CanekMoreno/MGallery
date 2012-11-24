using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Ichkan.Web.Data.Models;
using Ichkan.Web.Data.Models.Mapping;

namespace Ichkan.Web.Data.Context
{
    public class IchkanDBContext : DbContext
    {
        static IchkanDBContext()
        {
            Database.SetInitializer<IchkanDBContext>(null);
        }

		public IchkanDBContext()
			: base("Name=IchkanDBContext")
		{
		}

        public DbSet<ART_ARTICLES> ART_ARTICLES { get; set; }
        public DbSet<AUT_AUTHORS> AUT_AUTHORS { get; set; }
        public DbSet<CAT_CATEGORY> CAT_CATEGORY { get; set; }
        public DbSet<COM_COMMENTS> COM_COMMENTS { get; set; }
        public DbSet<CON_CONTRACTS> CON_CONTRACTS { get; set; }
        public DbSet<IMA_IMAGES> IMA_IMAGES { get; set; }
        public DbSet<MIT_MENU_ITEMS> MIT_MENU_ITEMS { get; set; }
        public DbSet<OBJ_OBJECTS> OBJ_OBJECTS { get; set; }
        public DbSet<POR_PORTFOLIO> POR_PORTFOLIO { get; set; }
        public DbSet<STA_STATE> STA_STATE { get; set; }
        public DbSet<TYP_TYPES> TYP_TYPES { get; set; }
        public DbSet<USR_USERS> USR_USERS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ART_ARTICLESMap());
            modelBuilder.Configurations.Add(new AUT_AUTHORSMap());
            modelBuilder.Configurations.Add(new CAT_CATEGORYMap());
            modelBuilder.Configurations.Add(new COM_COMMENTSMap());
            modelBuilder.Configurations.Add(new CON_CONTRACTSMap());
            modelBuilder.Configurations.Add(new IMA_IMAGESMap());
            modelBuilder.Configurations.Add(new MIT_MENU_ITEMSMap());
            modelBuilder.Configurations.Add(new OBJ_OBJECTSMap());
            modelBuilder.Configurations.Add(new POR_PORTFOLIOMap());
            modelBuilder.Configurations.Add(new STA_STATEMap());
            modelBuilder.Configurations.Add(new TYP_TYPESMap());
            modelBuilder.Configurations.Add(new USR_USERSMap());
        }
    }
}
