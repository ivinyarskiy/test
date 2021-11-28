using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Revers 
{   
    public static string Reverser(string iniStr)
	{
                
        string rslt1=string.Empty;
        string result = string.Empty;
        string[] words = iniStr.Split(' ');
        //int itr = words.Length;
       
            for (int k = 0; k < words.Length; k++)
            {
                int iniIndex = 0;
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

                for (int z = 0; z < iniStrArr.Length; z++)
                {
                    rslt1 = string.Join(String.Empty, iniStrArr);


                }
            result = string.Concat(result," ", rslt1);
                
            } 

        //Console.WriteLine(result);
        return result;  
} 
    } 
