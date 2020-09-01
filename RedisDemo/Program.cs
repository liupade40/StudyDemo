using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new RedisClient("127.0.0.1", 6379);
            client.Set<int>("pwd", 1111);
            int pwd = client.Get<int>("pwd1");
            Console.WriteLine(pwd);
        }
    }
}
