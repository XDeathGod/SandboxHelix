using SandboxHelix.Feature.Poster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandboxHelix.Feature.Poster.Services
{
    public interface ICommentService
    {
        IEnumerable<IComment> GetComments(String blogId);
    }
}
