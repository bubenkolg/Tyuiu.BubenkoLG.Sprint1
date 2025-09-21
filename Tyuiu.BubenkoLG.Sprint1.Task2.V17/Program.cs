using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BubenkoLG.Sprint1.Task2.V17.Lib;


namespace Tyuiu.BubenkoLG.Sprint1.Task2.V17
{
    internal class Program
    {
        static void Main(string[] args)

        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Бубенко Л. Г. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                                ");
            Console.WriteLine("* Тема: Арифметические операторы в C#                                      ");
            Console.WriteLine("* Задание #1                                                               ");
            Console.WriteLine("* Вариант #17                                                              ");
            Console.WriteLine("* Выполнила: Бубенко Людмила Георгиевна | СМАРТб-25-1                      ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,  ");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.              ");
            Console.WriteLine("*                                                                          ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("* Время в минутах (целое число)                                            ");
            Console.WriteLine("***************************************************************************");

            int x;
            Console.WriteLine("Введите время в минутах (целое число) :");
            x = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Время в часах = " + ds.ConvertMinutesToHours(x));
            Console.ReadKey();
        }
    }
}
