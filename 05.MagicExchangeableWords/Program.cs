﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MagicExchangeableWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();
            string wordOne = input[0];
            string wordTwo = input[1];
            var arrayOne = wordOne.ToCharArray().Distinct().ToArray();
            var arrayTwo = wordTwo.ToCharArray().Distinct().ToArray();

            if (arrayOne.Length != arrayTwo.Length)
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("true");
            }   
        }
    }
}
