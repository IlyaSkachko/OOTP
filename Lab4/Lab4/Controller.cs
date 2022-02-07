using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Controller
    {
        public static string choice;
        Aviacompany aviacompany = new Aviacompany();
        public Controller()
        {

            Console.WriteLine("Введите запрос");
            choice = Console.ReadLine();
            do
            {
                switch (choice)
                {
                    case "Вместимость": Console.WriteLine(aviacompany.Displayinfo());break;
                }
            } while (choice != "exit");
        }
    }
}
