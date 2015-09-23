using RestarurantSample.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestarurantSample
{
    class Program
    {
        /// <summary>
        /// I wrote all variables and comments in English because the first test was in english
        /// I used 2 main patterns in this sample - composite and command
        /// The command pattern is in charge to build the Order
        /// A restaurant order is usually composed by another elements, 
        /// and this elements can be composed too. This approach can help the system evolution
        /// The second part is send the order to kitchen. In this case, The command part is in charge
        /// this makes decoupling between the Waiter and the Kitchen.
        /// The Kitchen will calculate the time for prepare the order.
        /// It's possible to upgrade the system, 
        /// build a Order queue or keep a single Kitchen instance, for instance
        /// but for the this test, I'll will keep this as simple as possible.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Create a table
            Component table = new Table("Table 1");
            // Create a Order Table
            Component order  = new Order("Client Order");
            // Create all dishes ask by the client
            Component dish1 = new Dish("Starter", 100.0m, "cesar salad");
            Component dish2 = new Dish("Main Course 1");
            Component dish3 = new Dish("Main Course 2");
            Component dish4 = new Dish("Dessert");
            //Add some dishes options
            dish1.Add(new Option("salt less"));
            dish2.Add(new Option("Spice"));
            dish4.Add(new Option("without Sugar"));
            // Add dishes into the Order
            order.Add(dish1);
            order.Add(dish2);
            order.Add(dish3);
            order.Add(dish4);
            // Add the Order into the Table
            table.Add(order);
            
            // Show the Order on screen
            table.Show();

            Console.ReadLine();

            // Start the receiver of the order
            Kitchen kitchen = new Kitchen( table);
            // Create the Order passing de receiver
            Command cmd = new OrderCommand(kitchen);
            // Invoker Starts
            Waiter waiter = new Waiter();
            // Set and execute the command
            //Set
            waiter.setCommand(cmd);
            //Execute
            waiter.SendOrder();
            Console.ReadLine();


        }
    }
}
