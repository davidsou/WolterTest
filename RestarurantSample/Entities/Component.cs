using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestarurantSample
{
    public abstract class Component
    {
        public string Name { get; private set; }
        protected string _itemName;
        public Component() { }
        public Component(string name)
        {
            this._itemName = name;
            this.Name = name;
        }
        public abstract void Add( Component c);
        public abstract void Remove(Component c);
        public abstract int Count();
        public abstract void Show();
       
    }
}
