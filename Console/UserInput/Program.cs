using System;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Name:");
            string Name=Console.ReadLine();

            Console.Write("Enter your age:");
            int age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hallo "+ Name+" you are "+ Convert.ToString(age));
        }
    }
}
