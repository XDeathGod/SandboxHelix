using SandboxHelix.Feature.Poster.Services;
using SandboxHelix.Feature.Poster.ViewModels;
using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SandboxHelix.Feature.Poster.Controllers
{
    public class PosterController : Controller
    {
        private readonly IContentService _contentService;

        private readonly ICommentService _commentService;

        public PosterController()
        {
            _commentService = new BlogCommentService();
            _contentService = new SitecoreContentService();
        }

        public ViewResult BlogPost()
        {
            var viewModel = new BlogPostViewModel();

            if(!string.IsNullOrEmpty(RenderingContext.Current.Rendering.DataSource))
            {
                var blogContent = _contentService.GetDocumentContent(RenderingContext.Current.Rendering.DataSource);

                if(blogContent != null)
                {
                    viewModel.Title = blogContent.Title;
                    viewModel.Body = blogContent.Body;

                    var comments = _commentService.GetComments(blogContent.Id);

                    if(comments != null)
                    {
                        foreach (var item in comments)
                        {
                            viewModel.Comments.Add(new BlogCommentViewModel()
                            {
                                Comment = item.Comment,
                                Name = item.Name,
                                DatePosted = item.DatePosted
                            });
                        }
                    }
                }
            }

            return View(viewModel);

        }
    }
}