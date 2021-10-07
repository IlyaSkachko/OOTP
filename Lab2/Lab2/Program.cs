using System;


namespace Lab2
{
    class Program
    {
        public static void Menu()
        {
            int choice;
            const int EXIT = 3;

            Constructor_2.Num2();
            while (true)
            {
                Console.WriteLine("\n1. Закрытый конструктор\n2. Конструктор с аргументами\n3. Выход из программы");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Constructor_3.Num3();
                        break;

                    case 2:
                        Constructor_1.Num1();
                        break;
                    case EXIT:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.Write("Ошибка ввода!!!");
                        break;
                }

                Console.ReadLine();
                Console.Clear();
            }
        }


        public static void Main(string[] args)
        {
            Menu();
        }
    }
}
