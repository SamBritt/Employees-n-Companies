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
            Employee emp2 = new Employee("William", "Goodman");
            Employee emp3 = new Employee("Marquise", "Johnson");

            toyStore.hire(emp1);
            toyStore.hire(emp2);
            toyStore.hire(emp3);

            toyStore.ListEmployeeDetails();
        }
    }
}
