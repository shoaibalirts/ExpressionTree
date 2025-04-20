using System;
using System.Linq.Expressions;

namespace ExpressionTree
{
    class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main()
        {
            Student student = new Student() { StudentID = 101, StudentName = "Shoaib Ali", Age = 42 };
            // Create expression tree with Func
            Expression<Func<int, int>> expression = a => a * a;//receiving parameter a and return square value

            // Compile expression using Compile method to invoke it as Delegate
            Func<int, int> myDelegate = expression.Compile(); // myDelegate contains the reference of the lamda expression as mentioned above

            // Execute the method
            Console.WriteLine(myDelegate.Invoke(10));
        }
    }
}
