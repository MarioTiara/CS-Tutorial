using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luckyNumber={4,8,15,16,23,42};

            //Console.WriteLine(luckyNumber[2]); --> 15

            string [] friends = new string[5]; //number 5 represent dimention of array

            friends[0]="mario";
            friends[1]="Tiara";
            friends[2]="Pratama";
            friends[3]="Olivia";
            friends[4]="Putri";

            Console.WriteLine(friends[3]);  //-->=Olivia
        }
    }
}
