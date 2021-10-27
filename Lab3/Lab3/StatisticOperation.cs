using System;


namespace Lab3
{
    static class StatisticOperation
    {
        public static string str = "534";
        public static int def = str.DifferenceEl();

        public static int CountEl(Matrix m)
        {
            int count = 0;
            for (int i = 0; i < Matrix.N; i++)
            {
                for (int j = 0; j < Matrix.N; j++)
                {
                    count++;
                }
            }
            return count;
        }

        public static int Difference(Matrix m)
        {
            int max = m.Arr[0, 0];
            int min = m.Arr[0, 0];
            
            for (int i = 0; i < Matrix.N; i++)
            {
                for (int j = 0; j < Matrix.N; j++)
                {
                    if (max < m.Arr[i, j])
                    {
                        max = m.Arr[i, j];
                    }
                    if (min > m.Arr[i,j])
                    {
                        min = m.Arr[i, j];
                    }
                }
            }
            
            return max - min;
        }

    }

    public static class Expension
    {
        public static int DifferenceEl(this string str)
        {
            int num1 = str[0];
            int num2 = str[1];
            return num1 - num2;
        }
    }
}
