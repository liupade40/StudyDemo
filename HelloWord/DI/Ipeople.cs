using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWord.DI
{
    public interface Ipeople
    {
        string say();
    }
    public class teacher : Ipeople
    {
        public string say()
        {
            return "helloword";
        }
    }
}
