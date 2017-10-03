using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    abstract class AbstractPizzaStore
    {
        public abstract AbstractPizza createPizza(string type);

        public AbstractPizza orderPizza(string type)
        {
            AbstractPizza pizza = createPizza(type);

            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            return pizza;
        }
    }
}
