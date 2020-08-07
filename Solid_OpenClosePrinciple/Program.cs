using System;
using System.Collections.Generic;

namespace Solid_OpenClosePrinciple
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<IApplicantModel> applicants = new List<IApplicantModel>
            {
                new PersonModel{FirstName="太郎", LastName="山田"},
                new ManagerModel{FirstName="一郎", LastName="鈴木"},
                new ExecutiveModel{FirstName="浩一", LastName="佐藤"},
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();

            foreach (var person in applicants)
            {
                employees.Add(person.AccountProcessor.Create(person));
            }

            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName} {emp.EmailAddress} IsManager: {emp.IsManager} IsExecutive: {emp.IsExecutive}");
            }

            Console.ReadLine();
        }
    }
}