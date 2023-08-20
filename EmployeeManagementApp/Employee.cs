using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementApp
{
    abstract class Employee
    {
        private string empId;
        
        private string empName;

        private int baseSal;

        public Employee(string _empId, string _empName, int _baseSal)
        {
            this.empId = _empId;
            this.empName = _empName;
            this.baseSal = _baseSal;
        }

        public string getEmpId() { return empId; }

        public string getEmpName() {  return empName; }

        public int getBaseSal() { return baseSal; }

        public abstract double getSalary();

        public virtual string toString()
        {
            return empId + "_" + empName + "_" + baseSal.ToString();
        }

    }
}
