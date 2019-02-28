using Microsoft.VisualStudio.TestTools.UnitTesting;
using MostAreAverage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostAreAverage.Tests
{
    [TestClass()]
    public class Class1Tests
    {
            Class1 class1 = new Class1();
        [TestMethod()]
        public void LetterGradeTest()
        {

            Assert.AreEqual("D",class1.LetterGrade(60));
        }

        [TestMethod()]
        public void AdditionTest()
        {
            // Unsure of the way to test this method.
            Assert.AreEqual(1, class1.Addition(1));
        }








    }
}