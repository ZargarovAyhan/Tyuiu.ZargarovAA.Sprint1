using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ZargarovAA.Sprint1.Task4.V4.Lib;

namespace Tyuiu.ZargarovAA.Sprint1.Task4.V4
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
            Console.WriteLine("* Задание #4                                                               *");
            Console.WriteLine("* Вариант #4                                                               *");
            Console.WriteLine("* Выполнил Заргаров А. А. | ИИПб-23-2                                      *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу которая найдет число по формуле 1+xy/|x+2|            *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");
            int x, y;
            Console.Write("Введите значение X: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение Y: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine(ds.Calculate(x,y));
            Console.ReadLine();
        }
    }
}