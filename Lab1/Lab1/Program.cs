using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Exercise
    {
        static void Main(string[] args)
        {

            bool a = true;
            char symbol = 'a';
            byte num1 = 255; // От 0 до 255	8-разрядное целое число без знака
            sbyte num2 = -127;// От - 128 до 127  8 - разрядное целое число со знаком
            float num3 = 5.7863f;
            double num4 = 6.76532124677;
            decimal num5 = 12.124124124124124124m;
            int num6 = 2141;
            uint num7 = 4294967295; //От 0 до 4 294 967 295   32 - разрядное целое число без знака
            long num8 = -9223372036854775807; //От -9 223 372 036 854 775 808 до 9 223 372 036 854 775 807	64-разрядное целое число со знаком
            ulong num9 = 0; //От 0 до 18 446 744 073 709 551 615  64 - разрядное целое число без знака
            short num10 = 32767; //От -32 768 до 32 767    16 - разрядное целое число со знаком
            ushort num11 = 65535; //От 0 до 65 535  16 - разрядное целое число без знака


            Console.WriteLine("-----------------Задание 1-----------------\n");


            // Неявно типизированная переменная
            var l = new List<int>();

            List<int> k = new List<int>();

            // Nullable 
            int? z = 7;
            Console.WriteLine($"Nullable переменная: {z.Value}, {z.HasValue}\n");


            //Неявное преобразование 
            conv1(num8, num6, num1, num4, num3, num10);

            // Явное преобразование
            conv2(num1, num8, num4, num10, num6);

            // преобразование Convert
            conv3();

            // Упаковка и распоковка
            packing();

            //Определите переменную типа var и присвойте ей любое
            //значение.Затем следующей инструкцией присвойте ей значение
            //другого типа. Объясните причину ошибки

            var str = "str";
            //str = 8;



            Console.WriteLine("\n\n\n-----------------Задание 2-----------------\n");

            str_1();
            null_str();
            str_builder();

            Console.WriteLine("\n\n\n-----------------Задание 3-----------------\n");

            arr();

            Console.WriteLine("\n\n\n-----------------Задание 4-----------------\n");

            tuples();


            Console.WriteLine("\n\n\n-----------------Задание 5-----------------\n");



            int[] array = new int[] { 13, 22, 41, 11, 42, 32 };
            string strin = "Ilya";

            // локальная функция

            static (int, int, int, char) loc(int[] arr, string str)
            {
                int min = arr[0], max = arr[1], sum = 0;
                char letter = str[0];
                for (int i = 0; i < arr.Length; i++)
                {
                    if (min > arr[i])
                    {
                        min = arr[i];
                    }
                   
                    if ( max < arr[i])
                    {
                        max = arr[i];
                    }

                    sum += arr[i];
                }

                //Console.WriteLine($"Минимальный: {min}, Максимальный: {max}, Сумма: {sum}, Первая буква: {letter}");

                var  result = (min, max, sum, letter);
                return result;
                
            }

            Console.WriteLine(loc(array, strin));




            Console.WriteLine("\n\n\n-----------------Задание 6-----------------\n");


            void ex1()
            {
                try
                {
                    checked
                    {
                        int a = 2147483647, b = 2;
                        int result = a + b;
                        Console.WriteLine(result);
                    }
                }
                catch(OverflowException)
                {
                    Console.Write("Переполнение\n\n");
                }
            }

            void ex2()
            {
                unchecked
                {
                    int a = 2147483647, b = 2;
                    int result = a * b;
                    Console.WriteLine(result);
                }
            }

            ex1(); ex2();
        }





        //Неявное преобразование
        static void conv1(long num8, int num6, byte num1, double num4, float num3, short num10)
        {
            num8 = num6;
            num4 = num3;
            num6 = num1;
            Console.WriteLine($"Неявное преобразование: {num8}; {num4}; {num6}; ");
            num8 = num10;
            num6 = num10;
            Console.WriteLine($"{num8}; {num6}\n\n");
        }

        // Явное преобразование
        static void conv2(byte num1, long num8, double num4, short num10, int num6)
        {
            Console.WriteLine($"Явное преобразование: {(short)num1}; {(ulong)num8}; {(decimal)num4}; {(ushort)num10}; {(uint)num6}");
        }


        // преобразование Convert
        static void conv3()
        {
            short s = 45;
            byte b = Convert.ToByte(s);
            Console.WriteLine("Byte = {0}", b);
            long l = 1234;
            int k = Convert.ToInt32(l);

        }

        // Упаковка и распаковка
        static void packing()
        {
            // Упаковка 
            int x = 10;
            object y = x;
            x++;
            Console.WriteLine($"Объект: {y}, переменная: {x}\n");

            // Распаковка
            y = 15;
            x = (int)y;
            Console.WriteLine($"X: {x}, Y: {y}");
        }


        static void str_1()
        {

            // Сравнение строк
            string str1 = "Hello", str2 = "World", str3 = "!!!";
            if (str1 == str2)
            {
                Console.WriteLine("Одинаковые строки");
            }
            else
            {
                Console.WriteLine("Разные строки");
            }

            // Объединение строк
            string str4 = String.Concat(str1, " ", str2, str3);
            Console.WriteLine("Объединение строк: " + str4 + "\n");

            // копирование 
            string str5 = str1.Substring(1, 3);
           Console.WriteLine("Копирование: " + str5 +"\n");

            // разделение строки на слова
            Console.WriteLine("Разделение на слова: ");

            string[] words = str4.Split(new[] { ' ', '!'}, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            // Вставка 

            Console.WriteLine("\nВставка: \n");

            str1 = str1.Insert(1, str5);
            Console.WriteLine(str1 + "\n");

            //Удаление
            Console.WriteLine("Удаление: \n");
            str1 = str1.Remove(1, 3);
            Console.WriteLine(str1 + "\n");
        }
        

        // Пустая и null строки
        static void null_str()
        {
            string empty_str = "rf";
            string? str_null = null;
            Console.WriteLine("Строка null и пустая строка: \n");
            Console.WriteLine(String.IsNullOrEmpty(empty_str));
            Console.WriteLine(String.IsNullOrEmpty( str_null)+"\n");
            Console.WriteLine(String.IsNullOrWhiteSpace(empty_str));
        }
        

        //StringBuilder
        static void str_builder()
        {
            StringBuilder str = new StringBuilder("Hello world!");
            str.Remove(2, 3);
            Console.WriteLine("\nУдаление символов: " + str);
            str.Insert(0, "Jack, ");
            str.Insert(str.Length, " Bye!");
            Console.WriteLine("\nВставка в начало и конец: " + str);
        }

        static void arr()
        {

            int[,] mas = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };

            int rows = mas.GetUpperBound(0) + 1;
            int columns = mas.Length / rows;

            Console.WriteLine("Двухмерный массив: ");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mas[i, j]} \t");
                }
                Console.WriteLine();
            }

            string[] array = new string[] { "Hello", "world", "!"};
            Console.WriteLine("Одномерный массив: ");
            foreach (string word in array)
            {
                Console.Write(word + " ");
            }

            Console.WriteLine($"\nДлина массива: {array.Length}");

            Console.WriteLine("Выберите позицию и значение: ");
            int pos = Convert.ToInt32(Console.ReadLine());
            string val = Console.ReadLine();

            array[pos] = val;
            foreach (string word in array)
            {
                Console.Write(word + " ");
            }

            Console.WriteLine("\n");

            // Ступенчатый массив

            int[][] step_array = new int[3][];
            step_array[0] = new int[2] { 5, 1 };
            step_array[1] = new int[3] { 6, 2, 4 };
            step_array[2] = new int[4] { 3, 7, 9, 8 };
            for (int i = 0; i < step_array.Length; i++)
            {
                for (int j = 0; j < step_array[i].GetLength(0); j++)
                {
                    Console.Write(step_array[i][j] + " ");
                }
                Console.Write('\n');
            }


            // Неявно типизированные переменные для хранения массива и строк

            var massiv = new object[0];
            var str = "";
        }   
        
        static void tuples()
        {
            (int, string, char, string, ulong) tuple = (18, "Ilya", 'A', "Skachko", 9460800);
            Console.WriteLine($"Полный вывод: {tuple}\nВыборочный вывод: {tuple.Item2} {tuple.Item4}");

            // Распоковка кортежа в перемменные 
            var (age, name, sym, surname, min) = tuple;

        }
    }
}
