using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementApp
{
    internal class CompanyManagement
    {
        public List<Employee> empList;

        public CompanyManagement(string path, string path1)
        {
            //TODO
        }

        public List<Employee> getEmployeeFromFile(string path, string path1)
        {
            //TODO
            return null;
        }

        public List<Developer> getDevelopersByProgrammingLanguages(string pl)
        {
            //TODO
            return null;
        }

        public List<Tester> getTestersHaveSalaryGreaterThan(double value)
        {
            //TODO
            return null;
        }

        public Employee getEmployeeWithHigestSalary()
        {
            //TODO
            return null;
        }

        public TeamLeader getLeaderWithMostEmployees()
        {
            //TODO
            return null;
        }

        public List<Employee> sorted()
        {
            //TODO
            return null;
        }

        public void printEmpList()
        {
            //TODO
        }

        public Boolean writeFile(string path, List<Employee> list)
        {
            //TODO
            return false;
        }

        public Boolean writeFile(string path, Employee obj)
        {
            //TODO
            return false;
        }

    }
}
