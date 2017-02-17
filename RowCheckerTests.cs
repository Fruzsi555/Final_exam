using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinalExam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam.Tests
{
    [TestClass()]
    public class RowCheckerTests
    {
        [TestMethod()]
        public void GetSumsTest()
        {
            RowChecker checker = new RowChecker();

            List<int> nums1 = new List<int>() { 5, 2, 5 };
            List<int> nums2 = new List<int>() { 5, 6, 20, 4 };

            List<List<int>> myList = new List<List<int>>();

            myList.Add(nums1);
            myList.Add(nums2);

            int[] expected = new int[] { 12, 35 };
            int[] actual = checker.GetSums(myList);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}