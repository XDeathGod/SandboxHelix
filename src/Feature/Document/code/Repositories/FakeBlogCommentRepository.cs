using SandboxHelix.Feature.Document.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SandboxHelix.Feature.Document.Repositories
{
    public class FakeBlogCommentRepository : ICommentRepository
    {
        public IEnumerable<IComment> GetComments(string blogId)
        {
            var comments = new List<IComment>();
            comments.Add(new BlogComment()
            {
                Name = "Jack",
                Comment = "this Post was really helpful",
                DatePosted = DateTime.Parse("05/12/2019")
            });

            comments.Add(new BlogComment()
            {
                Name = "Donquixote",
                Comment = "this Post was really helpful",
                DatePosted = DateTime.Parse("05/12/2019")
            });

            return comments;
        }
    }
}