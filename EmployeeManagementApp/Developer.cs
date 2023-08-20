using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementApp
{
    internal class Developer : Employee
    {
        private string teamName;

        private List<string> programmingLanguages;

        private int expYear;

        public Developer(string _empId, string _empName, int _baseSal, string _teamName, List<string> _programmingLanguages, int _expYear) :
            base(_empId, _empName, _baseSal)
        {
            this.teamName = _teamName;
            this.programmingLanguages = _programmingLanguages;
            this.expYear = _expYear;
        }

        public string getTeamName() { return teamName; }

        public List<string> getProgrammingLanguages() {  return programmingLanguages; }

        public int getExpYear() {  return expYear; }

        public override double getSalary()
        {
            double bonusAmount = 0;

            if (expYear >= 5)
            {
                bonusAmount = (double)(expYear * 2_000_000);
            }
            else if(expYear < 5 && expYear >= 3) 
            {
                bonusAmount = (double)(expYear * 1_000_000);
            }

            return bonusAmount + Convert.ToDouble(getBaseSal());
        }

        public override string toString()
        {
            return getEmpId() + "_" + getEmpName() + "_" + getBaseSal().ToString() + "_"
                + teamName + "_[" + string.Join(", ", programmingLanguages) + "]_" + expYear.ToString();
        }

    }
}
