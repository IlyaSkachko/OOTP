using System;

namespace Lab4
{
    abstract class Print
    {
        public abstract void IAmPrinting(Transport transport);
    }

    class Printer : Print
    {
        public override void IAmPrinting(Transport transport)
        {
            string type = transport.GetType().ToString();
        }
    }

}
