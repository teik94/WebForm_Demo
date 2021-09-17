using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Controller;

namespace WebApplication1
{
    [RoutePrefix("api/Register")]
    public class RegisterController : ApiController
    {
        // GET api/Register/RegisAcc/username/password
        [HttpGet]
        [ActionName("RegisAcc")]
        [Route("RegisAcc/{username}/{password}")]
        public string RegisAcc(string username, string password)
        {
            if(username != "")
            {
                return "Register Success";
            }
            else
            {
                return "Register Failed";
            }
            
        }

        // GET api/Register/RegisAcc?username="kiet"&password="123"
        [HttpGet]
        [ActionName("RegisAcc2")]
        [Route("RegisAcc2")]
        public string RegisAcc2(string username, string password)
        {
            if (username != "")
            {
                return "Register Success";
            }
            else
            {
                return "Register Failed";
            }

        }

        [HttpPost]
        [Route("Login")]
        public string Login([FromBody] User user)
        {
            return "Success";
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