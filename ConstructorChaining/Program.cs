using System;

namespace ConstructorChaining
{
    class Program
    {
        static void Main()
        {
            const string title = "The Wizard of Oz";
            var rating = " receives 4 Stars";
            Console.WriteLine(title + rating);
            
            Console.WriteLine(Managers.funcTest());

            Console.ReadLine();
        }
    }

    public class Workers
    {
        public Workers(string name) : this(name, 100)
        {

        }

        public Workers(string name, int test) 
        {
            string names = "Mario";
            name = names;
        }

    }

    class Managers
    {
        Managers()
        {

        }

        public static string funcTest()
        {
            return "42";
        }

    }

}
