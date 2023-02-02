using System.Drawing;
using System.Linq.Expressions;
using System.Security.Cryptography;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int test = 1;
            const int spring = 321;
            const int summer = 621;
            const int autumn = 921;
            const int winter = 1221;
            Console.WriteLine("What is the month? 1-12");
            string month = Console.ReadLine()!;
            Console.WriteLine("What is the day? 1-31");
            string day = Console.ReadLine()!;
            if (Convert.ToInt32(day) < 10 &&! day.Contains("0"))
            {
                day = "0" + day;
            }

            int monthInt = Convert.ToInt32(month + day);
            string result = monthInt switch
            {
                >= spring and < summer => "Spring",
                >= summer and < autumn => "Summer",
                >= autumn and < winter => "Autumn",
                >= winter or < spring => "Winter"
            };
            Console.WriteLine($"On {Convert.ToInt32(day)}-{month} it is {result}");
        }
    }
}