using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JsonExpection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<KeyValuePair<string, string>> list = JsonConvert.DeserializeObject<List<KeyValuePair<string, string>>>(null);
            Console.WriteLine("1");
            Console.ReadKey();
        }
    }
}
