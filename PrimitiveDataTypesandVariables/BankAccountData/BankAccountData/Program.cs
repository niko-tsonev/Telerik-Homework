using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "John";
            string middleName = "Fekin";
            string lastName = "Doe";
            decimal accountBalance = 2234.54m;
            string bankName = "Alpha Bank";
            string iban = "BG54YEBF023948574875";
            long firstCreditCardNumber = 9872634119827346L;
            long secondCreditCardNumber = 0239485720934857L;
            long thirdCreditCardNumber = 2390845728374905L;

            Console.WriteLine("Account holder: {0} {1} {2}", firstName, middleName, lastName);
            Console.WriteLine("Account balance: {0} BGN", accountBalance);
            Console.WriteLine("Bank: {0}", bankName); ;
            Console.WriteLine("IBAN: {0}", iban);
            Console.WriteLine("Credit cards numbers: 1. {0}; 2. {1}; 3. {2}.", firstCreditCardNumber, secondCreditCardNumber, thirdCreditCardNumber);
        }
    }
}
