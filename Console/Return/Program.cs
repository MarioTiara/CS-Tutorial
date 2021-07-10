using System;

namespace Return
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(cube(5));
            int cubeNumber=cube(6);
            Console.WriteLine(cubeNumber);
        }

        static int cube(int num)
        {
            int result=num*num*num;

            return result;
        }

         
    }
}
