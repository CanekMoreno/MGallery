using System;
using System.Collections.Generic;

namespace Ichkan.Web.Data.Models
{
    public class COM_COMMENTS
    {
        public int COM_ID { get; set; }
        public string COM_CONTNIDO { get; set; }
        public Nullable<int> USR_ID { get; set; }
        public Nullable<int> OBJ_ID { get; set; }
        public Nullable<int> STA_ID { get; set; }
        public Nullable<int> IMA_ID { get; set; }
        public Nullable<int> ART_ID { get; set; }
        public virtual STA_STATE STA_STATE { get; set; }
    }
}
