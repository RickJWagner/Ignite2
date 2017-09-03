using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace Ignite2.Controllers
{

   public class DelayedController : Controller
    {

        [Route(template: "Delayed/Response/{howmuch}")]
        public String Response(int howmuch)
        {
            Thread.Sleep((howmuch * 1000));
            return "hey";
        }




    }
}
