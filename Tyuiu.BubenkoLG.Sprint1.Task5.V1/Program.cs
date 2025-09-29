using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BubenkoLG.Sprint1.Task5.V1.Lib;


namespace Tyuiu.BubenkoLG.Sprint1.Task5.V1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Бубенко Л. Г. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                                ");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                               ");
            Console.WriteLine("* Задание #1                                                               ");
            Console.WriteLine("* Вариант #1                                                               ");
            Console.WriteLine("* Выполнила: Бубенко Людмила Георгиевна | СМАРТб-25-1                      ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("* Написать программу, которая решает следующую задачу:                     ");
            Console.WriteLine("* Найти расстояние между двумя точками с заданными координатами (x, y).    ");
            Console.WriteLine("* Ответ привести к целому с помощью класса Convert.                        ");
            Console.WriteLine("*                                                                          ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("* Координаты двух точек                                                    ");
            Console.WriteLine("***************************************************************************");

            double x1, y1, x2, y2;
            Console.WriteLine("Введите X1:");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Y1:");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите X2:");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Y2:");
            y2 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.DistanceBetweenDots(x1,y1,x2,y2));
            Console.ReadKey();
        }
    }
}
