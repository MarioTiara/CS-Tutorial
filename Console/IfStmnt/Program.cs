using System;

namespace IfStmnt
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isMale=true;
            bool isTall=true;
            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male");
            }
            else if(isMale && !isTall)
            {
                Console.WriteLine("You are male but not tall");
            }
            else if(!isMale && isTall)
            {
                Console.WriteLine("You are not male but you are tall");
            }



            else
            {
                Console.WriteLine("You are either not male or not tall or both");
            }
        }
    }
}
