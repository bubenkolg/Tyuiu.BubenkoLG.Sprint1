using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BubenkoLG.Sprint1.Task4.V29.Lib;

namespace Tyuiu.BubenkoLG.Sprint1.Task4.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 5;
            var res = ds.Calculate(x,y);
            double wait = 0.007;
            Assert.AreEqual(wait, res);
        }
    }
}
