using System;
using System.Collections.Generic;
using System.Text;

namespace Rec
{
    public class Rec24
    {
        public int CountNeighbours(int[][] arr, bool[][] checks, int n, int i, int j)
        {
            checks[i][j] = true;
            int naibs = 0;
            if (i > 0 && !checks[i - 1][j])
            {
                if (arr[i - 1][j] == 1)
                {
                    naibs++;
                    naibs += CountNeighbours(arr, checks, n, i - 1, j);
                }
            }
            if (j > 0 && !checks[i][j - 1])
            {
                if (arr[i][j - 1] == 1)
                {
                    naibs++;
                    naibs += CountNeighbours(arr, checks, n, i, j - 1);
                }
            }
            if (i < n - 2 && !checks[i + 1][j])
            {
                if (arr[i + 1][j] == 1)
                {
                    naibs++;
                    naibs += CountNeighbours(arr, checks, n, i + 1, j);
                }
            }
            if (j < n - 2 && !checks[i][j + 1])
            {
                if (arr[i][j + 1] == 1)
                {
                    naibs++;
                    naibs += CountNeighbours(arr, checks, n, i, j + 1);
                }
            }
            return naibs;
        }

        public void Print(int[][] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(arr[i][j] + " ");
                Console.WriteLine();
            }
        }

    }
}
