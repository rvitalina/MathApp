using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Пример использования Calculator
            Console.WriteLine("5 + 3 = " + Calculator.Add(5, 3));

            try
            {
                Console.WriteLine("10 / 2 = " + Calculator.Divide(10, 2));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
        }
    }
}
