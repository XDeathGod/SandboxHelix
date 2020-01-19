using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandboxHelix.Feature.Poster.Repositories
{ 
    public interface IDocumentRepository
    {
        Item GetArticleContent(string contentGuid);
    }
}
