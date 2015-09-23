using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestarurantSample.Rules
{
    public class OrderCommand:Command
    {
        private Kitchen _kitchen;
        public OrderCommand(Kitchen kitchen)
        {
            this._kitchen = kitchen;
        }
        public override void Execute()
        {
            Console.WriteLine("Order Command - Command send to kitchen ");
            _kitchen.CalculateTimetoPreper();
        }
    }
}
