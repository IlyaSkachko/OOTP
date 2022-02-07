using System;

namespace Lab7
{

    public interface ITransport
    {
        string TransportType();
    }


    abstract class Transport
    {
        public struct Auto
        {
            string Type;
        }

        public abstract string TransportType();
        public virtual int Capacity { get; set; }
        
    }

    class Pasenger : Transport, ITransport
    {
      
        public int capacity;
        public int gas { get; set; }

        public Pasenger()
        {
            try
            {
                Console.WriteLine("Потребление горючего для пассажирских(ТУ_124, ТУ_134, ТУ_154)");
                gas = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Информация добавлена");
            }
        }

        public override string TransportType()
        {
            return "Авиация(Пассажирский самолёт)";
        }

        public override string ToString()
        {
            return $"{capacity}";
        }
    }

    class Cargo : ITransport
    {

        public int capacity;

        public int gas { get; set; }

        public Cargo()
        {
            try
            {
                Console.WriteLine("Потребление горючего для грузовых(AN_124, AN_144)");
                gas = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Нужно ввести число!");
            }
        }


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
