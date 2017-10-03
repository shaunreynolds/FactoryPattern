using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class NYPizzaStore : AbstractPizzaStore
    {
        public override AbstractPizza createPizza(string type)
        {
            switch (type)
            {
                case "cheese": return new NYCheese("NY Cheese", "mozerella", "goats cheese", "feta");
                case "meat": return new NYMeatFeast("NY Meat Feast", "pepperoni", "chilli beef", "pulled pork");
                default: return new Margherita("NY Margherita", "mozerella");
            }
        }

        private class NYCheese : AbstractPizza
        {
            public NYCheese(string type, params string[] toppings) : base(type, toppings)
            {
            }
        }

        private class NYMeatFeast : AbstractPizza
        {
            public NYMeatFeast(string type, params string[] toppings) : base(type, toppings)
            {
            }
        }

        private class Margherita : AbstractPizza
        {
            public Margherita(string type, params string[] toppings) : base(type, toppings)
            {
            }
        }
    }
}
