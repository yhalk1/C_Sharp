using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi. What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Hi. What is your year of birth?");
            string dateOfBirth = Console.ReadLine();

            int age = 2022 - Convert.ToInt32(dateOfBirth);
            Console.WriteLine("Hi! Your name is: {0} and your age is {1}", name, age);

            string replace = Console.ReadLine();
            Console.WriteLine(replace.Replace(" ", "_"));
        }
    }
}
