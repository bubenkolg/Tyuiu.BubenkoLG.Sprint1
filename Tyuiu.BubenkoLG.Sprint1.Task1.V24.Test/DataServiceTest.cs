using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BubenkoLG.Sprint1.Task1.V24.Lib;

namespace Tyuiu.BubenkoLG.Sprint1.Task1.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3.0;
            double y = 0.0;
            var res = ds.Calculate(x,y);
            Assert.AreEqual(-1,res);
        }
    }
}
