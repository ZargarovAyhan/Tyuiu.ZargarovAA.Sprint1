using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ZargarovAA.Sprint1.Task6.V5.Lib;

namespace Tyuiu.ZargarovAA.Sprint1.Task5.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = Console.Title = "Спринт #1| Выполнил: Заргаров А. А. | ИИПб-23-2";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                *");
            Console.WriteLine("* Тема: Базовые навыки работы C#                                           *");
            Console.WriteLine("* Задание #6                                                               *");
            Console.WriteLine("* Вариант #5                                                               *");
            Console.WriteLine("* Выполнил Заргаров А. А. | ИИПб-23-2                                      *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу которая выведет симметричные слова                    *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");
            string x;
            Console.Write("Введите значение X: ");
            x = Convert.ToString(Console.ReadLine());
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ :                                                              *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine(ds.CheckSymmetricalWords(x));
            Console.ReadLine();
        }
    }
}