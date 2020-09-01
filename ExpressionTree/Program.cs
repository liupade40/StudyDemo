using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionTree
{
    class Program
    {
        static void Main(string[] args)
        {
            ParameterExpression paraLeft = Expression.Parameter(typeof(int), "a");
            ParameterExpression paraRight = Expression.Parameter(typeof(int), "b");

            BinaryExpression binaryLeft = Expression.Multiply(paraLeft, paraRight);
            ConstantExpression conRight = Expression.Constant(2, typeof(int));

            BinaryExpression binaryBody = Expression.Add(binaryLeft, conRight);

            LambdaExpression lambda =
                Expression.Lambda<Func<int, int, int>>(binaryBody, paraLeft, paraRight);

            Console.WriteLine(lambda.ToString());
            Console.Read();
        }
    }
}
