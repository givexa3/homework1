using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Homework1.Service;

namespace Homework1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private ISingletonService _singleton;
        private IScopedService _scoped;
        private ITransientService _transient;

        private ISingletonService _singleton2;
        private IScopedService _scoped2;
        private ITransientService _transient2;

        public HomeController(
            ISingletonService singleton,
            IScopedService scoped,
            ITransientService transient, ISingletonService singleton2,
            IScopedService scoped2,
            ITransientService transient2)
        {
            _singleton = singleton;
            _scoped = scoped;
            _transient = transient;
            _singleton2 = singleton2;
            _scoped2 = scoped2;
            _transient2 = transient2;
        }

        [HttpGet]
        public string getmain()
        {
            
            string x = _singleton.GetGuid();
            string y = _scoped.GetGuid();
            string z = _transient.GetGuid();

            string x2 = _singleton2.GetGuid();
            string y2 = _scoped2.GetGuid();
            string z2 = _transient2.GetGuid();


            return "Single: " + x + "\n" + "Scoped: " + y + "\n" + "Transient: " + z + "\n" +  "\n" + "Single2: " + x2 + "\n" +  "Scoped2: " + y2 + "\n" + "Transient2: " + z2 + "\n";


        }
     
    }
}
