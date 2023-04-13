
using System;

class DoubleArray
{
    private double[,] array;

    public DoubleArray(int rows, int cols)
    {
        array = new double[rows, cols];
    }

    public double this[int i, int j]
    {
        get { return array[i, j]; }
        set { array[i, j] = value; }
    }

    public int Rows
    {
        get { return array.GetLength(0); }
    }

    public int Cols
    {
        get { return array.GetLength(1); }
    }

    public static DoubleArray operator +(DoubleArray da, DoubleArray column)
    {
        if (da.Rows != column.Rows)
            throw new ArgumentException("Number of rows in added column must match number of rows in array.");

        DoubleArray result = new DoubleArray(da.Rows, da.Cols + 1);
        for (int i = 0; i < da.Rows; i++)
        {
            result[i, 0] = column[i, 0];
            for (int j = 0; j < da.Cols; j++)
            {
                result[i, j + 1] = da[i, j];
            }
        }

        return result;
    }
}
