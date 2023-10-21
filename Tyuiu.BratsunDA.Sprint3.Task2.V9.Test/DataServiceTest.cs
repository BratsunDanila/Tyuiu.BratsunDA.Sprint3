using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BratsunDA.Sprint3.Task2.V9.Lib;

namespace Tyuiu.BratsunDA.Sprint3.Task2.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 10;
            int value = 5;

            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 0.042;
            Assert.AreEqual(wait, res);
        }
    }
}
