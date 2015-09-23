using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestarurantSample.Rules
{
    public class Kitchen
    {
        private Table  _tableOrder;
        public Kitchen(Component _name)
        {
            _tableOrder = (Table)_name;
        }
        public void CalculateTimetoPreper()
        {
            DateTime day  = DateTime.Now;
            double timetoPrepare = 0;
            Console.WriteLine("Calculating time to cook Order");
            
            Console.WriteLine(_tableOrder.Name);
            Console.WriteLine ("Service Start {0}",day);
            Console.WriteLine ( "Table Orders {0} ",_tableOrder.Count());


            List<Component> orders = new List<Component>();           
            orders.AddRange(_tableOrder.tableOrder);
            Console.WriteLine("Table Dishes: {0}", orders.Count());

            foreach ( Component c in orders)
            {
                timetoPrepare= c.Count() * 7;    
            }            

            Console.WriteLine("The Order will be done at : {0}", day.AddMinutes(timetoPrepare).ToShortTimeString() );
        }
    }
}
