using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Tests
{
    [TestClass()]
    public class FindPlateTests
    {
        [TestMethod()]
        public void SortByCountryTest()
        {
            FindPlate findPlate = new FindPlate(new string[] { "ДТП 1|FR222222", "ДТП 2|UK222222", "ДТП 3|BY101010" });
            List<StringBuilder> act = findPlate.SortByCountry();
            List<StringBuilder> expect = new List<StringBuilder> { new StringBuilder("ДТП 1|FR222222"), new StringBuilder("ДТП 2|UK222222") };
            for(int i = 0; i < act.Count; i++)
            {
                Assert.AreEqual(act[i].ToString(), expect[i].ToString());
            }
        }

        [TestMethod()]
        public void StringСomparisonTest1()
        {
            string str1 = "abcde";
            string str2 = "abced";
            FindPlate act = new FindPlate(new string[] { "sdf|FR243456" });
            Assert.IsTrue(act.StringСomparison(str1, str2));
        }


        [TestMethod()]
        public void StringСomparisonTest2()
        {
            string str1 = "abcde";
            string str2 = "abcde";
            FindPlate act = new FindPlate(new string[] { "sdf|FR243456" });
            Assert.IsFalse(act.StringСomparison(str2, str1));
        }

        [TestMethod()]
        public void StringСomparisonTest3()
        {
            string str1 = "abcde";
            string str2 = "abced";
            FindPlate act = new FindPlate(new string[] { "sdf|FR243456" });
            Assert.IsFalse(act.StringСomparison(str2, str1));
        }

        [TestMethod()]
        public void StringСomparisonTest4()
        {
            string str1 = "aaa";
            string str2 = "bbbbbbbbbbbbbbbb";
            FindPlate act = new FindPlate(new string[] { "sdf|FR243456" });
            Assert.IsTrue(act.StringСomparison(str1, str2));
        }
    }
}