using Sitecore;
using Sitecore.Data.Items;
using Sitecore.Mvc.Controllers;
using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SandboxHelix.Feature.Article.Controllers
{
    public class ArticleController : SitecoreController
    { // GET: Media
        public ActionResult HeroSlider()
        {
            Item contentItem = null;
            var database = Context.Database;

            if (database != null)
            {
                if (!(string.IsNullOrEmpty(RenderingContext.Current.Rendering.DataSource)))
                {
                    contentItem = database.GetItem(new Sitecore.Data.ID(RenderingContext.Current.Rendering.DataSource));
                }
            }
            return View(contentItem);
        }
    }
}