//Создать класс Программист с событиями Удалить и Мутировать. В main создать некоторое количество объектов (списков). Подпишите объекты на 
//события произвольным образом. Реакция на события может быть следующая: удаление первого/последнего элемента списка, случайное перемещение строк и т.п.
//Проверить результаты изменения состояния объектов после наступления событий, возможно не однократном

namespace Lab9
{

    class Program
    {
        static Func<string> A;
        static void Main(string[] args)
        {

            ///*      ------------        Задание 1       ------------        */

            List<Programmer> ProgrammerList = new List<Programmer>();

            Programmer programmer1 = new Programmer();
            Programmer programmer2 = new Programmer();
            Programmer programmer3 = new Programmer();




            ProgrammerList.Add(programmer1);
            ProgrammerList.Add(programmer2);
            ProgrammerList.Add(programmer3);

            foreach (var programmer in ProgrammerList)
            {
                // обработчики события
                programmer.Mutate += MutateMessage;
                programmer.Delete += DeleteMessage;

                // добавление к делегату методов
                programmer.mes += programmer.LevelProgrammer;
                programmer.mes += programmer.DeleteMessage;

            }




            DisplayMessage(ProgrammerList);
            programmer2.DeleteNode(ProgrammerList, programmer2);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n-----------------\n\n");

            DisplayMessage(ProgrammerList);
            Console.ResetColor();


            Console.WriteLine();
            Console.WriteLine();

            /*      ---------       Задание 2          --------     */


            StrProcessing obj = new StrProcessing();

            Console.ForegroundColor = ConsoleColor.Green;
            A += obj.Upper;
            A += obj.AddSymb;
            A += obj.DeleteMarks;
            A += obj.DeleteSpace;
            A += obj.Sub;

            A();

            Console.ResetColor();


        }

        private static void MutateMessage(string level)
        {
            Console.WriteLine(level);
        }

        private static void DeleteMessage(string delete)
        {
            Console.WriteLine(delete);
        }

        private static void DisplayMessage(List<Programmer> programmers)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            foreach (var programmer in programmers)
            {
                Programmer.ShowInfo(programmer);
                programmer.LevelProgrammer("Уровень: Junior");
            }
            Console.ResetColor();
        }
    }
}