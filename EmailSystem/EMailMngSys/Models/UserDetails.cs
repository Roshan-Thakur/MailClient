﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EMailMngSys.Models
{
    public class UserDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}