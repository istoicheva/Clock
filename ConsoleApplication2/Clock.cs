using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Clock
    {
        static void Main(string[] args)
        {
            // DateTime currantTime = DateTime.Now;

            Console.Write("Time: ");
            string timeString = Console.ReadLine();
            string[] elements = timeString.Split(':');

            int hour = Int32.Parse(elements[0]);
            int minute = Int32.Parse(elements[1]);
        }

        private static string ConvertDigitToString(int digit, bool isHour)
        {
            switch (digit)
            {
                case 0:
                    return "ZERO";
                case 1:
                    return "ONE";
                case 2:
                    return "TWO";
                case 3:
                    return "THREE";
                case 4:
                    return "FOUR";
                case 5:
                    return "FIVE";
                case 6:
                    return "SIX";
                case 7:
                    return "SEVEN";
                case 8:
                    return "EIGHT";
                case 9:
                    return "NINE";
                default:
                    return "ERROR in Conver To String";
            }
        }


    }
}
