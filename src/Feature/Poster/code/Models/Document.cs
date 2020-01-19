using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SandboxHelix.Feature.Poster.Models
{
    public class Document : IDocument
    {
        public Guid Id { get; set; }

        public string Title { get; set; }
        public string Body { get; set; }
    }
}