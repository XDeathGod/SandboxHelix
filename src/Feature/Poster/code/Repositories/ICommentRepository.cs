using SandboxHelix.Feature.Poster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandboxHelix.Feature.Poster.Repositories
{
   public interface ICommentRepository
    {
        IEnumerable<IComment> GetComments(string blogId);
    }
}
