

namespace Lab10
{

    public class Game
    {

        public string? PersonName;

        string[] AllGun = { "AK-47", "M4A1", "AK-74", "Desert Eagle", "AWM" };

        public string Gun;

        public Game()
        {
            int choice;

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Введите имя: ");
            PersonName = Console.ReadLine();


            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Выберите оружие(цифру): \n1. AK-47\n 2. M4A1\n 3. AK-74\n 4. Desert Eagle\n 5. AWM\n ");
            choice = Convert.ToInt32(Console.ReadLine());
            
            switch(choice)
            {
                case 1: this.Gun = AllGun[0]; break;
                case 2: this.Gun = AllGun[1]; break;
                case 3: this.Gun = AllGun[2]; break;
                case 4: this.Gun = AllGun[3]; break;
                case 5: this.Gun = AllGun[4]; break;
            }
        }
            
    }

}

