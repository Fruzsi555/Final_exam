using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                RowChecker rowchecker = new RowChecker();

                List<int> nums1 = new List<int>(new int[] { 1, 2, 5 });
                List<int> nums2 = new List<int>(new int[] { 4, 6, 10 });
                List<int> nums3 = new List<int>(new int[] { 2, 6, 8, 4 });

                List<List<int>> myList = new List<List<int>>();

                myList.Add(nums1);
                myList.Add(nums2);
                myList.Add(nums3);

                rowchecker.GetSums(myList);
            }
        }
    }
}
