using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            string firstStr = input[0];
            string secondStr = input[1];
            long result = 0;
            int minLength = Math.Min(firstStr.Length, secondStr.Length);
            int dif = 0;
            string reminder = "";

            for (int i = 0; i < minLength; i++)
            {
                result = result + (firstStr[i] * secondStr[i]);
            }
            if (minLength < firstStr.Length)
            {
                dif = firstStr.Length - minLength;
                reminder = firstStr.Substring(minLength, dif);
            }
            else if(minLength < secondStr.Length)
            {
                dif = secondStr.Length - minLength;
                reminder = secondStr.Substring(minLength, dif);
            }
            for (int i = 0; i < reminder.Length; i++)
            {
                result = result + reminder[i];
            }
            Console.WriteLine(result);
        }
    }
}
