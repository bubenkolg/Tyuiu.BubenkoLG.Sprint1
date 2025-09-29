using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BubenkoLG.Sprint1.Task7.V18.Lib;


namespace Tyuiu.BubenkoLG.Sprint1.Task7.V18
{
    internal class Program
    {
        static void Main(string[] args)

        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Бубенко Л. Г. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                                ");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту.                 ");
            Console.WriteLine("* Задание #1                                                               ");
            Console.WriteLine("* Вариант #18                                                              ");
            Console.WriteLine("* Выполнила: Бубенко Людмила Георгиевна | СМАРТб-25-1                      ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение           ");
            Console.WriteLine("* по исходным значениям данных, вводимых пользователем.                    ");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                               ");
            Console.WriteLine("*                                                                          ");
            Console.WriteLine("*                 2                                                        ");
            Console.WriteLine("*          1 + sin (x + y)                                                 ");
            Console.WriteLine("* z = ------------------------ + x                                         ");
            Console.WriteLine("*          |        2*x     |                                              ");
            Console.WriteLine("*      2 + |x - ------------|                                              ");
            Console.WriteLine("*          |          2    2|                                              ");
            Console.WriteLine("*          |     1 + x  * y |                                              ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("* Числа X,Y.                                                               ");
            Console.WriteLine("***************************************************************************");

            double x, y;
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
