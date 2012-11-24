using System;
using System.Collections.Generic;

namespace Ichkan.Web.Data.Models
{
    public class USR_USERS
    {
        public USR_USERS()
        {
            this.IMA_IMAGES = new List<IMA_IMAGES>();
        }

        public int USR_ID { get; set; }
        public string USR_NAME { get; set; }
        public string USR_NICKNAME { get; set; }
        public string USR_PASSWORD { get; set; }
        public string USR_MAIL { get; set; }
        public Nullable<System.DateTime> USR_CREATE_DATE { get; set; }
        public Nullable<int> TYP_ID { get; set; }
        public Nullable<int> OBJ_ID { get; set; }
        public Nullable<int> STA_ID { get; set; }
        public string USR_PHONE { get; set; }
        public virtual ICollection<IMA_IMAGES> IMA_IMAGES { get; set; }
        public virtual STA_STATE STA_STATE { get; set; }
        public virtual TYP_TYPES TYP_TYPES { get; set; }
    }
}
