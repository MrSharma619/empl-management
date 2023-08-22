using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementApp
{
    internal class CompanyManagement
    {
        public List<Employee?>? empList;

        public CompanyManagement(string path, string path1)
        {
            getEmployeeFromFile(path, path1);
        }

        public List<string> getPLforEmp(string path1, string empId)
        {
            List<string> programmingLanguages = new List<string>();

            if (File.Exists(path1))
            {
                // Read a text file line by line.
                string[] lines = File.ReadAllLines(path1);
                foreach (string line in lines)
                {
                    var values = line.Split(',');
                    if(values[0] == empId)
                    {
                        for(int i = 1; i < values.Length; i++)
                        {
                            programmingLanguages.Add(values[i]);
                        }
                    }
                }
            }

            return programmingLanguages;
        }

        public List<Employee?> getEmployeeFromFile(string path, string path1)
        {
            empList = new List<Employee?>();

            if (File.Exists(path))
            {
                // Read a text file line by line.
                string[] lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    Employee? e = null;
                    var values = line.Split(',');

                    List<string> programmingLanguages = getPLforEmp(path1, values[1]);

                    if (values.Length == 6 && (values[4] == "AT" || values[4] == "MT"))
                    {
                        e = new Tester(values[1], values[2], Convert.ToInt32(values[5]), Convert.ToDouble(values[3]), values[4]);
                    }
                    else if (values.Length == 6)
                    {
                        e = new Developer(values[1], values[2], Convert.ToInt32(values[5]), values[3], programmingLanguages, Convert.ToInt32(values[4]));
                    }
                    else if (values.Length == 8 && values[5] == "L")
                    {
                        e = new TeamLeader(values[1], values[2], Convert.ToInt32(values[7]), values[3], programmingLanguages, Convert.ToInt32(values[4]), Convert.ToDouble(values[6]));
                    }

                    empList.Add(e);
                }
            }

            return empList;
        }

        public List<Developer> getDevelopersByProgrammingLanguages(string pl)
        {
            List<Developer> devList = new List<Developer>();

            foreach (var employee in empList)
            {
                if (employee is Developer developer && developer.getProgrammingLanguages().Contains(pl))
                {
                    devList.Add(developer);
                }
            }

            return devList;
        }

        public List<Tester> getTestersHaveSalaryGreaterThan(double value)
        {
            List<Tester> testerList = new List<Tester>();

            foreach (var employee in empList)
            {
                if (employee is Tester tester && (tester.getSalary() > value))
                {
                    testerList.Add(tester);
                }
            }

            return testerList;
        }

        public Employee getEmployeeWithHigestSalary()
        {
            var maxSalary = empList.Max(r => r.getSalary());
            return empList.Where(r => r.getSalary() == maxSalary).First();
        }

        public TeamLeader getLeaderWithMostEmployees()
        {
            List<TeamLeader> leaderList = new List<TeamLeader>();

            var teamNameCounts = empList.OfType<Developer>()
            .GroupBy(r => r.getTeamName())
            .Select(group => new
            {
                TeamName = group.Key,
                Count = group.Count()
            })
            .ToList();

            var mostCommonTeam = teamNameCounts
                .OrderByDescending(item => item.Count)
                .FirstOrDefault();

            string? teamName = mostCommonTeam?.TeamName;

            return empList.OfType<TeamLeader>().First(r => r.getTeamName() == teamName);
        }

        public List<Employee?>? sorted()
        {
            List<Employee?>? sortedEmpList = empList;

            return sortedEmpList.OrderByDescending(r => r.getSalary())
                .ThenBy(r => r.getEmpName())
                .ToList();
        }

        public void printEmpList()
        {
            empList.ForEach(p => Console.WriteLine(p.toString()));
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
