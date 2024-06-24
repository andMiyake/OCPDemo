﻿using Problem.OCPLibrary;

namespace Problem.ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<PersonModel> applicants = new List<PersonModel>
            {
                new PersonModel {FirstName = "Tim", LastName = "Corey" },
                new PersonModel {FirstName = "Sue", LastName = "Storm", TypeOfEmployee = EmployeeType.Manager},
                new PersonModel {FirstName = "Nancy", LastName = "Roman", TypeOfEmployee = EmployeeType.Executive}
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();
            Accounts accountProcessor = new Accounts();

            foreach (var person in applicants)
            {
                employees.Add(accountProcessor.Create(person));
            }

            foreach (var emp in employees)
            {
                Console.WriteLine($"{ emp.FirstName } { emp.LastName }: { emp.EmailAddress } IsManager: { emp.IsManager } IsExecutive: { emp.IsExecutive }");
            }

            Console.ReadLine();
        }
    }
}