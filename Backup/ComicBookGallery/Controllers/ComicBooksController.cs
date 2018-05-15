using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ContentResult Detail()
        {
            if(DateTime.Today.DayOfWeek == DayOfWeek.Monday){
                return Content($"Today is {DayOfWeek.Monday.ToString()}");
            }
            return Content("HEY");
        }
    }
}
