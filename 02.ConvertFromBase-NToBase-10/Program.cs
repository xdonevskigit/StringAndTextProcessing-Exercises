using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02.ConvertFromBase_NToBase_10
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] input = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();

            BigInteger format = input[0];
            BigInteger num = input[1];
            string numStr = num.ToString();

            string numberLength = num.ToString();
            BigInteger result = 0;

            for (int i = 0; i < numberLength.Length; i++)
            {
                if (i == 0)
                {
                    result = BigInteger.Parse(numStr[numberLength.Length - 1].ToString());
                }
                else
                {
                    result = result + BigInteger.Parse
                        (numStr[numberLength.Length - 1 - i].ToString() ) 
                        * BigInteger.Pow(format, i);
                }
            }
            Console.WriteLine(result);
        }
    }
}
