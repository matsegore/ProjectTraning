using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Paract._15_06.Task_2
{
    internal class CarColection <T> where T : Car
    {
        private T[] carArr;

        public CarColection()
        {
            this.carArr = new T[0];
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

        }

        public override string ToString()
        {
            string text = "";
            for (int i = 0; i < carArr.Length; i++)
            {
                text += carArr[i].ToString();
            }
            return text;
        }


    }
}
