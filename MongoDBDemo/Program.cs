using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDBDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MongoDBHelper mongoDBHelper = new MongoDBHelper();
            var list = mongoDBHelper.Get<student>(x => x.Id ==1, 0, 10, "Id");
            foreach (var item in list)
            {
                Console.WriteLine(item.Name);
            }
            //mongoDBHelper.Insert(new student()
            //{
            //    Id = 12,
            //    Name = "liubin",
            //    Age = 12
            //});
            //Console.Write("插入完成");
            Console.ReadKey();
        }
    }
   class student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
