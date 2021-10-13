using System;

namespace Lab2
{
    public partial class Circle
    {

        public double square { get; set; }
        public double length { get; set; }
        public static int radius { get; set; }

        public readonly int circleID;



        /*      Статический конструктор        */
        public static int Radius;

        static Circle()
        {
            Radius = 5;
            Console.WriteLine($"Статический конструктор: \nПлощадь круга = {Square(Radius)} Длина круга = " +
                $"{Length(Radius)}\n");
        }


        /*      Конструктор с параметрами            */

        public Circle(ref int count)
        {
            Console.WriteLine("Введите радиус: ");

            count++;
            radius = int.Parse(Console.ReadLine());
            square = Square(radius);
            length = Length(radius);
            circleID = GetHashCode();

        }


        /*      Закрытый конструктор       */
        private Circle() { }


        /*           переопределение toString()      */
        public override string ToString()
        {
            return $"Площадь: {square}\nДлина: {length}\nХэш: {circleID}\n\n";
        }

        /*           переопределение GetHashCode()   */

        public override int GetHashCode()
        {
            Random rand = new Random();
            return rand.Next(1, 50);
        }


        /*           переопределение Equals()   */
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;

            Circle circle = (Circle)obj;
            return (this.circleID == circle.circleID);
        }


    }

    public partial class Circle
    {
        public static double Square(int radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public static double Length(int radius)
        {
            return 2 * Math.PI * radius;    
        }
    }

}
