using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Company toyStore = new Company("Toys R' Us", DateTime.Now);
            Console.WriteLine("Hello World!");

            Employee emp1 = new Employee("Samuel", "Britt");
            emp1.Title = "Shift Lead";
            Employee emp2 = new Employee("William", "Goodman");
            emp2.Title = "Owner";
            Employee emp3 = new Employee("Marquise", "Johnson");
            emp3.Title = "Vomit Cleanup";

            toyStore.hire(emp1);
            toyStore.hire(emp2);
            toyStore.hire(emp3);

            foreach(Employee employee in toyStore.employeeList){
                Console.WriteLine($"{employee.firstName + " " + employee.lastName} works for {toyStore.name} as {employee.Title} since {employee.getStartDate()}");
            }

            toyStore.ListEmployeeDetails();
        }
    }
}
