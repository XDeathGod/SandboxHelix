using SandboxHelix.Feature.Article.Repositories;
using SandboxHelix.Feature.Article.VIewModels;
using Sitecore;
using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using Sitecore.Mvc.Controllers;
using Sitecore.Mvc.Presentation;
using Sitecore.Resources.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SandboxHelix.Feature.Article.Controllers
{
    public class ArticleController : SitecoreController
    {
        private readonly IArticleRepository _repository;
        public ArticleController()
        {
            _repository = new SItecoreArticleRepository();
        }
        // GET: Media
        public ActionResult HeroSlider()
        {

            var viewmodel = new HeroSliderViewModel();

            if(!string.IsNullOrEmpty(RenderingContext.Current.Rendering.DataSource))
            {
                var contentItem = _repository.GetItem(RenderingContext.Current.Rendering.DataSource);

                if(contentItem != null)
                {
                    var heroImagesField = new MultilistField(contentItem.Fields["Hero Images"]);

                    if(heroImagesField != null)
                    {
                        var items = heroImagesField.GetItems();

                        var itemCounter = 0;

                        foreach (var item in items)
                        {
                            var mediaItem = (MediaItem)item;
                            viewmodel.HeroImages.Add(new HeroSliderImageViewModel()
                            {
                                AltText = mediaItem.Alt,
                                MediaUrl = MediaManager.GetMediaUrl(mediaItem),
                                isActive = itemCounter == 0
                            });
                            itemCounter++;
                            
                        }
                    }
                }
            }
            return View(viewmodel);
          
        }
    }
}