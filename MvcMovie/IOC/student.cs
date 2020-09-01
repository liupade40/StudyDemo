using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.IOC
{
    public class Student : IPerson
    {
        public string Say()
        {
            return "i am a student";
        }
    }
}
