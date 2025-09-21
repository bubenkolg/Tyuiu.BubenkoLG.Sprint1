using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BubenkoLG.Sprint1.Task0.V14.Lib;


namespace Tyuiu.BubenkoLG.Sprint1.Task0.V14
{
    internal class Program
    {
        static void Main(string[] args)
           
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнила: Бубенко Л. Г. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                                ");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                         ");
            Console.WriteLine("* Задание #0                                                               ");
            Console.WriteLine("* Вариант #14                                                              ");
            Console.WriteLine("* Выполнила: Бубенко Людмила Георгиевна | СМАРТб-25-1                      ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("* Написать программу, которая вычисляет выражение 2*3*3+7                  ");
            Console.WriteLine("* и печатает результат на экране.                                          ");
            Console.WriteLine("*                                                                          ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("* 2*3*3+7                                                                  ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate());
            Console.ReadKey();
        }
    }
}
