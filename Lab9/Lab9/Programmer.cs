
namespace Lab9
{
    public delegate void Message(string message);
    public class Programmer
    {

        public Message mes;
        public event Message Delete;
        public event Message Mutate;

       

        public string Name { get; set; }
        public string Level { get; set; }
        public Programmer()
        {
            Console.WriteLine("Введите имя: ");
            Name = Console.ReadLine();
        }


        public static void ShowInfo(Programmer programmer)
        {
            Console.WriteLine($"\nИмя: {programmer.Name}\n");
            
        }


        public void LevelProgrammer(string level)
        {
            Mutate(level);
        }

        public List<Programmer> DeleteNode(List<Programmer> programmers, Programmer programmer)
        {
            programmers.Remove(programmer);
            if (programmers.Remove(programmer))
            {
                DeleteMessage("Удален из списка");
            }
            return programmers;
        }
        public void DeleteMessage(string message)
        {
            Delete(message);
        }

    }

}
