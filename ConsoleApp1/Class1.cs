using System;

public class Revers 
{   
    //Принимает параметр - строку "слов", разделенных пробелами, и возвращает массив "слов"
    private static string[] StringToArray(string iniStr)
        {
        string[] words = iniStr.Split(' ');
        return words;
        }
    //Принимает строку - "слово" - и возвращает "слово" с переставленными в обратном порядке буквами.
    private static string WordRev(string word)
    {
        int iniIndex = 0;
        char[] wordArr= word.ToCharArray();
        string result = string.Empty;

        for (int i = 0; i < word.Length; i++)
        {
            if (Char.IsLetter(wordArr[i]))
            {
                iniIndex++;
            }
        }
        char[] lttrsArr = new char[iniIndex];
        int[] ltrPosition = new int[iniIndex];
        int lttrs = 0;
        for (int i = 0; i < word.Length; i++)
        {
            if (Char.IsLetter(wordArr[i]))
            {
                lttrsArr[lttrs] = wordArr[i];
                lttrs++;
            }
        }
        Array.Reverse(lttrsArr);
        iniIndex = 0;
        for (int i = 0; i < wordArr.Length; i++)
        {
            if (Char.IsLetter(wordArr[i]))
            {
                ltrPosition[iniIndex] = i;
                iniIndex++;
            }
        }
        for (int a = 0; a < lttrsArr.Length; a++)
        {
            wordArr[ltrPosition[a]] = lttrsArr[a];
        }
        result = new string(wordArr);
        return result;
    }
    //Принимает строку из разделенных пробелами "слов", возвращает строку из разделенных пробелами "слов" с переставленными в обратном порядке буквами.
    public static string Reverser(string inputString)
	{
        string result = string.Empty;
        string wrdRev = string.Empty;
        string[] wrdsA = StringToArray(inputString);
        const string separ=" ";

        for (int i = 0; i < wrdsA.Length; i++)
        {
            wrdRev= WordRev(wrdsA[i]);
        
            result = string.Concat(result, separ, wrdRev);
        }
        return result;  
    } 
 } 
