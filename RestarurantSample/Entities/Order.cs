using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestarurantSample
{
    public class Order:Component
    {
        private List<Component> _dishes = new List<Component>();

        public Order(string name) : base(name) { }

        public override void Add(Component c)
        {
            _dishes.Add(c);
        }

        public override void Remove(Component c)
        {
            _dishes.Add(c); ;
        }
        public override int Count()
        {
           return  _dishes.Count();
        }
        public override void Show()
        {
            Console.WriteLine(" Order : {0}",this._itemName);
            foreach (var d in this._dishes)
            {
                d.Show();
            }
        }

        
    }
}
