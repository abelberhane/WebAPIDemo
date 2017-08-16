using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class DemoController : ApiController
    {
        public string Get()
        {
            return "Welcome To My First Web API";   
        }
        
        public List < string > Get(int Id)
        {
            return new List<string>{

                "Data1",
                "Data2"
            };
        }




    }
}
