using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Revers 
{   
    //Принимает параметр - строку "слов", разделенных пробелами, и возвращает массив "слов"
    private static string[] WordsArray (string iniStr)
        {
        string[] words = iniStr.Split(' ');
        //int WordsCount = words.Length;
        return words;
        }

    //Принимает строку - "слово" - и возвращает "слово" с переставленными в обратном порядке буквами.
    private static string WordRev(string word)
    {
        int iniIndex = 0;
        char[] WordArr= word.ToCharArray();
        string RevWord = string.Empty;

        for (int i = 0; i < word.Length; i++)
        {
            if (Char.IsLetter(WordArr[i]))
            {
                iniIndex++;
            }
        }
        char[] LttrsArr = new char[iniIndex];
        int[] LtrPosition = new int[iniIndex];
        int lttrs = 0;
        for (int i = 0; i < word.Length; i++)
        {
            if (Char.IsLetter(WordArr[i]))
            {
                LttrsArr[lttrs] = WordArr[i];
                lttrs++;
            }
        }
        Array.Reverse(LttrsArr);
        iniIndex = 0;
        for (int i = 0; i < WordArr.Length; i++)
        {
            if (Char.IsLetter(WordArr[i]))
            {
                LtrPosition[iniIndex] = i;
                iniIndex++;

            }
        }
        for (int a = 0; a < LttrsArr.Length; a++)
        {
            WordArr[LtrPosition[a]] = LttrsArr[a];
        }

        RevWord = new string(WordArr);
        return RevWord;
    }
    
    //основной метод, возвращающий строку из разделенных пробелами "слов" с переставленными в обратном порядке буквами.
    public static string Reverser(string Words)
	{
        string result = string.Empty;
        string WrdRev = string.Empty;
        string[] wrdsA = WordsArray(Words);

        for (int i = 0; i < wrdsA.Length; i++)
        {
            WrdRev= WordRev(wrdsA[i]);
        
            result = string.Concat(result, " ",WrdRev);
        }
        
        
        return result;  
    } 
 } 
