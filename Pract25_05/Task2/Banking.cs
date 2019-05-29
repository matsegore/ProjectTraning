using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract25_05.Task2
{
    class Banking
    {
        private static BankAccount[] bankAccounts = new BankAccount[1];

        internal static void AddAccount(BankAccount bankAccount)
        {
            BankAccount[] extandetBankAccounts = {bankAccount};

            //foreach (var item in Banking.bankAccounts)


            for (int i = 0; i < Banking.bankAccounts.Length; i++)
            {
                for (int j = 0; j < extandetBankAccounts.Length; j++)
                {
                    Banking.bankAccounts[i] = extandetBankAccounts[j];
                }  
            }
            foreach (var item in Banking.bankAccounts)
            {
                Console.WriteLine(item);
            }
        }

        public void CreateAcc()
        {
            while (true)
            {
                Console.WriteLine("Hi enter owner Name and SName for creating account");
                string name = Console.ReadLine();

                Console.WriteLine("Enter a sum of balance");
                decimal balance = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Choose what tipe of account you want to create: 1)Deposit 2)Standart 3)Credit");
                int result = Convert.ToInt32(Console.ReadLine());
                switch (result)
                {
                    case 1:
                        Deposit deposit = new Deposit(name);
                        Banking.AddAccount(deposit);
                        break;
                    case 2:
                        Standart standart = new Standart(name);
                        Banking.AddAccount(standart);
                        break;
                    case 3:
                        CraditCard cradit = new CraditCard(name);
                        Banking.AddAccount(cradit);
                        break;
                }

                Console.WriteLine($"Accound created for create new acc press 1 for exit press 2");
                int choose = Convert.ToInt32(Console.ReadLine());
                if (choose == 1)
                {
                    continue;
                }
                if (choose == 2)
                {
                    break;
                }
            }
        }
    }
}
