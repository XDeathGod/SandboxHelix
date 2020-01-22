﻿using SandboxHelix.Foundation.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandboxHelix.Feature.Poster.Models
{
   public interface IDocument : ICmsEntity
    {
        Guid Id { get; }
        string Title { get; }
        string Body { get; }
    }


}
