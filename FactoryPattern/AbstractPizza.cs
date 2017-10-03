using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    abstract class AbstractPizza
    {
        string type;
        string[] toppings;

        public AbstractPizza(string type, params string[] toppings)
        {
            this.type = type;
            this.toppings = toppings;
        }

        public void prepare()
        {
            Console.Out.WriteLine("Preparing pizza of type: " + type);
            foreach (string t in toppings)
            {
                Console.Out.WriteLine("Adding toppings: " + t);
            }
        }

        public void bake()
        {
            Console.Out.WriteLine("Baking pizza of type: " + type);
        }

        public void cut()
        {
            Console.Out.WriteLine("Cutting pizza of type: " + type);
        }

        public void box()
        {
            Console.Out.WriteLine("Boxing pizza of type: " + type);
        }

        public void create()
        {
            prepare();
            bake();
            cut();
            box();
        }
    }
}
