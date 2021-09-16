using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Controller;

namespace WebApplication1
{
    public class RegisController : ApiController
    {
        // GET api/<controller>/5
        [ActionName("MyApi")]
        [HttpGet]
        public string MyApi(int id)
        {
            if(id == 1)
            {
                return "Register Success";
            }
            else
            {
                return "Register Failed";
            }
            
        }

        // POST api/<controller>
        public void Post([FromBody] User user)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}