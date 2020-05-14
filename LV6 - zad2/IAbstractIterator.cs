using System;
using System.Collections.Generic;
using System.Text;

namespace LV6___zad2
{
    interface IAbstractIterator
    {
        Product First();
        Product Next();
        bool IsDone { get; }
        Product Current { get; }
    }
}
