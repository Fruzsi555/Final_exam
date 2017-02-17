using System.Collections.Generic;

namespace FinalExam
{
    class RowChecker
    {
        public int[] GetSums(List<List<int>> board)
        {
            int[] rowSum = new int[board.Count];
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
