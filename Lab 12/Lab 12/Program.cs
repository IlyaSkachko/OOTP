using System;
using System.Reflection;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Reflector reflector = new Reflector();

            Type type = reflector.GetType();

            // 1. Определение имени сборки, в которой определен класс
            Console.WriteLine(type.Assembly);

            // 2. есть ли публичные конструкторы;
            Console.WriteLine(type.GetConstructors().Length);

            // 3. извлекает все общедоступные публичные методы класса
            foreach (ConstructorInfo ctor in type.GetConstructors())
            {
                Console.Write(type.Name + " (");
                // получаем параметры конструктора
                ParameterInfo[] parameters = ctor.GetParameters();
                for (int i = 0; i < parameters.Length; i++)
                {
                    Console.Write(parameters[i].ParameterType.Name + " " + parameters[i].Name);
                    if (i + 1 < parameters.Length) Console.Write(", ");
                }
                Console.WriteLine(")");
            }

            // 4. получает информацию о полях и свойствах класса
            Console.WriteLine("Поля:");
            foreach (var field in type.GetFields())
            {
                Console.WriteLine($"{field.FieldType} {field.Name}");

            }

            Console.WriteLine("\nСвойства:");
            foreach (var prop in type.GetProperties())
            {
                Console.WriteLine($"{prop.PropertyType} {prop.Name}");
            }

            // 5. получает все реализованные классом интерфейсы
            Console.WriteLine("\nРеализованные интерфейсы:");
            foreach (Type i in type.GetInterfaces())
            {
                Console.WriteLine(i.Name);
            }


            Console.WriteLine("\n");

        }

    }

}