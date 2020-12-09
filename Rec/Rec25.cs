﻿using System;

namespace Rec
{
    public class Rec25
    {
        public void RunRec(char[][] grid)
        {
            var xMid = grid[0].Length / 2;
            var yMid = grid.Length / 2;

            Print(grid);

            RunRec(grid, xMid, yMid);
            Console.Write("\n\n");

            Print(grid);
        }
        private void RunRec(char[][] grid, int indX, int indY)
        {
            if (grid[indX][indY] == '1') 
                return;
            grid[indX][indY] = '1';
            int tempIndX = indX;
            int tempIndY = indY;
            if (indX < grid.Length - 1)
                RunRec(grid, indX + 1, indY);
            indX = tempIndX;
            if (indX > 0) 
                RunRec(grid, indX - 1, indY);
            if (indY < grid[0].Length - 1) 
                RunRec(grid, indX, indY + 1);
            indY = tempIndY;
            if (indY > 0) 
                RunRec(grid, indX, indY - 1);
            return;
        }

        private void Print(char[][] grid)
        {
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    Console.Write($"{grid[i][j]} ");
                }
                Console.Write("\n");
            }

        }

    }
}
