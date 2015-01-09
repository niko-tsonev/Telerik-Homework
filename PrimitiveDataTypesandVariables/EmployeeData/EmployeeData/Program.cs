using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "John";
            string lastName = "Doe";
            byte age = 35;
            char gender = 'm';
            long personalID = 9876234574;
            int uniqueEmployeeNumber = 02193847;

            Console.WriteLine("First name: {0}", firstName);
            Console.WriteLine("Last name: {0}", lastName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Personal ID number: {0}", personalID);
            Console.WriteLine("Unique employee number: {0}", uniqueEmployeeNumber);
        }
    }
}
