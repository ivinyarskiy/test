using System;
namespace ConsoleApp1
{
    class Program
    {
      static void Main()
      {
        
            Console.WriteLine("Введите строку символов с разедлением строки пробелами:");
            string iniStr = Console.ReadLine();

            Console.WriteLine("Строка с инвертированными буквами:");
            Console.WriteLine(Revers.Reverser(iniStr));

      } 
    }
}
    
