using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee
            {
                firstName = "Joe",
                lastName = "Smith",
                id = 1
            });
            employees.Add(new Employee
            {
                firstName = "Joe",
                lastName = "Taylor",
                id = 2
            });
            employees.Add(new Employee
            {
                firstName = "Malex",
                lastName = "Smith",
                id = 3
            });
            employees.Add(new Employee
            {
                firstName = "Shed",
                lastName = "Long",
                id = 4
            });
            employees.Add(new Employee
            {
                firstName = "Kyle",
                lastName = "Seager",
                id = 5
            });
            employees.Add(new Employee
            {
                firstName = "Kyle",
                lastName = "Lewis",
                id = 6
            });
            employees.Add(new Employee
            {
                firstName = "Tim",
                lastName = "Lopes",
                id = 7
            });
            employees.Add(new Employee
            {
                firstName = "Evan",
                lastName = "White",
                id = 8
            });
            employees.Add(new Employee
            {
                firstName = "Austin",
                lastName = "Nola",
                id = 9
            });
            employees.Add(new Employee
            {
                firstName = "JP",
                lastName = "Crawford",
                id = 10
            });

            List<Employee> employeesNamedJoe = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.firstName == "Joe")
                {
                    employeesNamedJoe.Add(employee);
                }
            }

            List<Employee> employeesLambda = employees.Where(x => x.firstName == "Joe").ToList();

            List<Employee> employeesById = employees.Where(x => x.id > 5).ToList();

        }
    }
}
