using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Constructor_2 : Rectangle
    {
        private int _height;

        public int height
        {
            get 
            { 
                return _height; 
            }
            set 
            { 
                _height = value; 
            }
        }

        private int _width;

        public int width
        {
            get 
            {  
                return _width; 
            }
            set 
            { 
                _width = value; 
            }
        }

        static Constructor_2() { }            // конструктор 2 (статический)


        public static void Num2()
        {
            Constructor_2 rectangle = new Constructor_2();
            rectangle._width = 10;
            rectangle._height = 34;
            Console.WriteLine($"Статический конструктор: \nПлощадь прямоугольника = {rectangle.Square(rectangle.height, rectangle.width)} Периметр прямоугольника = " +
                    $"{rectangle.Perimetr(rectangle.height, rectangle.width)}\n");
        }
    }
}
