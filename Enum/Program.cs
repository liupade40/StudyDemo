using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            MyFlags myFlag = MyFlags.Flag2;
            if ((myFlag & MyFlags.Flag2) == MyFlags.Flag2)
            {
                Console.WriteLine("true");
            }
            if ((myFlag & MyFlags.Flag3) == MyFlags.Flag3)

            {
                Console.WriteLine("true");
            }
            Console.ReadKey();
        }
    }
    [Flags]
    enum MyFlags
    {
        Flag1 = 0,    //000  
        Flag2 = 1,    //001  
        Flag3 = 2,    //010  
        Flag4 = 4     //100  
    };
}
