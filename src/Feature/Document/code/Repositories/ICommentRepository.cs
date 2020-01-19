using SandboxHelix.Feature.Document.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandboxHelix.Feature.Document.Repositories
{
   public interface ICommentRepository
    {
        IEnumerable<IComment> GetComments(string blogId);
    }
}
