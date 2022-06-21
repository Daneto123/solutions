using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    // to add more taxes to the system you should create new method to calculate it
    class Tax
    {
        private int salary;

        public Tax(int salary)
        {
            Salary = salary;
        }

        public int Salary
        {
            get 
            {
                if (salary <= 1000)
                {
                    return salary;
                }
                else
                {
                    // here you sould call the method
                    return salary - (tax() + social());
                }
            }
            set { salary = value; }
        }


        public int tax()
        {
            int tax = ((salary - 1000) * 10) / 100;

            return tax;
        }

        public int social()
        {
            int social = 0;
            if (salary < 3000)
            {
                social = ((salary - 1000) * 15) / 100;
            }
            else
            {
                social = (2000 * 15) / 100;
            }

            return social;
        }


    }
}
