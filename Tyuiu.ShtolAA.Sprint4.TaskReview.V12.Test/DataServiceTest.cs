using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShtolAA.Sprint4.TaskReview.V12.Lib;

namespace Tyuiu.ShtolAA.Sprint4.TaskReview.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string str = "658932125478";
            int rows = 3;
            int columns = 4;
            int wait = 30;
            int res = ds.Calculate(rows, columns, str);
            Assert.AreEqual(wait, res);
        }
    }
}
