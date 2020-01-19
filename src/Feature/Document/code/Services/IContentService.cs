using SandboxHelix.Feature.Document.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandboxHelix.Feature.Document.Services
{
    public interface IContentService
    {
        IDocument GetDocumentContent(string contentGuid);
    }
}
