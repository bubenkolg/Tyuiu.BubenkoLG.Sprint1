using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BubenkoLG.Sprint1.Task5.V1.Lib;

namespace Tyuiu.BubenkoLG.Sprint1.Task5.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double x1 = 1.0;
            double y1 = 4.0;
            double x2 = 5.0;
            double y2 = 7.0;
            
            var res = ds.DistanceBetweenDots(x1, y1, x2, y2);

            int wait = 5;
            
            Assert.AreEqual(wait, res);
        }
    }
}
