using System;
using System.Collections.Generic;

namespace Ichkan.Web.Data.Models
{
    public class AUT_AUTHORS
    {
        public AUT_AUTHORS()
        {
            this.IMA_IMAGES = new List<IMA_IMAGES>();
        }

        public int AUT_ID { get; set; }
        public string AUT_NAME { get; set; }
        public string AUT_NICKNAME { get; set; }
        public string AUT_MAIL { get; set; }
        public Nullable<int> OBJ_ID { get; set; }
        public Nullable<int> STA_ID { get; set; }
        public virtual ICollection<IMA_IMAGES> IMA_IMAGES { get; set; }
        public virtual STA_STATE STA_STATE { get; set; }
    }
}
