using System;
using System.Collections.Generic;

namespace Ichkan.Web.Data.Models
{
    public class TYP_TYPES
    {
        public TYP_TYPES()
        {
            this.IMA_IMAGES = new List<IMA_IMAGES>();
            this.MIT_MENU_ITEMS = new List<MIT_MENU_ITEMS>();
            this.USR_USERS = new List<USR_USERS>();
        }

        public int TYP_ID { get; set; }
        public string TYP_NAME { get; set; }
        public string TYP_DESC { get; set; }
        public Nullable<int> OBJ_ID { get; set; }
        public Nullable<int> STA_ID { get; set; }
        public virtual ICollection<IMA_IMAGES> IMA_IMAGES { get; set; }
        public virtual ICollection<MIT_MENU_ITEMS> MIT_MENU_ITEMS { get; set; }
        public virtual OBJ_OBJECTS OBJ_OBJECTS { get; set; }
        public virtual ICollection<USR_USERS> USR_USERS { get; set; }
    }
}
