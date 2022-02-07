using System;


namespace Lab3
{
    public class Matrix
    {

        protected class Date
        {
            public readonly string CreateDate;

            public Date()
            {
                Owner owner = new Owner();
                Console.WriteLine("Введите дату(Через точку): ");
                CreateDate = Console.ReadLine();
            }
        }
        Random rand = new Random();
        public const int N = 4;
        public int[,] Arr = new int[N,N];

        public Matrix()
        {
            for (int i = 0; i < N; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    Arr[i, j] = rand.Next(1, 15);
                    Console.Write($"{Arr[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static int SumEl(Matrix m)
        {
            int sum = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    sum += m.Arr[i, j];
                }
            }
            return sum;
        }


        public static Matrix UnitMatrix(Matrix m)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i == j)
                    {
                        m.Arr[i, j] = 1;
                    }
                    else
                    {
                        m.Arr[i, j] = 0;

                    }
                    Console.Write($"{m.Arr[i, j]}\t");
                }
                Console.WriteLine();
            }
            return m;
        }

        public static Matrix inv(Matrix m)
        {
            int[] arr = new int[N];
            for (int k = 0; k < N; k++)
            {
                for (int i = 0; i < N; i++)
                {
                    arr[i] = m.Arr[k, i];
                }
                Array.Reverse(arr);
                for (int g = 0; g < N; g++)
                {
                    m.Arr[k, g] = arr[g];
                    Console.Write($"{m.Arr[k, g]}\t");
                }
                Console.WriteLine();
            }                
            Console.WriteLine();
            Console.WriteLine();
            
            return m;
        }

        public static bool operator <(Matrix m1, Matrix m2)
        {
            return SumEl(m1) < SumEl(m2);
        }

        public static bool operator >(Matrix m1, Matrix m2)
        {
            return SumEl(m1) > SumEl(m2);
        }



        public static Matrix operator -(Matrix m1)
        {
            return UnitMatrix(m1);
        }

        public static bool operator ==(Matrix m1, Matrix m2)
        {
            if(m1.Arr[0,0] == m2.Arr[0,0])
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Matrix m1, Matrix m2)
        {
            if (m1.Arr[0, 0] != m2.Arr[0, 0])
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Matrix operator +(Matrix m1)
        {
            return inv(m1);
        }
    }
}
