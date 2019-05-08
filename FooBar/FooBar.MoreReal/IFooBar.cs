using System;
using System.Collections.Generic;

namespace FooBar.MoreReal
{
    public interface IFooBar
    {
        IEnumerable<string> FooBars();
        void ProcessEach(Action<string> action);
    }
}