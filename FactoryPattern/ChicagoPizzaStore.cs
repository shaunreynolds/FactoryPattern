using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class ChicagoPizzaStore : AbstractPizzaStore
    {
        public override AbstractPizza createPizza(string type)
        {
            switch (type)
            {
                case "cheese":return new ChicagoCheese("Chicago Cheese", "mozerella", "goats cheese", "feta");
                case "meat":return new ChicagoMeatFeast("Chicago Meat Feast", "pepperoni", "chilli beef", "pulled pork");
                default:return new Margherita("Margherita", "mozerella");
            }
        }

        private class ChicagoCheese : AbstractPizza
        {
            public ChicagoCheese(string type, params string[] toppings) : base(type, toppings)
            {
            }
        }

        private class ChicagoMeatFeast : AbstractPizza
        {
            public ChicagoMeatFeast(string type, params string[] toppings) : base(type, toppings)
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
