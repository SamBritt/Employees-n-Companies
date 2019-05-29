// First name (string)
// Last name (string)
// Title (string)
// Start date (DateTime)
using System;

namespace classes{
    class Employee{
        public Employee(string firstName, string lastName){
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public string firstName {get;set;}
        public string lastName {get;set;}
        public string Title {get;set;}
        private DateTime startDate = DateTime.Now;

        public DateTime getStartDate(){
            return startDate;
        }
    }
}