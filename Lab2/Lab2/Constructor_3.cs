using System;


namespace Lab2
{
    public class Constructor_3 : Rectangle
    {
        private Constructor_3() { }       // конструктор 3 (закрытый)

        public static void Num3()
        {
            int height;
            int width;

            Console.Write("Введите ширину прямоугольника: ");
            width = int.Parse(Console.ReadLine());
            Console.Write("Введите высоту прямоугольника: ");
            height = int.Parse(Console.ReadLine());

            Constructor_3 rectangle = new Constructor_3();
            Console.Write($"Площадь прямоугольника = {rectangle.Square(height, width)}\nПериметр прямоугольника = " +
                                $"{rectangle.Perimetr(height, width)}");
        }
    }
}
