using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementApp
{
    internal class TeamLeader : Developer
    {
        private double bonusRate;

        public TeamLeader(string _empId, string _empName, int _baseSal, string _teamName, List<string> _programmingLanguages, int _expYear, double _bonusRate) :
            base(_empId, _empName, _baseSal, _teamName, _programmingLanguages, _expYear)
        {
            this.bonusRate = _bonusRate;
        }

        public double getBonusRate() { return bonusRate; }

        public override double getSalary()
        {
            double devSalary = base.getSalary();

            double bonusAmount = bonusRate * devSalary;

            return bonusAmount + devSalary;
        }

    }
}
