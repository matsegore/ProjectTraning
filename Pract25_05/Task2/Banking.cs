using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract25_05.Task2
{
    class Banking
    {
        private static BankAccount[] bankAccounts = new BankAccount[0];

        public void AccChoose()
        {
            Console.WriteLine("Enter the owner to perform transaction or press 1 for continue adding for exit press 2");
            string result = Console.ReadLine();
            int Num;
            bool isNum = int.TryParse(result, out Num);
            if (isNum)
            {
                if (Num == 1)
                {
                    CreateAcc();
                }
                if (Num == 2)
                {
                    Environment.Exit(0);
                }
            }
            else
            {
                foreach (var item in bankAccounts)
                {
                    if (item.owner == result)
                    {
                        Console.WriteLine($"\n Owner: {item.owner}\n Balance: {item.currrentBalance}\n Type: {item.bankType}");

                        while (true)
                        {
                            int temp = 0;
                            int temp2 = 0;
                            int temp3 = 0;
                            switch (item.bankType)
                            {
                                case BankType.Credit:

                                    Console.WriteLine("Choose operation or press 9 for exit: \n 1)Null Balance \n 2)Iterest rate \n 3)Add Money \n 4)Withdraw Money \n 5)Charge interest");
                                    int resultCredit = Convert.ToInt32(Console.ReadLine());
                                    temp = resultCredit;

                                    if (resultCredit == 1)
                                    {
                                        Console.WriteLine($"Sum for null bal is: {item.currrentBalance}");
                                    }

                                    if (resultCredit == 2)
                                    {
                                        Console.WriteLine($"The rate is: {new CraditCard(item.owner, item.currrentBalance, item.bankType).CalculateOfRate()}");
                                    }

                                    if (resultCredit == 3)
                                    {
                                        Console.WriteLine("Add Money:");
                                        decimal addMoney = Convert.ToDecimal(Console.ReadLine());
                                        item.currrentBalance = new CraditCard(item.owner, item.currrentBalance, item.bankType).AddMoney(addMoney);
                                    }

                                    if (resultCredit == 4)
                                    {
                                        Console.WriteLine("Enter the amount to withdraw:");
                                        decimal withdrawMoney = Convert.ToDecimal(Console.ReadLine());
                                        item.currrentBalance = new CraditCard(item.owner, item.currrentBalance, item.bankType).WithDrawBalance(withdrawMoney);
                                    }

                                    if (resultCredit == 5)
                                    {
                                        item.currrentBalance = new CraditCard(item.owner, item.currrentBalance, item.bankType).InterestAccrual(new CraditCard(item.owner, item.currrentBalance, item.bankType).CalculateOfRate());
                                        Console.WriteLine($"The sum with interest: {item.currrentBalance}"); 
                                    }

                                    break;

                                case BankType.Deposit:

                                    Console.WriteLine("Choose operation or press 9 for exit: \n 1)Null Balance \n 2)Iterest rate \n 3)Charge interest");
                                    int resultDeposit = Convert.ToInt32(Console.ReadLine());
                                    temp2 = resultDeposit;
                                    if (resultDeposit == 1)
                                    {
                                        Console.WriteLine($"Sum for null bal is: {item.currrentBalance}");
                                    }

                                    if (resultDeposit == 2)
                                    {
                                        Console.WriteLine($"The rate is: {new Deposit(item.owner, item.currrentBalance, item.bankType).CalculateOfRate()}");
                                    }

                                    if (resultDeposit == 3)
                                    {
                                        item.currrentBalance = new Deposit(item.owner, item.currrentBalance, item.bankType).InterestAccrual(new CraditCard(item.owner, item.currrentBalance, item.bankType).CalculateOfRate());
                                        Console.WriteLine($"The sum with interest: {item.currrentBalance}");
                                    }

                                    break;

                                case BankType.Standart:

                                    Console.WriteLine("Choose operation or press 9 for exit: \n 1)Null Balance \n 2)Add Money \n 3)Withdraw Money");
                                    int resultStandart = Convert.ToInt32(Console.ReadLine());
                                    temp3 = resultStandart;

                                    if (resultStandart == 1)
                                    {
                                        Console.WriteLine($"Sum for null bal is: {item.currrentBalance}");
                                    }

                                    if (resultStandart == 2)
                                    {
                                        Console.WriteLine("Add Money:");
                                        decimal addMoney = Convert.ToDecimal(Console.ReadLine());
                                        item.currrentBalance = new Standart(item.owner, item.currrentBalance, item.bankType).AddMoney(addMoney);
                                    }

                                    if (resultStandart == 3)
                                    {
                                        Console.WriteLine("Enter the amount to withdraw:");
                                        decimal withdrawMoney = Convert.ToDecimal(Console.ReadLine());
                                        item.currrentBalance = new Standart(item.owner, item.currrentBalance, item.bankType).WithDrawBalance(withdrawMoney);
                                    }                               
                                    break;
                            }
                            if (temp == 9 || temp2 == 9 || temp3 == 9)
                            {
                                break;
                            }
                            
                        }
                    }
                }
            }
            Console.WriteLine("To dicplay accounts press 1");
            int press = Convert.ToInt32(Console.ReadLine());
            if (press == 1)
            {
                AccDisplay();
                AccChoose();
            }
        }

        public void AccDisplay()
        {
            foreach (var item in bankAccounts)

            {
                Console.WriteLine($"\n Owner: {item.owner}\n Balance: {item.currrentBalance}\n Type: {item.bankType}");
                Console.WriteLine();
            }
        }

        internal static void AddAccount(BankAccount bankAccount)
        {
            BankAccount[] extandetBankAccounts = new BankAccount [Banking.bankAccounts.Length + 1];

            for (int i = 0; i < Banking.bankAccounts.Length; i++)
            {
                extandetBankAccounts[i] = bankAccounts[i];
            }

            extandetBankAccounts [extandetBankAccounts.GetUpperBound(0)] = bankAccount;
            Banking.bankAccounts = extandetBankAccounts;
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
                        Deposit deposit = new Deposit(name, balance, BankType.Deposit);
                        Banking.AddAccount(deposit);
                        break;
                    case 2:
                        Standart standart = new Standart(name, balance, BankType.Standart);
                        Banking.AddAccount(standart);
                        break;
                    case 3:
                        CraditCard cradit = new CraditCard(name, balance, BankType.Credit);
                        Banking.AddAccount(cradit);
                        break;
                }

                

                Console.WriteLine($"Account created! For create new acc press 1, for display accounts press 2, for exit press 3");
                int choose = Convert.ToInt32(Console.ReadLine());
                if (choose == 1)
                {
                    continue;
                }
                if (choose == 3)
                {
                    break;
                }
                if (choose == 2)
                {
                    AccDisplay();
                    AccChoose();
                    break;
                }
            }
        }
    }
}
enum BankType
{
    Deposit,
    Standart,
    Credit,
}
