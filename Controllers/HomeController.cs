using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPRoutage2._0.Controllers
{
    public class HomeController : Controller
    {
       
        [Route("Hello/Say")] // The endpoint here is reached by calling `/Say` route
        public String SayHello()
        {
            return "Hello !";
        }

        [Route("Hello/Yell")] // The endpoint here is reached by calling `/Yell` route
        public String YellHello()
        {
            return "HELLO !";
        }
        
    }
}
