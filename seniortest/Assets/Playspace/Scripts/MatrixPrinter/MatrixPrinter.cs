using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MatrixPrinter
{
    public static class MatrixPrinter
    {
        // Function print matrix in spiral form
        public static string MatrixClockwised(int endingRowIndex, int endingColumnIndex, int[,] matrix)
        {
            int i;
            int rowIndex = 0, columnIndex = 0;
            string result = "";

            while (rowIndex < endingRowIndex && columnIndex < endingColumnIndex)
            {
                for (i = columnIndex; i < endingColumnIndex; ++i)
                {
                    int value = matrix[rowIndex, i];

                    result += value.ToString() + " ";
                }
                rowIndex++;

                for (i = rowIndex; i < endingRowIndex; ++i)
                {
                    int value = matrix[i, endingColumnIndex - 1];

                    result += value.ToString() + " ";
                }
                endingColumnIndex--;

                if (rowIndex < endingRowIndex)
                {
                    for (i = endingColumnIndex - 1; i >= columnIndex; --i)
                    {
                        int value = matrix[endingRowIndex - 1, i];
                        result += value.ToString() + " ";
                    }
                    endingRowIndex--;
                }

                if (columnIndex < endingColumnIndex)
                {
                    for (i = endingRowIndex - 1; i >= rowIndex; --i)
                    {
                        int value = matrix[i, columnIndex];
                        result += value.ToString() + " ";
                    }
                    columnIndex++;
                }
            }

            return result;
        }
    }
}
