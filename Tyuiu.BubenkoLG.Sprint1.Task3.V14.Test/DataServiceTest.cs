using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BubenkoLG.Sprint1.Task3.V14.Lib;
namespace Tyuiu.BubenkoLG.Sprint1.Task3.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double number = 123;
            var res = ds.ReverseNumber(number);
            double wait = 324.23;
            Assert.AreEqual(wait, res);
        }
    }
}
