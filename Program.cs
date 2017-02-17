using System;
using System.Collections.Generic;

namespace FinalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            RowChecker rowchecker = new RowChecker();

            List<int> nums1 = new List<int>() { 1, 2, 5 };
            List<int> nums2 = new List<int>() { 4, 6, 10 };
            List<int> nums3 = new List<int>() { 2, 6, 8, 4 };

            List<List<int>> myList = new List<List<int>>();

            myList.Add(nums1);
            myList.Add(nums2);
            myList.Add(nums3);

            int[] test = rowchecker.GetSums(myList);

            foreach (var val in test)
            {
                Console.WriteLine(val);
            }
        }
    }
}
