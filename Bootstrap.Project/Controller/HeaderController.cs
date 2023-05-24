using Sitecore.Configuration;
using Sitecore.Data;
using Sitecore.IO;
using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Windows.Forms;

namespace Bootstrap.Project.Controllers
{
    public class HeaderController : Controller
    {
        // GET: Hero
        public ActionResult Index()
        {
            var dataItem = RenderingContext.Current.Rendering.Item;
            return View("~/Views/Bootstrap/Components/Header.cshtml",dataItem);
        }
    }
}