using System;
using System.Collections.Generic;

namespace Ichkan.Web.Data.Models
{
    public class MIT_MENU_ITEMS
    {
        public int MIT_ID { get; set; }
        public Nullable<int> MIT_ORDER { get; set; }
        public string MIT_TITTLE { get; set; }
        public string MIT_DESCRIPTION { get; set; }
        public string MIT_PATH { get; set; }
        public Nullable<int> TYP_ID { get; set; }
        public Nullable<int> OBJ_ID { get; set; }
        public Nullable<int> STA_ID { get; set; }
        public virtual STA_STATE STA_STATE { get; set; }
        public virtual TYP_TYPES TYP_TYPES { get; set; }
    }
}
