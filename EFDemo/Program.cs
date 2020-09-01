using EFDemo.EF;
using EFDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo
{
    class Program
    {
        static void Main(string[] args)
        {

           



            using (MyContext my = new MyContext())
            {
                Expression<Func<User, UserModel>> expression = (User x) => new UserModel
                {
                    Id = x.Id,
                    Detail = x.Detail.ToList()
                };

                var data = my.User.ToList();
                foreach (var item in data)
                {
                    Console.WriteLine("用户:{0}", item.UserName);
                    foreach (var item2 in item.Detail)
                    {
                        Console.WriteLine("用户详情:{0}", item2.Name);
                        // Console.WriteLine("用户详情2:{0}", item2.User.UserName);
                    }
                }
                Console.ReadKey();
            }
        }
    }
}
