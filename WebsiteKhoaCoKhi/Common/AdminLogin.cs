﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebsiteKhoaCoKhi.Common
{
    [Serializable]
    public class AdminLogin
    {
        public int AdminID { get; set; }

        public string AdminName { get; set; }
    }
}