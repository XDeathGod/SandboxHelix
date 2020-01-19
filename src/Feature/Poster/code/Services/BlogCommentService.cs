using SandboxHelix.Feature.Poster.Models;
using SandboxHelix.Feature.Poster.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SandboxHelix.Feature.Poster.Services
{
    public class BlogCommentService : ICommentService
    {
        private readonly ICommentRepository _repository;

        public BlogCommentService()
        {
            _repository = new FakeBlogCommentRepository();
        }
        public IEnumerable<IComment> GetComments(string blogId)
        {
            return _repository.GetComments(blogId);
        }
    }
}