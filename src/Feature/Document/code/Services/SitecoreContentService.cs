using SandboxHelix.Feature.Document.Models;
using SandboxHelix.Feature.Document.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SandboxHelix.Feature.Document.Services
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
            SandboxHelix.Feature.Document.Models.Document document = null;

            var item = _repository.GetArticleContent(contentGuid);

            if(item != null)
            {
                document = new  Models.Document();
                document.Id = item.ID.ToString();
                document.Title = item.Fields["Title"]?.Value;
                document.Body = item.Fields["Body"]?.Value;
            }

            return document;

        }
    }
}