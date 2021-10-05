using System;
using TodoIT.Models;

namespace TodoIT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Todo IT");
            Person person = new Person(5, "Geralt", "Of Rivia");

            Console.WriteLine(person.Fullname);



        }

        
    }
}
