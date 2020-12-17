using System;
using System.Collections.Generic;
using OCPLibrary;

namespace OCPDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var applicants = new List<IApplicantModel>
            {
                new PersonModel { FirstName = "Tim", LastName = "Corey" },
                new ManagerModel { FirstName = "Sue", LastName = "Storm"},
                new ExecutiveModel { FirstName = "Nancy", LastName = "Roman"}
            };

            var employees = new List<EmployeeModel>();

            foreach (var person in applicants)
            {
                employees.Add(person.AccountProcessor.Create(person));
            }

            foreach (var emp in employees)
            {
                Console.WriteLine($"{ emp.FirstName } { emp.LastName }: { emp.EmailAddress }  IsManager: { emp.IsManager }"
                                    + $"  IsExecutive: { emp.IsExecutive }");
            }
        }
    }
}
