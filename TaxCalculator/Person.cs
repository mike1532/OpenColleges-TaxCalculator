/*
 * Open Colleges - Module 8 Part B Assessment - Tax Calculator
 * Author - Mike Ormond
 * 
 * The following code can be used as a learning tool. Please do not submit as your own work.
 * 
 * ©2018
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator
{
    //create Person class
    class Person
    {
        private string firstName;
        private string surname;
        private string gender;

        //get and set
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }
        
        //Person constructor
        public Person createPerson(Person person, string firstname, string surname, string gender)
        {
            person.FirstName = firstname;
            person.Surname = surname;
            person.Gender = gender;
            return person;
        }
    }

    //create Employee class which extends Person class
    class Employee : Person
    {
        private string employeeID;
        private string department;
        private string email;
        private string hourlyRate;
        public const int HRS_WORK_WEEK = 40;

        //get and set
        public string EmployeeID
        {
            get
            {
                return employeeID;
            }
            set
            {
                employeeID = value;
            }
        }
        public string Department
        {
            get
            {
                return department;
            }
            set
            {
                department = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public string HourlyRate
        {
            get
            {
                return hourlyRate;
            }
            set
            {
                hourlyRate = value;
            }
        }

        //Employee constructor
        public Employee CreateEmployee(Employee newEmployee, string employeeID, string firstname, string surname, string gender, string department, string email, string hourlyRate)
        {
            newEmployee.EmployeeID = employeeID;
            newEmployee.FirstName = firstname;
            newEmployee.Surname = surname;
            newEmployee.Gender = gender;
            newEmployee.Department = department;
            newEmployee.Email = email;
            newEmployee.HourlyRate = hourlyRate;
            return newEmployee;
        }        
    }

    //create Contractor class which extend from Employee class
    class Contractor : Employee
    {
        private string hoursWorked;
        public const double TAX_RATE = 0.2;

        //get and set
        public string HoursWorked
        {
            get
            {
                return hoursWorked;
            }
            set
            {
                hoursWorked = value;
            }
        }

        //Contractor constructor
        public Contractor CreateContractor(Contractor contractor, string employeeID, string firstname, string surname, string gender, string department, string email, string hourlyRate, string hoursWorked)
        {
            contractor.EmployeeID = employeeID;
            contractor.FirstName = firstname;
            contractor.Surname = surname;
            contractor.Gender = gender;
            contractor.Department = department;
            contractor.Email = email;
            contractor.HourlyRate = hourlyRate;
            contractor.hoursWorked = hoursWorked;
            return contractor;
        }  
    }    
}
