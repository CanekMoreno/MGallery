using System;
using System.Collections.Generic;

namespace Ichkan.Web.Data.Models
{
    public class CON_CONTRACTS
    {
        public int CON_ID { get; set; }
        public Nullable<System.DateTime> CON_DATE { get; set; }
        public Nullable<System.DateTime> CON_EXPIRATION_DATE { get; set; }
        public Nullable<int> USR_ID { get; set; }
        public Nullable<int> OBJ_ID { get; set; }
        public Nullable<int> STA_ID { get; set; }
        public Nullable<int> TYP_ID { get; set; }
        public Nullable<decimal> CON_QUANTITY_DOWNLOADS { get; set; }
        public Nullable<System.DateTime> CON_UPDATE_DATE { get; set; }
    }
}
