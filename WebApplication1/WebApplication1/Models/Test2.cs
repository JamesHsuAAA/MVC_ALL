﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Test2 : ITest
    {
        public string test1()
        {
            return "ccc";
        }

        public string test2()
        {
            return "ddd";
        }
    }
}