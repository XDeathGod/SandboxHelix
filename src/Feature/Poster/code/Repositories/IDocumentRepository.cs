using SandboxHelix.Feature.Poster.Models;
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
        IDocument GetArticleContent(string contentGuid);
    }
}
