using System;

namespace Methode
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHi("Mario",21);
            SayHi("Tiara",22);
            SayHi("Pratama",23);
        }

        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hallo "+ name + ", you are " +age);
        }
    }
}
