﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Petzz.Models
{
    public class Login
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
    }

}