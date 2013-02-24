// Copyright   : 你必须知道的.NET，第2版
// Author      : Anytao，http://www.anytao.com
// FileName    : Anytao.Inside.Ch14.Dynamic
// Release     : 2011/01/27 1.0
// Description : 14.3  动态变革：dynamic

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Anytao.Inside.Ch14.DynamicViewBag.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Profile = new Profile 
            { 
                Name = "Anytao", 
                Book = "你必须知道的.NET", 
                PublishOn = DateTime.Now, 
                Site = new Uri("http://book.anytao.com") 
            };

            ViewData["Profile"] = new Profile { Name = "Anytao", Book = "你必须知道的.NET", PublishOn = DateTime.Now, Site = new Uri("http://book.anytao.com") };

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        [AcceptVerbs()]
        public ActionResult Posts(string author, int page, int count)
        {
            // ...省略...
            return View();
        }
    }

    public class Profile
    {
        public string Name { get; set; }
        public string Book { get; set; }
        public DateTime PublishOn { get; set; }
        public Uri Site { get; set; }
    }
}
