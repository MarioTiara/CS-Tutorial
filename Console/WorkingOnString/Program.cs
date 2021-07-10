using System;

namespace WorkingOnString
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase="Mario Tiara";
            //Console.WriteLine(phrase.Length); --> 10
            //Console.WriteLine(phrase.ToLower()); -->mario tiara
            //Console.WriteLine(phrase.ToUpper());  -->MARIO TIARA
            //Console.WriteLine(phrase.Contains("Mario")); -->True
            //Console.WriteLine(phrase[0]);  --> M
            //Console.WriteLine(phrase.Substring(0,3)); ->> Mar
            Console.WriteLine(phrase.IndexOf("Tiara"));

            


        }
    }
}
