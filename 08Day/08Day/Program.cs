using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Day
{
    class Program
    {
        public class letters
        {
            public string name;
            public int value;
        }
        static void Main(string[] args)
        {
            List<string> lines = new List<string>();
            List<letters> letters = new List<Program.letters>();
            char separator = ' ';
            try
            {
                using (StreamReader sr = new StreamReader("Test.txt"))
                {
                    foreach (var lin in File.ReadLines("Test.txt"))
                    {
                        lines.Add(lin);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            
            
            
            string[,] tab = new string[lines.Count,7];
            for (int i = 0; i < lines.Count; i++)
            {
             string[] wordsInLine = lines[i].Split(separator);
             for(int j=0;j<7;j++)
                {
                    tab[i, j] = wordsInLine[j];
                }
             letters tmp = new letters();
             tmp.name = wordsInLine[0];
             tmp.value = 0;
             letters.Add(tmp);
            }

            for (int i = 0; i < letters.Count; i++)
                for (int j = 0; j < letters.Count; j++)
                {   
                    if(i==j)
                    {

                    }
                    else if (letters[i].name == letters[j].name)
                    {
                        Console.WriteLine();
                        letters.RemoveAt(j);
                        j--;
                    }
                }

            for(int i=0;i<letters.Count;i++)
            {
                Console.WriteLine(letters[i].name);
            }

            int max=0;
            for(int i =0;i< lines.Count;i++)
            {
                string[] wordsInLine = lines[i].Split(separator);
                for(int j=0;j<letters.Count;j++)
                {
                    if(letters[j].name==wordsInLine[4])
                    {
                        letters tmp = letters[j];
                        if(wordsInLine[5]=="==")
                        {
                            int number=int.Parse(wordsInLine[6]);  
                            if(tmp.value==number)
                            {
                                letters tmpNext = new Program.letters();
                                int counter = 0;
                                for(int k=0;k<letters.Count;k++)
                                {
                                    if (wordsInLine[0] == letters[k].name)
                                    {
                                        counter = k;
                                        tmpNext = letters[k];
                                        break;
                                    }
                                }
                                if(wordsInLine[1]=="inc")
                                {
                                    int firstNumber = int.Parse(wordsInLine[2]);
                                    tmpNext.value += firstNumber;
                                    if (tmpNext.value >= max)
                                        max = tmpNext.value;

                                    letters[counter] = tmpNext;
                                    break;

                                }
                                else
                                {
                                    int firstNumber = int.Parse(wordsInLine[2]);
                                    tmpNext.value -= firstNumber;
                                    if (tmpNext.value >= max)
                                        max = tmpNext.value;

                                    letters[counter] = tmpNext;
                                    break;

                                }

                            }
                        }
                        else if(wordsInLine[5]=="!=")
                        {
                            int number = int.Parse(wordsInLine[6]);
                            if (tmp.value != number) 
                            {
                                letters tmpNext = new Program.letters();
                                int counter = 0;
                                for (int k = 0; k < letters.Count; k++)
                                {
                                    if (wordsInLine[0] == letters[k].name)
                                    {
                                        counter = k;
                                        tmpNext = letters[k];
                                        break;
                                    }
                                }
                                if (wordsInLine[1] == "inc")
                                {
                                    int firstNumber = int.Parse(wordsInLine[2]);
                                    tmpNext.value += firstNumber;
                                    if (tmpNext.value >= max)
                                        max = tmpNext.value;

                                    letters[counter] = tmpNext;
                                    break;

                                }
                                else
                                {
                                    int firstNumber = int.Parse(wordsInLine[2]);
                                    tmpNext.value -= firstNumber;
                                    if (tmpNext.value >= max)
                                        max = tmpNext.value;

                                    letters[counter] = tmpNext;
                                    break;

                                }

                            }
                        }
                        else if (wordsInLine[5] == ">=")
                        {
                            int number = int.Parse(wordsInLine[6]);
                            if (tmp.value >= number) 
                            {
                                letters tmpNext = new Program.letters();
                                int counter = 0;
                                for (int k = 0; k < letters.Count; k++)
                                {
                                    if (wordsInLine[0] == letters[k].name)
                                    {
                                        counter = k;
                                        tmpNext = letters[k];
                                        break;
                                    }
                                }
                                if (wordsInLine[1] == "inc")
                                {
                                    int firstNumber = int.Parse(wordsInLine[2]);
                                    tmpNext.value += firstNumber;
                                    if (tmpNext.value >= max)
                                        max = tmpNext.value;

                                    letters[counter] = tmpNext;
                                    break;

                                }
                                else
                                {
                                    int firstNumber = int.Parse(wordsInLine[2]);
                                    tmpNext.value -= firstNumber;
                                    if (tmpNext.value >= max)
                                        max = tmpNext.value;

                                    letters[counter] = tmpNext;
                                    break;

                                }

                            }
                        }
                        else if (wordsInLine[5] == ">")
                        {
                            int number = int.Parse(wordsInLine[6]);
                            if (tmp.value > number) 
                            {
                                letters tmpNext = new Program.letters();
                                int counter = 0;
                                for (int k = 0; k < letters.Count; k++)
                                {
                                    if (wordsInLine[0] == letters[k].name)
                                    {
                                        counter = k;
                                        tmpNext = letters[k];
                                        break;
                                    }
                                }
                                if (wordsInLine[1] == "inc")
                                {
                                    int firstNumber = int.Parse(wordsInLine[2]);
                                    tmpNext.value += firstNumber;
                                    if (tmpNext.value >= max)
                                        max = tmpNext.value;

                                    letters[counter] = tmpNext;
                                    break;

                                }
                                else
                                {
                                    int firstNumber = int.Parse(wordsInLine[2]);
                                    tmpNext.value -= firstNumber;
                                    if (tmpNext.value >= max)
                                        max = tmpNext.value;

                                    letters[counter] = tmpNext;
                                    break;

                                }

                            }
                        }
                        else if (wordsInLine[5] == "<=")
                        {
                            int number = int.Parse(wordsInLine[6]);
                            if (tmp.value <= number) 
                            {
                                letters tmpNext = new Program.letters();
                                int counter = 0;
                                for (int k = 0; k < letters.Count; k++)
                                {
                                    if (wordsInLine[0] == letters[k].name)
                                    {
                                        counter = k;
                                        tmpNext = letters[k];
                                        break;
                                    }
                                }
                                if (wordsInLine[1] == "inc")
                                {
                                    int firstNumber = int.Parse(wordsInLine[2]);
                                    tmpNext.value += firstNumber;
                                    if (tmpNext.value >= max)
                                        max = tmpNext.value;

                                    letters[counter] = tmpNext;
                                    break;

                                }
                                else
                                {
                                    int firstNumber = int.Parse(wordsInLine[2]);
                                    tmpNext.value -= firstNumber;
                                    if (tmpNext.value >= max)
                                        max = tmpNext.value;

                                    letters[counter] = tmpNext;
                                    break;

                                }

                            }
                        }
                        else if (wordsInLine[5] == "<")
                        {
                            int number = int.Parse(wordsInLine[6]);
                            if (tmp.value < number) 
                            {
                                letters tmpNext = new Program.letters();
                                int counter = 0;
                                for (int k = 0; k < letters.Count; k++)
                                {
                                    if (wordsInLine[0] == letters[k].name)
                                    {
                                        counter = k;
                                        tmpNext = letters[k];
                                        break;
                                    }
                                }
                                if (wordsInLine[1] == "inc")
                                {
                                    int firstNumber = int.Parse(wordsInLine[2]);
                                    tmpNext.value += firstNumber;
                                    if (tmpNext.value >= max)
                                        max = tmpNext.value;

                                    letters[counter] = tmpNext;
                                    break;

                                }
                                else
                                {
                                    int firstNumber = int.Parse(wordsInLine[2]);
                                    tmpNext.value -= firstNumber;
                                    if (tmpNext.value >= max)
                                        max = tmpNext.value;

                                    letters[counter] = tmpNext;
                                    break;

                                }

                            }
                        }
                    }
                }
            }
            Console.WriteLine("w dowolnym momenci max to {0}",max);
            int maxOnEnding = 0;
            for(int i=0;i<letters.Count;i++)
            {
                if (letters[i].value > maxOnEnding)
                    maxOnEnding = letters[i].value;
            }
            Console.WriteLine("na koncu max to {0}",maxOnEnding);

            
        }
    }
}
