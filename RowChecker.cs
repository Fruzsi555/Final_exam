using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    class RowChecker
    {
        public int[] GetSums(List<List<int>> board)
        {
            int[] rowSum = new int[board.Count];

            foreach (List<int> row in board)
            { 
                int sum = 0;
                foreach (int val in row)
                {
                    sum += val;
                }
                int counter = 0;
                rowSum[counter++] = sum;
            }
            return rowSum;
        }
    }
}
