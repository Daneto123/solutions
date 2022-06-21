using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter montly income");
            string input = Console.ReadLine();
            int salary = Int32.Parse(input);

            Tax tax1 = new Tax(salary);

            Console.WriteLine($"{tax1.Salary} IDR");
            

        }
    }
}
