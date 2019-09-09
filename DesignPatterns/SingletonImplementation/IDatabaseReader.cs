using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonImplementation
{
    public interface IDatabaseReader
    {
        int GetPopulation(string name);
    }
}
