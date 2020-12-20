using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mikhnevich
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите свое имя: ");
            string name = Console.ReadLine();       // вводим имя
            Console.WriteLine($"Привет {name}");    // выводим имя на консоль
            Console.ReadKey();
        } 
    }
}
