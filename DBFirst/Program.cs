using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DBFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            studentEntities studentEntities = new studentEntities();
            string str = "1";
            string str2 = "1";
            int i = 1;
            Console.WriteLine(object.ReferenceEquals(string.Empty,""));
            //Console.WriteLine(student.studentNo);
            Console.ReadKey();

            using (studentEntities context = new studentEntities())
            {
                using (var dbContextTransaction = context.Database.BeginTransaction())
                {
                    var student = context.students.FirstOrDefault(x => x.ClassId == 1);
                    if (student!=null)
                    {
                        //string.Empty
                    }

                    context.students.Add(new student()
                    {
                        ClassId = 2
                    });
                    context.SaveChanges();
                    //提交事务
                    dbContextTransaction.Commit();
                }
            }
        }
    }
}
