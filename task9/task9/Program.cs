using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива");
            int countStrings = Convert.ToInt32(Console.ReadLine());
            string[] strings = new string[countStrings];
            for (int i = 0; i < strings.Length; i++)
            {
                Console.WriteLine("Введите строку " + i);
                strings[i] = Console.ReadLine();
            }
            Console.WriteLine("Введите искомую подстроку");
            string subString = Console.ReadLine();
            foreach (string s in strings)
            {
                int posSubString = s.IndexOf(subString);
                if (posSubString != -1)
                    Console.WriteLine("Найдена в строке " + s + " ,начиная с " + posSubString + " символа");
            }
            Console.ReadKey();
        }
    }
}
