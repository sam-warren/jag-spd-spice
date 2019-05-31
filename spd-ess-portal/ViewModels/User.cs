﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gov.Jag.Spice.Public.ViewModels
{
    public class User
    {
        public string Id { get; set; }

        public string DisplayName { get; set; }

        public string GivenName { get; set; }

        public string LastName { get; set; }

        public string Department { get; set; }

        public string OrgCode { get; set; }

        public string Company { get; set; }
    }
}
