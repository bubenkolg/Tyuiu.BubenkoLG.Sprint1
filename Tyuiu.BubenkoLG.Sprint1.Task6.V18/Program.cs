using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BubenkoLG.Sprint1.Task6.V18.Lib;


namespace Tyuiu.BubenkoLG.Sprint1.Task6.V18
{
    internal class Program
    {
        static void Main(string[] args)

        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Бубенко Л. Г. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                                ");
            Console.WriteLine("* Тема: Работа со строками класс String                                    ");
            Console.WriteLine("* Задание #1                                                               ");
            Console.WriteLine("* Вариант #18                                                              ");
            Console.WriteLine("* Выполнила: Бубенко Людмила Георгиевна | СМАРТб-25-1                      ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("* Написать программу: пользователь вводит текст. Проверить, что строка     ");
            Console.WriteLine("* является символьным представлением натурального числа.                   ");
            Console.WriteLine("*                                                                          ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("* Строка                                                                   ");
            Console.WriteLine("***************************************************************************");

            string str;
            Console.WriteLine("Введите строку:");
            str = Console.ReadLine();
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.CheckNumber(str));
            Console.ReadKey();
        }
    }
}
