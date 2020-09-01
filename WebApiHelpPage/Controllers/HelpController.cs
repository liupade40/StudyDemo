using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiHelpPage.Controllers
{
    public class HelpController : ApiController
    {
        // GET api/crab
        /// <summary>
        /// this is get function without parameter
        /// </summary>
        /// <returns>function return value</returns>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/crab/5
        /// <summary>
        /// this is get function with a parameter named id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>function return value</returns>
        public string Get(int id)
        {
            return "value";
        }
    }
}
