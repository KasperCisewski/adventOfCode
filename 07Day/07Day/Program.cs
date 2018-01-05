using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Day
{
    class Program
    {
       struct sygnal
        {
            public string name;
            public int value;
            public string[] tab;
            public int id;
            public int left_id;
            public int[] right_id;
        }
        static void Main(string[] args)
        {
            List<sygnal> listOfSygnals = new List<sygnal>();
            List<string> lines = new List<string>();
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
            
           
            for (int i=0;i<lines.Count;i++)
            {
                sygnal tmp = new sygnal();
                if (lines[i].Contains(","))
                {
                    lines[i] = lines[i].Replace(",", "");
                }
                string[] wordsInLine = lines[i].Split(separator);
                tmp.left_id = -1;
                
                tmp.name = wordsInLine[0];
                wordsInLine[1] = wordsInLine[1].Replace("(", "").Replace(")","");
                tmp.value = int.Parse(wordsInLine[1]);
                tmp.id = i;
                if(lines[i].Contains("->"))
                {
                    tmp.tab = new string[wordsInLine.Length - 3];
                    int count = 0;
                    for(int j=3;j<wordsInLine.Length;j++)
                    {
                        tmp.tab[count] = wordsInLine[j];
                        count++;
                    }
                }
                listOfSygnals.Add(tmp);
            }

            for(int i=0;i<listOfSygnals.Count;i++)
                {
                int count = 0;

                if (listOfSygnals[i].tab!=null)
                    {
                    sygnal tmp = listOfSygnals[i];
                    tmp.right_id = new int[tmp.tab.Length];
                    for (int k=0;k<listOfSygnals.Count; k++)
                        {
                            
                            int counter = 0;
                            do
                            {
                                if(listOfSygnals[i].tab[counter]==listOfSygnals[k].name)
                                {
                                    
                                    sygnal tmpTwo = listOfSygnals[k];
                                    
                                    tmp.right_id[count] = listOfSygnals[k].id;
                                    tmpTwo.left_id = listOfSygnals[i].id;
                                    listOfSygnals[i] = tmp;
                                    listOfSygnals[k] = tmpTwo;
                                    count++;
                                }
                                counter++;
                            } while (counter != listOfSygnals[i].tab.Length);
                        }
                    }
                }


            for(int i=0;i<listOfSygnals.Count;i++)
            {
                if(listOfSygnals[i].left_id==-1)
                {
                    Console.WriteLine("name and id = {0} {1}",listOfSygnals[i].name,listOfSygnals[i].id);
                }
            }
       
        }
    }
}
