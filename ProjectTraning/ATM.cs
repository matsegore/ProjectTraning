using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTraning
{
    class ATM
    {
        public  void Execute()
        {
            string strPinCode = GetPinCode();

            ValidatePIN(strPinCode);
        }

        private string GetPinCode()
        {
            Console.WriteLine("Enter PIN code");

            var strPinCode = Console.ReadLine();

            return strPinCode;
        }

        private void ValidatePIN(string strPinCode)
        {
            int pinCode = 0;

            if (Int32.TryParse(strPinCode, out pinCode) && strPinCode.Length == 4 || strPinCode.Length == 6 && pinCode > 0)

            {
                Console.WriteLine("Pin is correct");
            }

            else
            {
                Console.WriteLine("Incorrect PIN code. Enter 4-digit or 6-digit code!");
            }
        }
    }
}
