using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number :");
            int dayNumber =Convert.ToInt32(Console.Read());
            Console.WriteLine(GetDay(dayNumber));
        }

        static string GetDay(int dayNum)
        {
            string dayName;
                switch  (dayNum)
                {
                    case 0:
                        dayName = "Sunday";
                        break;
                    case 1:
                        dayName = "Monday";
                        break;
                    case 2:
                        dayName="Tuesday";
                        break;
                    case 3:
                        dayName="Wednesday";
                        break;
                    case 4:
                        dayName="Thursday";
                        break;
                    case 5:
                        dayName="Friday";
                        break;
                    case 6:
                        dayName="Saturday";
                        break;
                    
                    default:
                        dayName="Invalid number of day";
                        break;
                    
                }

            return dayName;
        }
    }
}
