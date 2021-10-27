using System;

namespace Lab3
{
    public class Owner
    {
        public readonly int ID;
        public readonly string Name;
        public string organization;

        public Owner()
        {
            ID = GetHashCode();
            Console.Write("Введите имя: ");
            Name = Console.ReadLine();
            Console.Write("\nВведите организацию: ");
            organization = Console.ReadLine();
        }
    }
}
