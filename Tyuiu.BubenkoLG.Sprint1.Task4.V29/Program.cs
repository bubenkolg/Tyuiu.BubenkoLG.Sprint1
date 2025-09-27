using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BubenkoLG.Sprint1.Task4.V29.Lib;


namespace Tyuiu.BubenkoLG.Sprint1.Task4.V29
{
    internal class Program
    {
        static void Main(string[] args)

        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Бубенко Л. Г. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                                ");
            Console.WriteLine("* Тема: Class Math                                                         ");
            Console.WriteLine("* Задание #1                                                               ");
            Console.WriteLine("* Вариант #29                                                              ");
            Console.WriteLine("* Выполнила: Бубенко Людмила Георгиевна | СМАРТб-25-1                      ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,  ");
            Console.WriteLine("* вычисляет результат по формуле и печатает его на экране.                 ");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                               ");
            Console.WriteLine("*                                                                          ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("* Два числа.                                                               ");
            Console.WriteLine("***************************************************************************");

            double x,y;
            Console.WriteLine("Введите X:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Y:");
            y = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(x,y));
            Console.ReadKey();
        }
    }
}
