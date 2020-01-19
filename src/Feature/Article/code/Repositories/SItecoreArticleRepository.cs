using Sitecore;
using Sitecore.Data;
using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SandboxHelix.Feature.Article.Repositories
{
    public class SItecoreArticleRepository : IArticleRepository
    {
        private Database _database;

        public SItecoreArticleRepository()
        {
            _database = Context.Database;
        }
        public Item GetItem(string contentGuid)
        {
            return _database.GetItem(new ID(contentGuid));
        }
    }
}