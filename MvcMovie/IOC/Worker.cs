using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.IOC
{
    public class Worker : IPerson
    {
        public string Say()
        {
            return "i am a worker";
        }
    }
}
