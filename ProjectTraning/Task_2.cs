using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTraning
{
    class Task_2
    {
        public static void Task2()
        {
            Console.Write("Add your currency: ");
            string currency = Console.ReadLine();
            Console.Write("Add geting currency: ");
            string getingCurrency = Console.ReadLine();         
            double sum = GetNumbers();
            Showresult(currency, getingCurrency, sum);
        }
 
        static double GetNumbers()
        {
            double result = 0;
            while (true)
            {
                Console.WriteLine("Add sum: ");
                if (Int32.TryParse(Console.ReadLine(), out int operand1))
                {
                    result = operand1;
                }
                else
                {
                    Console.WriteLine("Add correct value");
                    continue;
                }               
                return result;
            }
        }
        static double FinanceOp(string currency, string getingCurrency, double sum)
        {

                if ((currency == "ua") & (getingCurrency == "us"))
                {
                    sum *= 0.037;
                }
                else if ((currency == "ua") & (getingCurrency == "ru"))
                {
                    sum *= 2;
                }
                else if ((currency == "ru") & (getingCurrency == "ua"))
                {
                    sum *= 0.4;
                }
                else if ((currency == "ru") & (getingCurrency == "us"))
                {
                    sum *= 0.016;
                }
                else if ((currency == "us") & (getingCurrency == "ua"))
                {
                    sum *= 26;
                }
                else if ((currency == "us") & (getingCurrency == "ru"))
                {
                    sum *= 64;
                }
                else
                {
                    Console.WriteLine("Icorrect value");
                }
                            
            return sum;
        }
        static void Showresult(string currency, string getingCurrency, double sum)
        {
            Console.WriteLine($"Your sum: {FinanceOp(currency, getingCurrency, sum)}");
        }
    }
}
