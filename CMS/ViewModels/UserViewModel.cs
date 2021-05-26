﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMS.ViewModels
{
    public class UserViewModel
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
    }
}