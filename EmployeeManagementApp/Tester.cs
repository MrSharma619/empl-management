using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementApp
{
    internal class Tester : Employee
    {
        private double bonusRate;

        private string type;

        public Tester (string _empId, string _empName, int _baseSal, double _bonusRate, string _type) : 
            base(_empId, _empName, _baseSal) 
        {
            this.bonusRate = _bonusRate;
            this.type = _type;
        }

        public double getBonusRate() { return bonusRate; }

        public string getType() { return type; }

        public override double getSalary()
        {
            double bonusAmount = bonusRate * Convert.ToDouble(getBaseSal());

            return bonusAmount + Convert.ToDouble(getBaseSal());
        }

    }
}
