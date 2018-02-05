using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Test : ITest
    {
        public string test1()
        {
            return "aaa";
        }

        public string test2()
        {
            return "bbb";
        }
    }
}