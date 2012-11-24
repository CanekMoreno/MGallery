using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ichkan.Web.Data.Context;

namespace Ichkan.Web.UI.Controllers
{
    public class GalleryController : Controller
    {

        private IchkanDBContext _context = new IchkanDBContext();
        //
        // GET: /Gallery/

        public ActionResult Index()
        {
            var images = _context.IMA_IMAGES; 
            return View(images.ToList());
        }

    }
}
