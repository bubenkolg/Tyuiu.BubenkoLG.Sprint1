using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BubenkoLG.Sprint1.Task7.V18.Lib;

namespace Tyuiu.BubenkoLG.Sprint1.Task7.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double x = 5.0;
            double y = 10.0;
            double res = ds.Calculate(x,y);
            
            Assert.AreEqual(res, 5.203);

        }
    }
}
