using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Collections;


namespace Lab10
{
    public class Collection : IEnumerable<Game>
    {
        List<Game>? AllPerson;


        public IEnumerator<Game> GetEnumerator()
        {
            return GetEnumerator();
        }

        IEnumerator<Game> IEnumerable<Game>.GetEnumerator()
        {
            return GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)AllPerson).GetEnumerator();
        }



        public static void Search(List<Game>? AllPerson)
        {
            string name;

            Console.WriteLine("Введите имя персонажа: ");
            name = Console.ReadLine();

            for (int i = 0; i < AllPerson.Count; i++)
            {
                if (AllPerson[i].PersonName == name)
                {
                    Console.WriteLine($"\n{AllPerson[i].PersonName} - {AllPerson[i].Gun}\n\n");
                }
            }
        }

        public static void OutPut(List<Game> AllPerson)
        {
            for (int i = 0; i < AllPerson.Count; i++)
            {
                Console.WriteLine($"\n{AllPerson[i].PersonName} - {AllPerson[i].Gun}\n\n");
            }
        }
    }
}
