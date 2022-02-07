using System;

namespace Lab4
{

    public interface ITransport
    {
        string TransportType();
    }


    abstract class Transport
    {
        public string Type = "Автомобиль";
        public abstract string TransportType();
        public virtual int Capacity { get; set; }
    }

    class Pasenger : Transport, ITransport
    {
        public int capacity;
        //public Pasenger()
        //{
        //    Console.WriteLine("Введите вместимость пассажирского самолёта: ");
        //    capacity = Convert.ToInt32(Console.ReadLine());
        //}

        public override string TransportType()
        {
            return "Авиация(Пассажирский самолёт)";
        }

        public override string ToString()
        {
            return $"Вместимость : {capacity}";
        }
    }

    class Cargo :  ITransport
    {
        public int capacity;
        //public Cargo()
        //{
        //    Console.WriteLine("Введите грузоподъёмность: ");
        //    capacity = Convert.ToInt32(Console.ReadLine());

        //}
        public int Capacity
        {
            get { return capacity; }
            set { capacity = Capacity; }
        }

        public string TransportType()
        {
            return "Авиация(Грузовой самолёт)";
        }

        public override string ToString()
        {
            return $"Грузоподъёмность: {capacity} ";
        }
    }

     sealed partial class Military : Transport, ITransport
     {
        public override string TransportType()
        {
            return "Авиация(Военный самолёт)";
        }
     }
}
