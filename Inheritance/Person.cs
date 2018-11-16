using System;

namespace Inheritance
{
    class Person
    {
        public Person()
        {

        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
