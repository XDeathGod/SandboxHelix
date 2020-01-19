using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandboxHelix.Feature.Poster.Models
{
   public interface IDocument
    {
        string Id { get; }
        string Title { get; }
        string Body { get; }
    }


}
