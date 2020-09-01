using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 0;
                int i = 12 / a;
                
            }
            
            finally
            {
                Console.WriteLine(1);
            }
            Console.ReadKey();
        }
    }
}
