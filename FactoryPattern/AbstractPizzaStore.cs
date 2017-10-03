﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    abstract class AbstractPizzaStore
    {
        abstract AbstractPizza createPizza(string item);
    }
}
