using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestarurantSample
{
    public class Table:Component
    {
        public  List<Component> tableOrder = new List<Component>();
        public Table(string name):base(name)
        {
            
        }


        public override void Add(Component c)
        {
            this.tableOrder.Add(c);
        }

        public override void Remove(Component c)
        {
            this.tableOrder.Remove(c);

        }
        public override int Count()
        {
            return tableOrder.Count();
        }

        public override void Show()
        {
            Console.WriteLine(_itemName);
            foreach(var d  in this.tableOrder)
            {
                d.Show();
            }

        }

        
    }
}
