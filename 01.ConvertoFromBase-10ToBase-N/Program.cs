using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01.ConvertoFromBase_10ToBase_N
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] input = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();

            string result = "";
            BigInteger hexaNumber = input[1];
            BigInteger dec = input[0];

            BigInteger overage = 0;
            while (hexaNumber > 0)
            {
                    overage = hexaNumber % dec;
                    hexaNumber = hexaNumber / dec;
                    result = result.Insert(0, overage.ToString());    
            }
            Console.WriteLine(result);
        }
    }
}
