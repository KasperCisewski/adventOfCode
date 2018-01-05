using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Day
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lines = new List<string>();
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
            char separator = ' ';
            string line = "";
            int validNumbers = lines.Count;
            for (int i = 0; i < lines.Count; i++)
            {
                string[] words = lines[i].Split(separator);
                if(checkWords(words)==false)
                {
                    validNumbers--;
                }
               
            }


            Console.WriteLine(validNumbers);



            //for(int i=0;i<lines.Count;i++)
            //{
            //    line = line + lines[i]+separator;
            //}


            //List<string> wordsList = new List<string>();
            //for(int i=0;i<words.Length;i++)
            //{
            //    wordsList.Add(words[i]);
            //}

            //int validNumbers = words.Length;
            //Console.WriteLine("tab[5]={0}",words[5]);
            //Console.WriteLine("przed sprawdzeniem {0}",validNumbers);

            //validNumbers = checkWords(wordsList, validNumbers);
            //Console.WriteLine("przed sprawdzeniem {0}",validNumbers);



        }
        static bool checkWords(string[] words)
        {
            for (int j = 0; j < words.Length; j++)
            {
                for (int k = 0; k < words.Length; k++)
                {
                    if(j==k)
                    {

                    }
                    else if (words[j] == words[k])
                    {
                        return false;

                    }
                }
            }
            return true;
        }

        static int checkWords(List<string> words, int validNumbers)
        {
            List<string> repeatableWords = new List<string>();
            repeatableWords.Add("testttstssdftse");
            int k = 0;
            for (int i = 0; i < words.Count; i++)
                for (int j = 0; j < words.Count; j++)
                {
                    if (i == j)
                    {

                    }
                    else if (words[i] == words[j])
                    {
                        if (repeatableWords[k] != words[i])
                        {
                            if (k == 0)
                            {
                                repeatableWords[0] = words[i];
                            }
                            else
                            {
                                repeatableWords.Add(words[i]);
                                k++;
                            }
                        }

                        words.RemoveAt(j);
                        validNumbers--;
                    }
                }
            return validNumbers - repeatableWords.Count;
        }

    }
       

 }
