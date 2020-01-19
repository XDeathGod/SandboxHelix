using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandboxHelix.Feature.Article.Repositories
{
    public interface IArticleRepository
    {
        Item GetItem(string contentGuid);
    }
}
