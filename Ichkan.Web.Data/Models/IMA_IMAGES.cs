using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ichkan.Web.Data.Models
{
    public class IMA_IMAGES
    {
        public int IMA_ID { get; set; }
        public string IMA_NAME { get; set; }

        [Display(Name = "Título")]
        public string IMA_TITTLE { get; set; }
        public string IMA_DESC { get; set; }
        public string IMA_KEY_WORDS { get; set; }
        public string IMA_PATH { get; set; }
        public byte[] IMA_IMAGE { get; set; }
        public Nullable<System.DateTime> IMA_UPLOAD_DATE { get; set; }
        public Nullable<System.DateTime> IMA_UPDATE_DATE { get; set; }
        public Nullable<int> AUT_ID { get; set; }
        public Nullable<int> OBJ_ID { get; set; }
        public Nullable<int> STA_ID { get; set; }
        public Nullable<int> TYP_ID { get; set; }
        public Nullable<int> CAT_ID { get; set; }
        public Nullable<int> POR_ID { get; set; }
        public Nullable<int> USR_ID { get; set; }
        public Nullable<System.DateTime> IMA_DATE { get; set; }
        public virtual AUT_AUTHORS AUT_AUTHORS { get; set; }
        public virtual CAT_CATEGORY CAT_CATEGORY { get; set; }
        public virtual POR_PORTFOLIO POR_PORTFOLIO { get; set; }
        public virtual TYP_TYPES TYP_TYPES { get; set; }
        public virtual USR_USERS USR_USERS { get; set; }
        public virtual STA_STATE STA_STATE { get; set; }
        public string IMA_SOURCE
        {
            get { return "http://ichkan.com/galeria/" + IMA_PATH; }
        }

    }
}
