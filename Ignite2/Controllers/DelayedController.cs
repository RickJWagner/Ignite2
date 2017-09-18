using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Runtime.InteropServices;

namespace Ignite2.Controllers
{

   public class DelayedController : Controller
    {

        [Route(template: "Delayed/Response/{howmuch}")]
        public String Response(int howmuch)
        {

            if(13 == howmuch)
            {
                CrashMethod();
            }

            Thread.Sleep((howmuch * 1000));
            return "This request was delayed by  " + howmuch + " seconds" ;
        }


        // Call this method to crash the server!  It will crash hard.
        private void CrashMethod()
        {
            IntPtr p = Marshal.AllocHGlobal(1);
            for (int i = 0; i < 10000000; ++i)
            {
                p = new IntPtr(p.ToInt64() + 1);
                Marshal.WriteByte(p, 0xFF);
            }
        }




    }
}
