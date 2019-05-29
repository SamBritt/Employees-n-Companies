// Date founded (DateTime)
// Company name (string)
// Employees (List<Employee>)
// The Company class should also have a 
// ListEmployees() method which outputs the name of each employee to the console
using System;
using System.Collections.Generic;

namespace classes{
    class Company{
        public Company(string companyName, DateTime foundingDate){
            this.name = companyName;
            this.foundingDate = foundingDate;
        }

        public DateTime foundingDate{get;}
        public string name{get;}
        public List<Employee> employeeList = new List<Employee>();

        public void hire(Employee employee){
            employeeList.Add(employee);
        }

        public void ListEmployeeDetails(){
            foreach(Employee employee in employeeList){
                Console.WriteLine($"{employee.firstName}" + " " + $"{employee.lastName}");
            }
        }

    }
}