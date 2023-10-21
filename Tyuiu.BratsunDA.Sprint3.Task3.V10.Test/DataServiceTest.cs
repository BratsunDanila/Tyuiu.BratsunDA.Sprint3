using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BratsunDA.Sprint3.Task3.V10.Lib;

namespace Tyuiu.BratsunDA.Sprint3.Task3.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void DeleteCharInString()
        {
            DataService ds = new DataService();
            string value = "gdfppf vfppt p";
            char item = 'p';

            string res = ds.DeleteCharInString(value, item);

            string wait = "gdff vft ";

            Assert.AreEqual(wait, res);

        }
    }
}
