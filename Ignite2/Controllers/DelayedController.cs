using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Ignite2.Controllers
{

   public class DelayedController : Controller
    {

        [Route("")]
        [Route("Delayed")]
        [Route("Delayed/Index")]
        public String MyIndex()
        {
            return "hey";
        }




    }
}
