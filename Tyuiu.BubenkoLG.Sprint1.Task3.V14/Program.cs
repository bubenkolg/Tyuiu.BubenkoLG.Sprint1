using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BubenkoLG.Sprint1.Task3.V14.Lib;


namespace Tyuiu.BubenkoLG.Sprint1.Task3.V14
{
    internal class Program
    {
        static void Main(string[] args)

        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Бубенко Л. Г. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                                ");
            Console.WriteLine("* Тема: Операторы составного присваивания                                  ");
            Console.WriteLine("* Задание #1                                                               ");
            Console.WriteLine("* Вариант #14                                                              ");
            Console.WriteLine("* Выполнила: Бубенко Людмила Георгиевна | СМАРТб-25-1                      ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("* Написать программу, которая позволяет определить число, полученное       ");
            Console.WriteLine("* выписыванием в обратном порядке цифр заданного трехзначного числа.       ");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                               ");
            Console.WriteLine("*                                                                          ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("* Трёхзначное число                                                        ");
            Console.WriteLine("***************************************************************************");

            double number;
            Console.WriteLine("Введите трёхначное число:");
            number = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.ReverseNumber(number));
            Console.ReadKey();
        }
    }
}
