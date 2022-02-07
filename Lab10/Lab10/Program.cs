using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Lab10
{
    class Program
    {
        static Game og = new();
        static List<Game>? AllPerson = new List<Game>();
        


        public static void Main(string[] args)
        {
            Game MainPerson = new Game();
            Game Ally_1 = new Game();
            Game Ally_2 = new Game();
            AllPerson.Add(og);

            int choice;
            while (true) 
            {
                Console.WriteLine("1. Добавить объект \n2. Удалить объект\n  3. Найти элемент\n  4. Вывод всех элементов");
                Console.WriteLine("Введите операцию: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1: 
                            AllPerson.Add(MainPerson);
                            AllPerson.Add(Ally_1);
                            AllPerson.Add(Ally_2);
                        break;

                    case 2: string name;
                        Console.WriteLine("Введите Имя: "); name = Console.ReadLine();
                        if (name == MainPerson.PersonName)
                        {
                            AllPerson.Remove(MainPerson);
                        }
                        else if (name == Ally_1.PersonName)
                        {
                            AllPerson.Remove(Ally_1);
                        }
                        else if (name == Ally_2.PersonName)
                        {
                            AllPerson.Add(Ally_2);
                        }
                        break;

                    case 3: Collection.Search(AllPerson);
                        break;
                    case 4: Collection.OutPut(AllPerson);
                        break;
                    default:
                        Console.WriteLine("Нет такого значения");
                        break;
                }

            }

        }
        public static void ThirdCollection()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;

            var collection = new ObservableCollection<Game>();

            collection.CollectionChanged += SayChange;

            collection.Add(new Game());
            collection.Add(new Game());
            collection.Add(new Game());

            collection.RemoveAt(2);
        }
        private static void SayChange(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
                Console.WriteLine("|Add comlete|");
            else if (e.Action == NotifyCollectionChangedAction.Remove) Console.WriteLine("|Remove complete|");
        }
    }
}