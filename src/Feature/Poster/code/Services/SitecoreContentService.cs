using SandboxHelix.Feature.Poster.Models;
using SandboxHelix.Feature.Poster.Repositories;
using SandboxHelix.Foundation.Repository.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SandboxHelix.Feature.Poster.Services
{
    public class SitecoreContentService : IContentService
    {
        private readonly IContentRepository _repository;

        public SitecoreContentService()
        {
            _repository = new SitecoreContentRepository();
        }
        public IDocument GetDocumentContent(string contentGuid)
        {

            return _repository.GetContentItem<IDocument>(contentGuid);

        }
    }
}