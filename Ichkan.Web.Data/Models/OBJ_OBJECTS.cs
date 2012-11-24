using System;
using System.Collections.Generic;

namespace Ichkan.Web.Data.Models
{
    public class OBJ_OBJECTS
    {
        public OBJ_OBJECTS()
        {
            this.TYP_TYPES = new List<TYP_TYPES>();
        }

        public int OBJ_ID { get; set; }
        public string OBJ_NAME { get; set; }
        public string OBJ_DESC { get; set; }
        public virtual ICollection<TYP_TYPES> TYP_TYPES { get; set; }
    }
}
