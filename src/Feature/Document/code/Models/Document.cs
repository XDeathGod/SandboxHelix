using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SandboxHelix.Feature.Document.Models
{
    public class Document : IDocument
    {
        public string Id { get; set; }

        public string Title { get; set; }
        public string Body { get; set; }
    }
}