using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SandboxHelix.Feature.Article.VIewModels
{
    public class HeroSliderImageViewModel
    {
        public string MediaUrl { get; set; }
        public string AltText { get; set; }

        public bool isActive { get; set; }
    }
}