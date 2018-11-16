using System;

namespace Inheritance
{
    class Program
    {
        static void Main()
        {
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student"};
            employee.SayName();
            Console.ReadLine();
        }
    }
}
