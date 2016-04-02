using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler001
{
    class Program
    {
        static void Main(string[] args)
        {
            int calcSum = Sum3and5s(1000);
            Console.Write(calcSum);
            Console.ReadKey();
        }

        static int Sum3and5s(int maxVal)
        {
            int sum = 0;
            for(int i = 1; i < maxVal; i++)
            {
                if ((i % 3 == 0) || (i % 5 == 0)) {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
