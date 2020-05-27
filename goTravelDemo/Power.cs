using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace goTravelDemo
{
    public class Power
    {
        static void Main(string[] args)
        {
            int x = 10;
            Console.WriteLine("Enter the power value");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.Write(power(x, y));
        }

        public static int power(int x, int y)
        {
            if (y == 0)
                return 1;
            else if (y % 2 == 0)
                return power(x, y / 2) * power(x, y / 2);
            else
                return x * power(x, y / 2) * power(x, y / 2);
        }
    }
}
