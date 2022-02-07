//Класс - Матрица.Дополнительно перегрузить следующие операции: < -сравнения матриц; --приведение матрицы к единичному виду; == -сравнение матриц по первому элементу;
//+ – инверсия всех элементов матрицы.
//Методы расширения:
//1) Разность двух первых целых чисел строки
//2) Сумма элементов матрицы


using System;


namespace Lab3
{
    public class Program : Matrix
    {

        public static void Main()
        {
            Matrix m1 = new Matrix();
            Matrix m2 = new Matrix();
            bool res = m1 > m2;
            Console.WriteLine($"Сумма элементов матриц: {SumEl(m1)}, {SumEl(m2)}\n\n");
            Console.WriteLine($"сравнения матриц: {res}\n\n");
            Console.WriteLine($"сравнение матриц по первому элементу: {m1 == m2}\n\n");
            Console.WriteLine($"{+m1}\n");
            
            Console.WriteLine($"Количество элементов: {StatisticOperation.CountEl(m1)}");
            Console.WriteLine($"Разница между максимальным и минимальным элементом {StatisticOperation.Difference(m1)}");
            Console.WriteLine($"{-m1}");
            Console.WriteLine($"\nРазность двух первых целых чисел строки {StatisticOperation.str}: {StatisticOperation.def}");
            Date date = new Date();
        }
    }
}
