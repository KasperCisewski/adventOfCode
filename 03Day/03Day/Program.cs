using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Day
{
   

    class Program
    {
         enum directInSquare
        { right = 1, up, left, down };


        static void Main(string[] args)
        {
            int[,] largeTable = new int[1001, 1001];
            //
            largeTable[500, 500] = 1;
            

            int incrementNumber = 1, rows = 501, columns = 501, distance = 1;
            directInSquare value = directInSquare.right;
            while (incrementNumber<=700001)
            {
                int count = 0;
                while(count!=2)
                {
                    if(value==directInSquare.right)
                    {
                        for (int i = 0; i < distance; i++)
                        {
                            largeTable[rows, columns++] = incrementNumber;
                            incrementNumber++;
                        }                    
                        count++;
                        value = directInSquare.up;
                    }
                    else if(value==directInSquare.up)
                    {
                        for (int i = 0; i < distance; i++)
                        {
                            largeTable[rows++, columns] = incrementNumber;
                            incrementNumber++;
                        }
                        count++;
                        value = directInSquare.left;
                    }
                    else if(value==directInSquare.left)
                    {
                        for (int i = 0; i < distance; i++)
                        {
                            largeTable[rows, columns--] = incrementNumber;
                            incrementNumber++;
                        }
                        count++;
                        value = directInSquare.down;
                    }
                    else if(value==directInSquare.down)
                    {
                        for(int i=0;i<distance;i++)
                        {
                            largeTable[rows--, columns] = incrementNumber;
                            incrementNumber++;
                        }
                        count++;
                        value = directInSquare.right;
                    }
                }
                distance++;
            }
            int input = int.Parse(Console.ReadLine());
            int xAxis, yAxis;
            int[] tabAxix = new int[2];

            for(int k=0;k<1001;k++)
                for(int l=0;l<1001;l++)
                {
                    if(largeTable[k,l]==input)
                    {
                        tabAxix[0] = k;
                        tabAxix[1] = l;
                    }
                }

            xAxis = tabAxix[0];
            yAxis = tabAxix[1];

            int steps = 0;
            if(xAxis>501)
            {
                while(xAxis!=501)
                {
                    xAxis--;
                    steps++;
                }
            }
            else
            {
                while (xAxis != 501)
                {
                    xAxis++;
                    steps++;
                }
            }

            if(yAxis>501)
            { 
                while (yAxis != 501)
                {
                    yAxis--;
                    steps++;
                }
            }
            else
            {
                while (yAxis != 501)
                {
                    yAxis++;
                    steps++;
                }
            }
            Console.WriteLine($"{steps}");
        }
    }
}
