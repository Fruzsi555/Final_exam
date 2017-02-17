using System.Collections.Generic;
using System;

namespace FinalExam
{
    public class RowChecker
    {
        public int[] GetSums(List<List<int>> board)
        {
            int[] rowSum = null;
            try
            {
                rowSum = new int[board.Count];
            } catch(NullReferenceException e)
            {
                Console.WriteLine("error" + e);
            }
            int counter = 0;
            foreach (List<int> row in board)
            { 
                int sum = 0;
                foreach (int val in row)
                {
                    sum += val;
                }
                rowSum[counter] = sum;
                counter++;
            }
            return rowSum;
        }
    }
}
