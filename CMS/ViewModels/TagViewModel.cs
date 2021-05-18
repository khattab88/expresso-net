using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMS.ViewModels
{
    public class TagViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public TagViewModel()
        {
            Id = Guid.Empty;
        }

        public TagViewModel(Tag tag)
        {
            Id = tag.Id;
            Name = tag.Name;
        }
    }
}