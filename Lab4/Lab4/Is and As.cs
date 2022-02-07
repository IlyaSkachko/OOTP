using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class OtherTransport
    {
        public string Name { get; set; }
        public OtherTransport(string name)
        {
            Name = name;
        }
        public void Display()
        {
            Console.WriteLine($"Transport {Name}");
        }
    }

    class Bycicle : OtherTransport
    {
        public string Company { get; set; }
        public Bycicle(string name, string company) : base(name)
        {
            Company = company;
        }
    }
}
