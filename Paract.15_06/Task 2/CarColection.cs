using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Paract._15_06.Task_2
{
    internal class CarColection<T> where T : Car
    {
        public T[] carArr;

        public CarColection()
        {
            this.carArr = new T[0];
        }

        T this[string name]
        {

            get
            {
                T car = null;
                for (int i = 0; i < carArr.Length; i++)
                {
                    if (carArr[i].Name.Equals(name) == true)
                    {
                        car = carArr[i];
                    }
                    else
                    {
                        throw new Exception("No name");
                    }                  
                }
                return car;
            }

        }


        public void Add(T item)
        {
            T[] array2 = new T[carArr.Length + 1];
            for (int i = 0; i < carArr.Length; i++)
            {
                array2[i] = carArr[i];
            }
            array2[array2.GetUpperBound(0)] = item;
            this.carArr = array2;
        }

        public void Clear()
        {
            carArr = new T[0];
        }

        public void Contains()
        {
            int counter = 0;
            for (int i = 0; i < carArr.Length; i++)
            {
                counter++;
            }
            Console.WriteLine(counter);
        }

        public override string ToString()
        {
            string text = "";
            for (int i = 0; i < carArr.Length; i++)
            {
                text += carArr[i];
            }
            return $"{text}";
        }
    }
}
