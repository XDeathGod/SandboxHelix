using SandboxHelix.Feature.Poster.Models;
using SandboxHelix.Feature.Poster.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SandboxHelix.Feature.Poster.Services
{
    public class SitecoreContentService : IContentService
    {
        private readonly IDocumentRepository _repository;

        public SitecoreContentService()
        {
            _repository = new SitecoreDocumentsRepository();
        }
        public IDocument GetDocumentContent(string contentGuid)
        {

            return _repository.GetArticleContent(contentGuid);

        }
    }
}