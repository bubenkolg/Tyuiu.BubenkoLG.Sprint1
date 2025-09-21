using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.BubenkoLG.Sprint1.Task2.V17.Lib
{
    public class DataService : ISprint1Task2V17
    {
        public int ConvertMinutesToHours(int value)
        {
            return value / 60;
        }
    }
}
