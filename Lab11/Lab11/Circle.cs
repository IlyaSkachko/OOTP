using System;

namespace Lab11
{
    public partial class Circle
    {

        public double square { get; set; }
        public double length { get; set; }
        public int radius { get; set; }

        public readonly int circleID;

        public Circle()
        {
            Console.WriteLine("Введите радиус: ");

            radius = int.Parse(Console.ReadLine());
            square = Square(radius);
            length = Length(radius);
            circleID = GetHashCode();

        }





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
