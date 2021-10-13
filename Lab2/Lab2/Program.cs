using System;

namespace Lab2
{
    public class Program
    {

        public static void info(out int count, out bool res, out Type type)
        {
            count = 1;
            var circles = new Circle[4];
            for (int i = 0; i < 4; i++)
            {
                circles[i] = new Circle(ref count);
            }

            foreach (var circle in circles)
            {
                Console.WriteLine(circle.ToString());
            }

            // сравнение
            res = circles[0].Equals(circles[1]);

            // тип объекта
            type = circles.GetType();


            // Найменьшая и найбольшая площадь
            minMaxSquare(circles);

        }

        public static void minMaxSquare(Circle[] circles)
        {
            double maxSq;
            double minSq;
            Circle max = circles[0];
            Circle min = circles[0];
            minSq = circles[0].square;
            maxSq = circles[0].square;
            for (int i = 0; i < 4; i++)
            {
                if (maxSq < circles[i].square)
                {
                    max = circles[i];
                }
            }
            for (int i = 0; i < 4; i++)
            {
                if (minSq > circles[i].square)
                {
                    min = circles[i];
                }
            }
            Console.WriteLine($"\n\nОкружность с найбольшей площадью: {max}\nОкружность с найменьшой площадью: {min}\n\n");
        }

        public static void privateConstructor()
        {
            Circle.radius = 10;
            Console.WriteLine($"Закрытый конструктор(радиус): {Circle.radius}");
        }


        public static void Main()
        {
            int count;
            Type type;
            bool res;
            info(out count, out res, out type);
            Console.WriteLine($"\nКоличество объектов: {count}\n\nОкружность 1 равна окружность 2: {res}\n\nТип созданного объекта: {type}\n\n");
            privateConstructor();
        }
    }
}
