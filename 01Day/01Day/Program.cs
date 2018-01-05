using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Day
{
    class Program
    {
        static void Main(string[] args)
        {

            string digitsInString = Console.ReadLine();
            char[] digitsInChar=digitsInString.ToCharArray();
            int sum = 0;

            for(int i=0;i<digitsInChar.Length-1;i++)
            {
                if(digitsInChar[i]==digitsInChar[i+1])
                {
                    
                    sum += (int)Char.GetNumericValue(digitsInChar[i]);
                }
            }
            if(digitsInChar[0]==digitsInChar[digitsInChar.Length-1])
                sum+= (int)Char.GetNumericValue(digitsInChar[0]);


            Console.WriteLine($"{sum}");


        }
    }
}
