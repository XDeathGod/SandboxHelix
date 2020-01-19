using Glass.Mapper.Sc.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SandboxHelix.Feature.Poster.Models.Configuration
{
    public class IDocumentMap : SitecoreGlassMap<IDocument>
    {
        public override void Configure()
        {
            Map(config =>
           {
               config.AutoMap();
               config.Id(f => f.Id);
               config.Field(f => f.Title).FieldName("Title");
               config.Field(f => f.Body).FieldName("Body");
           }


                );
        }
    }
}