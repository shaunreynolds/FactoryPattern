using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static AbstractPizzaStore pizzaStore1;
        static AbstractPizzaStore pizzaStore2;

        static void Main(string[] args)
        {

            pizzaStore1 = new ChicagoPizzaStore();
            pizzaStore2 = new NYPizzaStore();

            pizzaStore1.createPizza("cheese").create();
            pizzaStore2.createPizza("cheese").create();

            pizzaStore1.createPizza("meat").create();
            pizzaStore2.createPizza("meat").create();

            pizzaStore1.createPizza("not an option").create();
            pizzaStore2.createPizza("not an option").create();

            Console.In.ReadLine();
        }
    }
}
