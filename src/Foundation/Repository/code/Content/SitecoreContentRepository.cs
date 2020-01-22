using Glass.Mapper.Sc;
using SandboxHelix.Foundation.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SandboxHelix.Foundation.Repository.Content
{
    public class SitecoreContentRepository : IContentRepository
    {
        private readonly SitecoreContext _sitecoreContext;

        public SitecoreContentRepository()
        {
            _sitecoreContext = new SitecoreContext();
        }
        public virtual T GetContentItem<T>(string contentGuid) where T : class, ICmsEntity
        {
            return _sitecoreContext.GetItem<T>(Guid.Parse(contentGuid));
        }
    }
}