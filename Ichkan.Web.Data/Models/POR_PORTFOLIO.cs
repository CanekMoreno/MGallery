using System;
using System.Collections.Generic;

namespace Ichkan.Web.Data.Models
{
    public class POR_PORTFOLIO
    {
        public POR_PORTFOLIO()
        {
            this.IMA_IMAGES = new List<IMA_IMAGES>();
        }

        public int POR_ID { get; set; }
        public string POR_NAME { get; set; }
        public string POR_DESC { get; set; }
        public Nullable<int> OBJ_ID { get; set; }
        public Nullable<int> STA_ID { get; set; }
        public virtual ICollection<IMA_IMAGES> IMA_IMAGES { get; set; }
        public virtual STA_STATE STA_STATE { get; set; }
    }
}
