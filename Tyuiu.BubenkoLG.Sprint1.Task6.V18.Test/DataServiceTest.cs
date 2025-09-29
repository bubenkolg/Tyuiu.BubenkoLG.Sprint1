using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BubenkoLG.Sprint1.Task6.V18.Lib;

namespace Tyuiu.BubenkoLG.Sprint1.Task6.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();

            string value = "123sdf";

            var res = ds.CheckNumber(value);

            bool wait = false;
            Assert.AreEqual(wait,res);
            
        }
    }
}
