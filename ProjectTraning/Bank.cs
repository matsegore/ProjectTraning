using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTraning
{
    class Bank
    {
        public void BankLogic()
        {
            decimal debt = Debt();

            decimal payment = GetPayment();

            decimal difference = CalculatenDebt(debt, payment);

            ComparisonDebt(difference);
        }

        private decimal Debt()

        {

            Console.Write("Debt: ");

            while (true)
            {
                string strDebt = Console.ReadLine();

                bool isNumber = Decimal.TryParse(strDebt, out decimal debt);

                if (!isNumber)

                {
                    Console.WriteLine("Enter correct value.");

                    continue;
                }
                else

                    return debt;
            }
        }

        private decimal GetPayment()
        {
            Console.Write("Emount of payment: ");

            while (true)
            {
                string strPayment = Console.ReadLine();

                bool isNumber = Decimal.TryParse(strPayment, out decimal payment);

                if (!isNumber)

                {
                    Console.WriteLine("Enter correct value.");
                    continue;
                }

                else

                    return payment;
            }
        }

        private static decimal CalculatenDebt(decimal debt, decimal payment)
        {
            decimal difference = debt - payment;

            return difference;
        }

        private static void ComparisonDebt(decimal difference)
        {
            if (difference > 0)
            {
                Console.WriteLine($"Pay {difference} more.");
            }

            else if (difference < 0)
            {
                difference *= -1;

                Console.WriteLine($"Overpayment: {difference}.");
            }

            else
                Console.WriteLine("No debt.");

        }
    }
}
