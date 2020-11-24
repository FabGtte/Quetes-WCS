using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASPRoutage2._0.Controllers
{
    public class HomeConvController : ControllerBase
    {
       
        public String SayHello()
        {
            return "Hello ! par convention";
        }

        public String YellHello()
        {
            return "HELLO ! par convention";
        }
        
    }
}
