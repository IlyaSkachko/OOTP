using System.Collections.Generic;
using System.Linq;
using System;

namespace Lab11
{
    class Program
    {

        static void Main(string[] args)
        {
            var weekday = new string[] {"June", "July", "August", "September", "October", "November", "December",
                                        "January", "February", "March", "April", "May" };

            //ex1(weekday);

            ex2();

            Console.ReadLine();

        }


        static void ex1(string[] weekday)
        {
            int n;

            Console.WriteLine("Введите количество букв в месяце");
            n = Convert.ToInt32(Console.ReadLine());

            var days = weekday.Where(weekday => weekday.Length == n);

            Console.WriteLine($"Слова из {n} букв: ");
            foreach (var item in days)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            var winterDays = weekday.Where(weekday => weekday == "January" || weekday == "February" ||
                                           weekday == "December");

            Console.WriteLine($"Зимнее месяцы: ");
            foreach (var item in winterDays)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            var summerDays = weekday.Where(weekday => (weekday == "June" || weekday == "July" ||
                               weekday == "August"));

            Console.WriteLine($"Летние месяцы: ");
            foreach (var item in summerDays)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine($"Месяцы в Алфавитном порядке: ");

            var weekdayABC = weekday.OrderBy(weekday => weekday);

            foreach (var item in weekdayABC)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine("Месяцы содержащие букву «u» и длиной имени не менее 4-х");

            var AnyWeekDay = weekday.Where(weekday => weekday.Length >= 4 && (weekday[1] == 'u' || weekday[3] == 'u'
                                            || weekday[4] == 'u'));

            foreach (var item in AnyWeekDay)
            {
                Console.WriteLine(item);
            }

        }


        static void ex2()
        {
            /*группы окружностей, центры которых лежат на одной прямой;
            наибольший и наименьший по площади(периметру) объект; 
            Количество окружностей заданного радиуса
            Первую окружность, лежащую в первой четверти 
            Упорядоченный список окружностей по площади*/

            List<Circle> circles = new List<Circle>();

            for (int i = 0; i< 10; i++)
            {
                var circle = new Circle();
                circles.Add(circle);
            }

            var circleMax = circles.Max(circles => circles.square);

            var circleMin = circles.Min(circles => circles.square);

            Console.WriteLine($"Максимальная площадь: {circleMax}\nМинимальная площадь: {circleMin}");


            Console.WriteLine("\nВведите радиус: ");

            int r = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Количество окружностей с заданным радиусом: {circles.Count(circles => circles.radius == r)}");


        }
    }
}