using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestarurantSample
{
    public class Option:Component
    {
        public Option(string name) : base(name) { }
        public override void Add(Component c)
        {
        }

        public override void Remove(Component c)
        {
        }

        public override void Show()
        {
            Console.WriteLine("   Client Option - {0}",_itemName);
        }

        public override int Count()
        {
            return 0; 
        }
    }
}
