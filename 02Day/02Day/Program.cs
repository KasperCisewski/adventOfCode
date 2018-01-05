using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            while(true)
            {
                string line = Console.ReadLine();
                if (line=="")
                {
                    break;
                }

                int lowestDigit, highestDigit = 0;

                char delimiter = ' ';

                string[] numbers = line.Split(delimiter);
                int number;
                lowestDigit = Int32.Parse(numbers[0]);
                for(int i=0;i<numbers.Length;i++)
                {
                    number = Int32.Parse(numbers[i]);
                    if(number>highestDigit)
                    {
                        highestDigit = number;
                    }
                    else if(number<=lowestDigit)
                    {
                        lowestDigit = number;
                    }

                }

                sum += highestDigit - lowestDigit;


            }

            Console.WriteLine($"{sum}");
        }
    }
}
