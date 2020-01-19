using Glass.Mapper.Sc;
using SandboxHelix.Feature.Poster.Models;
using Sitecore;
using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SandboxHelix.Feature.Poster.Repositories
{
    public class SitecoreDocumentsRepository : IDocumentRepository
    {
        private ISitecoreContext _sitecorecontext;

        public SitecoreDocumentsRepository()
        {
            _sitecorecontext = new SitecoreContext();
        }

        public IDocument GetArticleContent(string contentGuid)
        {
            Assert.ArgumentNotNullOrEmpty(contentGuid, "contentGuid");

            return _sitecorecontext.GetItem<IDocument>(Guid.Parse(contentGuid));
        }
    }
}