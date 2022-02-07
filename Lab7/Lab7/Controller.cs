//Транспорт, Авиация, Грузовой самолет, Пассажирский, Военный, Ty134, Boeing.
using System;
using System.Diagnostics;

namespace Lab7
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

    class Controller
    {

        static void ExHanding()
        {
            try 
            {
                int y = 4;
                int x = y / 0;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"1. {ex.Message},   \nстроковое представление стека вызывов, которые привели к возникновению исключения:" +
                    $"{ex.StackTrace}, \nметод, в котором и было вызвано исключение: {ex.TargetSite}, \nимя объекта или сборки, которое вызвало исключение: " +
                    $"{ex.Source} ");
            }
            try
            {
                int[] arr = new int[4];
                arr[7] = 8;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"2. {ex.Message},   \nстроковое представление стека вызывов, которые привели к возникновению исключения:" +
                    $"{ex.StackTrace}, \nметод, в котором и было вызвано исключение: {ex.TargetSite}, \nимя объекта или сборки, которое вызвало исключение: " +
                    $"{ex.Source} ");
            }
            try
            {
                object obj = "you";
                int num = (int)obj;
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine($"3. {ex.Message},  \nстроковое представление стека вызывов, которые привели к возникновению исключения:" +
                    $"{ex.StackTrace}, \nметод, в котором и было вызвано исключение: {ex.TargetSite}, \nимя объекта или сборки, которое вызвало исключение: " +
                    $"{ex.Source}\n\n ");
            }
        }

        static void Main()
        {
            ExHanding();
            Aviacompany aviacompany = new();
            aviacompany.PasInfo();
            aviacompany.CargoInfo();
            int val = 2;
            Debug.Assert(val != 2, " Value should not be 2.");
            while (true)
            {

                menu(aviacompany);
            }

        }

        private static void menu(Aviacompany aviacompany)
        {
            Console.WriteLine("\n\n1. Вместимость(ТУ_134, ТУ_154, ТУ_124 )\n2. Грузоподъёмность(AN_144, AN_124 AN_174)\n3. Поиск по потреблению горючего\n");
            Console.WriteLine("Введите запрос");

            try
            {
                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            foreach (object o in aviacompany.PasList)
                            {
                                Console.WriteLine(o);
                            }
                            try
                            {
                                int x = Convert.ToInt32(Console.ReadLine());
                                if (x != 143)
                                    if (x != 321)
                                        if (x != 512)
                                            throw new Exception("Нет такого значения");
                                        else
                                            aviacompany.PasList.Remove(x);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            break;

                        case 2:
                            foreach (object o in aviacompany.CargoList)
                            {
                                Console.WriteLine(o);
                            }
                            break;

                        case 3:
                            int gas = Convert.ToInt32(Console.ReadLine());
                            aviacompany.Gas(gas);
                            break;

                        default:
                            Console.WriteLine("Нет информации"); break;

                    }
                }
                catch
                {
                    Console.WriteLine("Возникло исключение");
                    throw;
                }
            }
            catch(ArgumentException ex)
            {
                throw new ArgumentException(ex.Message);
            }
            catch (OtherException ex)
            {
                throw new OtherException(ex.Message);
            }
            finally
            {
                menu(aviacompany);
            }
        }


    }

    class InvException : InvalidCastException
    {
        public InvException(string message)
            : base(message)
        { }
    }
    class ArgException : ArgumentException
    {

        public int Value { get; }

        public ArgException(string message, int val)
            : base(message)
        {
            Value = val;
        }
    }
    class OtherException : Exception
    {
        public OtherException(string message)
            : base(message)
        { }
    }
}

