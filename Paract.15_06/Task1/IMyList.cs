using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paract._15_06.Task1
{
    interface IMyList <T>
    {
        void Add(T item);
        T this[int index] { get; }
        int Count { get; }
        void Clear();
        bool Contains(T item);

    }
}
