using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02G03.Encapsulation
{
    internal struct Employee
    {
        #region Attributes
        public int EmpId;
        private string Name;
        //private decimal Salary;

        #endregion

        // Encapsulation
        // Separate Data defination[Attributes, fields] from its use [Getter Setter, Property]
        #region Applying Encapsulation using [Getter Setter Approach]
        public void SetName(string name)
        {
            Name = name.Length > 10 ? name.Substring(0, 10) : name;
        }

        public string GetName()
        {
            return Name;
        }
        #endregion

        #region Applying Encapsulation using [Property Approach]
        // 1. Full Property
        private decimal salary;

        public decimal Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value < 7000 ? 7000 : value;
            }
        } 

        // 2. Automatic Property
        public int Age
        {
            get;
            set;
        }

        private string ssn;

        public string SSN
        {
            // Read Only Property
            get { return ssn; }
        }


        #endregion

        public Employee(int id, string name, decimal salary, int age, string ssn)
        {
            EmpId = id;
            Name = name;
            this.salary = salary;
            Age = age;
            this.ssn = ssn;
        }

        public override string ToString()
        {
            return $"Id: {EmpId}, Name: {Name}, Salary: {salary:c}, Age: {Age}";
        }


    }
}
