using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestarurantSample.Rules
{
    public class Waiter
    {
        private Command _orderCommand;
        public void setCommand(Command command)
        {
            this._orderCommand = command;
        }
        public void SendOrder()
        {
            Console.WriteLine(" Waiter is Checking and Executing Order");
            _orderCommand.Execute();
        }
    }
}
