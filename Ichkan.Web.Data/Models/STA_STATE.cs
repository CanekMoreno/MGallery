using System;
using System.Collections.Generic;

namespace Ichkan.Web.Data.Models
{
    public class STA_STATE
    {
        public STA_STATE()
        {
            this.ART_ARTICLES = new List<ART_ARTICLES>();
            this.AUT_AUTHORS = new List<AUT_AUTHORS>();
            this.CAT_CATEGORY = new List<CAT_CATEGORY>();
            this.COM_COMMENTS = new List<COM_COMMENTS>();
            this.IMA_IMAGES = new List<IMA_IMAGES>();
            this.MIT_MENU_ITEMS = new List<MIT_MENU_ITEMS>();
            this.POR_PORTFOLIO = new List<POR_PORTFOLIO>();
            this.USR_USERS = new List<USR_USERS>();
        }

        public int OBJ_ID { get; set; }
        public int STA_ID { get; set; }
        public string STA_NAME { get; set; }
        public string STA_DESC { get; set; }
        public virtual ICollection<ART_ARTICLES> ART_ARTICLES { get; set; }
        public virtual ICollection<AUT_AUTHORS> AUT_AUTHORS { get; set; }
        public virtual ICollection<CAT_CATEGORY> CAT_CATEGORY { get; set; }
        public virtual ICollection<COM_COMMENTS> COM_COMMENTS { get; set; }
        public virtual ICollection<IMA_IMAGES> IMA_IMAGES { get; set; }
        public virtual ICollection<MIT_MENU_ITEMS> MIT_MENU_ITEMS { get; set; }
        public virtual ICollection<POR_PORTFOLIO> POR_PORTFOLIO { get; set; }
        public virtual ICollection<USR_USERS> USR_USERS { get; set; }
    }
}
