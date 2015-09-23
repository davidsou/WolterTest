using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestarurantSample
{
    public class Dish:Component
    {
        public Dish(string name) : base(name) { }
        public List<Component> dishOptions = new List<Component>();
        public Decimal Price { get; set; }
        public String Description { get; set; }

        public Dish(string name, decimal price, string description)
        {
            this._itemName = name;
            this.Price = price;
            this.Description = description;
        }

        public override void Add(Component c)
        {
            dishOptions.Add(c);
        }

        public override void Remove(Component c)
        {
            dishOptions.Remove(c);
        }
        public override int Count()
        {
            return dishOptions.Count;
        }

        public override void Show()
        {
           Console.WriteLine("  Dish name {0}, Price {1}, Descripton {2}", this._itemName, this.Price, this.Description );
            foreach (var d in dishOptions)
            {
                d.Show();
            }
        }

        
    }
}
