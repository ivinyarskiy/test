/// <summary>
/// Разворачивает последовательность букв в разделенных пробелами подстроках введенной строки.
/// </summary>
/// <returns>
/// Возвращает строку с измененной на обратную последовательностью букв.
/// </returns>
using System;
namespace ConsoleApp1
{
    class Program
    {
      static void Main()
      {
        
            Console.WriteLine("Введите строку символов с разедлением строки пробелами:");
            string iniStr = Console.ReadLine();

            String result = Revers.Reverser(iniStr);
            Console.WriteLine("Строка с инвертированными буквами:");
            Console.WriteLine(result);

      } 
    }
}