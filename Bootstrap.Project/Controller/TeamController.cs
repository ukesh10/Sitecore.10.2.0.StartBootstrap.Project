using Sitecore.Configuration;
using Sitecore.Data;
using Sitecore.Data.Fields;
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
    public class TeamController : Controller
    {
        // GET: Hero
        public ActionResult Index()
        {
            var dataItem = RenderingContext.Current.Rendering.Item;
            var slideItem = (MultilistField)dataItem.Fields["slides"];
            var slides = slideItem.GetItems();
            return View("~/Views/Bootstrap/Components/Team.cshtml",slides);
        }
    }
}