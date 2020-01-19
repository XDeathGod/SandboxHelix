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
        private Database _database;

        public SitecoreDocumentsRepository()
        {
            _database = Context.Database;
        }

        public Item GetArticleContent(string contentGuid)
        {
            Assert.ArgumentNotNullOrEmpty(contentGuid, "contentGuid");

            return _database.GetItem(new ID(contentGuid));
        }
    }
}