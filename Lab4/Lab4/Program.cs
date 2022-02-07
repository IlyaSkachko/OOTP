//Транспорт, Авиация, Грузовой самолет, Пассажирский, Военный, Ty134, Boeing.
using System;
using System.Collections;

namespace Lab4
{

    sealed partial class Military : Transport, ITransport
    {
        public override string ToString()
        {
            return $"Тип объекта: {this.GetType()}\n Тип транспорта: {TransportType()}";
        }

        public override bool Equals(object obj)
        {
            return this == obj;
        }

        public override int GetHashCode()
        {
            return new Random().Next(0, 100000000);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("-----Is-------");
            //OtherTransport transport = new OtherTransport("Audi");
            //if (transport is Bycicle)
            //{
            //    Bycicle bmx = (Bycicle)transport;
            //    Console.WriteLine(bmx.Company);
            //}
            //else
            //{
            //    Console.WriteLine("Преобразование не допустимо");
            //}

            //Console.WriteLine("\n\n\n-----As-------");
            //Bycicle bmx1 = transport as Bycicle;
            //if (bmx1 == null)
            //{
            //    Console.WriteLine("Преобразование прошло неудачно");
            //}
            //else
            //{
            //    Console.WriteLine(bmx1.Company);
            //}


            //Console.WriteLine("\n\nПереопределение ToString() и информация об объекте");
            //Console.WriteLine($"{TU_124.ToString()}\n{AN_124.ToString()}\n{TU_160.ToString()}");

            Aviacompany aviacompany = new();

            Console.WriteLine("Введите запрос");
            string choice = Console.ReadLine();
                if (choice == "Вместимость")
                {
                    Console.WriteLine($"{aviacompany.Displayinfo()}");
                }
                else if (choice == "Грузоподъёмность")
                {
                    Console.WriteLine($"{aviacompany.CarList()}");
                }
                else
                {
                    Console.WriteLine("Нет информации");
                }
        }

    
    }
}
