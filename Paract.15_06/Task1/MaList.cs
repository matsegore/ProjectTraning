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

        //internal static void AddAccount(BankAccount bankAccount)
        //{
        //    BankAccount[] extandetBankAccounts = new BankAccount[Banking.bankAccounts.Length + 1];

        //    for (int i = 0; i < Banking.bankAccounts.Length; i++)
        //    {
        //        extandetBankAccounts[i] = bankAccounts[i];
        //    }

        //    extandetBankAccounts[extandetBankAccounts.GetUpperBound(0)] = bankAccount;
        //    Banking.bankAccounts = extandetBankAccounts;
        //}

        public MaList()
        {
            this.array = new T[0];
        }

        public void Add(T item)
        {
            T[] array2 = new T[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                array2[i] = array[i];
            }
            array2[array2.GetUpperBound(0)] = item;
            this.array = array2;
        }

        public void Clear()
        {
            array = new T[0];
        }

        public bool Contains(T item)
        {
            if (array.Contains(item))
            {
                Console.WriteLine("");
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            string text = "";
            for (int i = 0; i < array.Length; i++)
            {
                text += array[i].ToString();
            }
            return text ;
        }
    }
}
