using System;
namespace ConsoleApp1
{
    class Program
    {
      static void Main()
        {
            string iniStr;
            iniStr = Console.ReadLine();
            string[] words = iniStr.Split(' ');
           
            for (int k = 0; k < words.Length; k++)
            {
                int iniIndex=0;
                char[] iniStrArr = words[k].ToCharArray();

                for (int i = 0; i < words[k].Length; i++)
                {

                    if (Char.IsLetter(iniStrArr[i]))
                    {
                        iniIndex++;
                    }
                }
                char[] outStrArr = new char[iniIndex];
                int[] LtrPosition = new int[iniIndex];
                int lttrs = 0;
                
                for (int i = 0; i < words[k].Length; i++)
                {
                    
                    if (Char.IsLetter(iniStrArr[i]))
                    {
                        outStrArr[lttrs] = iniStrArr[i];
                        lttrs++;
                      
                    }
                   
                }
                             
                Array.Reverse(outStrArr);
                Console.WriteLine(outStrArr.Length);
                
                iniIndex = 0;
                for (int i = 0; i < words[k].Length; i++)
                {
                    if (Char.IsLetter(iniStrArr[i]))
                    {
                        LtrPosition[iniIndex] = i;
                        iniIndex++;
                        
                    }
                }
               for (int a = 0; a < outStrArr.Length; a++)
                        {
                   iniStrArr[LtrPosition[a]] = outStrArr[a];
                        }
                Console.WriteLine(iniStrArr);
            }
                } 
            }
        }
    
