using System;
using System.Linq.Expressions;

namespace ExpressionTree
{
    class Program
    {
        static void Main()
        {
            // Create expression tree with Func
            Expression<Func<int, int>> expression = a => a * a;//receiving parameter a and return square value

            // Compile expression using Compile method to invoke it as Delegate
            Func<int, int> myDelegate = expression.Compile(); // myDelegate contains the reference of the lamda expression as mentioned above

            // Execute the mthod
            Console.WriteLine(myDelegate.Invoke(10));
        }
    }
}
