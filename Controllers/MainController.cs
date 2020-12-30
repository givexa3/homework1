using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework1.Controllers
{
    
    [Route("[controller]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        [HttpGet]
        public string getmain()
        {
            return "welcome";
        }

        [HttpGet("name")]
        public string getname()
        {
            return "giviko";
        }

        [HttpGet("age")]
        public string getage()
        {
            return "20";
        }

        [HttpGet("number")]
        public int getnumber(int n)
        {
            return n;
        }
    }
}
