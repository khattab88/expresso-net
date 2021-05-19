using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMS.Helpers
{
    public static class SlugHelper
    {
        public static string Generate(string name) 
        {
            return new Slugify.SlugHelper().GenerateSlug(name);
        }
    }
}