using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    //[Authorize]
    [RoutePrefix("api/values")]
    public class ValuesController : ApiController
    {
        private ITest Test;
        public ValuesController(ITest test)
        {
            this.Test = test;
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        [Route("GetTest1")]
        public string GetTest1()
        {
            return Test.test1();
        }

        [Route("GetTest2")]
        public string GetTest2()
        {
            return Test.test2();
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
