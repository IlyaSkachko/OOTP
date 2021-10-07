using System;

namespace Lab2
{
    public class Constructor_1 : Rectangle
    {
        public int height;
        public int width;



        public Constructor_1(int height, int width)  // конструтор 1 
        {
            this.height = height;
            this.width = width;
        }



        public static void Num1()
        {
            int height;
            int width;

            Console.Write("Введите ширину прямоугольника: ");
            width = int.Parse(Console.ReadLine());
            Console.Write("Введите высоту прямоугольника: ");
            height = int.Parse(Console.ReadLine());

            Constructor_1 rectangle = new Constructor_1(height, width);

            Console.Write($"Площадь прямоугольника = {rectangle.Square(height, width)}\nПериметр прямоугольника = " +
                    $"{rectangle.Perimetr(height, width)}");
        }

    }
}
