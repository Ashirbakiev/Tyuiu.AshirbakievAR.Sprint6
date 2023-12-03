using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AshirbakievAR.Sprint6.Task3.V17.Lib
{
    public class DataService : ISprint6Task3V17
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            int[] a = new int[5];
            for (int i = 0; i < rows; i++)
            {
                a[i] = matrix[i, 3];

            }
            Array.Sort(a);
            for (int i = 0; i < rows; i++)
            {
                matrix[i, 3] = a[i];
            }
            return matrix;
        }
    }
}
