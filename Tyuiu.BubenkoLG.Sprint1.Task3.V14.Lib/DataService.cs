using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.BubenkoLG.Sprint1.Task3.V14.Lib
{
    public class DataService : ISprint1Task3V14
    {
        public double ReverseNumber(double number)
        {
            double a = number / 100;
            double b = (number / 10) % 10;
            double c = number % 10;

            return Math.Round(c * 100 + b * 10 + a, 3);
        }
    }
}
