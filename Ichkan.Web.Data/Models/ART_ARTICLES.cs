using System;
using System.Collections.Generic;

namespace Ichkan.Web.Data.Models
{
    public class ART_ARTICLES
    {
        public int ART_ID { get; set; }
        public string ART_TITTLE { get; set; }
        public string ART_SHORT_DESC { get; set; }
        public string ART_LONG_DESC { get; set; }
        public string ART_CONTENT { get; set; }
        public Nullable<System.DateTime> ART_REDACTION_DATE { get; set; }
        public Nullable<System.DateTime> ART_PUBLICACION_DATE { get; set; }
        public string ART_ORIGIN { get; set; }
        public Nullable<int> AUT_ID { get; set; }
        public Nullable<int> SEC_ID { get; set; }
        public Nullable<int> TAR_ID { get; set; }
        public Nullable<int> FUI_ID { get; set; }
        public Nullable<int> PLA_ID { get; set; }
        public Nullable<int> OBJ_ID { get; set; }
        public Nullable<int> STA_ID { get; set; }
        public virtual STA_STATE STA_STATE { get; set; }
    }
}
