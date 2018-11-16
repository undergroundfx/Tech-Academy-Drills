using System;

namespace OutputParameters
{
    class Program
    {
        static void Main()
        {
            Class1 display = new Class1();
            display.Divider(50, out decimal mainNum);
            Console.WriteLine(mainNum);

            display.Divider(100.50m, out mainNum);
            Console.WriteLine(mainNum);

            Console.ReadLine();
        }
    }
}
