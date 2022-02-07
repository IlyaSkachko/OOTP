
using System.Reflection;

namespace Lab12
{
    class Reflector : Assembly
    {
        public int X;
        public Reflector(int i)
        {
            Console.Write("Hello");
        }

        public Reflector()
        {
            Console.WriteLine(" world!");
        }
        
        public int Ada(int a)
        {
            return a;
        }

    }

}
