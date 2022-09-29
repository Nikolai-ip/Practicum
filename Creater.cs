using System;

namespace PracticumLabs
{
    internal static class Creater
    {
        public static int[] RandomArray(int countElements)
        {
            int[] array = new int[countElements];
            Random random = new Random();
            for (int i = 0; i < countElements; i++)
            {
                array[i] = random.Next(1, 100);
            }
            return array;
        }

        public static int[,] RandomArray(int rows, int column)
        {
            int[,] array = new int[rows, column];
            Random random = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    array[i, j] = random.Next(1, 100);
                }
            }
            return array;
        }

        public static int[][] SteppedArr(int rows, int columns)
        {
            int[][] array = new int[rows][];
            Random random = new Random();
            int[] fillArr = new int[rows];
            for (int i = 0; i < rows * columns; i++)
            {
                fillArr[random.Next(0, rows)]++;
            }
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new int[fillArr[i]];
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array[i].GetLength(0); j++)
                {
                    array[i][j] = random.Next(1, 100);
                }
            }
            return array;
        }
    }
}