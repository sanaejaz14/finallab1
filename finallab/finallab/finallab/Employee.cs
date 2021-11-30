using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace finallab
{
    public class Employee : HourlyEmployee
    {
        private int basepay;
        private int hourlyPayRate;
        private int ngh;

        public int Base_Hours { get; private set; }

        public int EmployeeId
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public String EmployeeName
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public int EmployeeType
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public int Hours
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public void Salary()
        {
            throw new System.NotImplementedException();
           
        }
    }
}