using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paract._15_06.Task1
{
    public class MaList<T> : IMyList<T>
    {
        private T[] array;

        public int Count => this.array.Length;

        T IMyList<T>.this[int index]
        {
            get
            {
                if (index > array.Length - 1)
                {
                    throw new Exception("Index is out of range");
                }
                else
                {
                    return array[index];
                }
            }

        }

        public MaList(T[] array)
        {
            ;
        }

        public void Add(T item)
        {
            T[] array2 = new T [array.Length+1];
            array.CopyTo(array2.Get);
        }

        public void Clear()
        {

        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }
    }
}
