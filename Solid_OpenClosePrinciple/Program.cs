using System;
using System.Collections.Generic;

namespace Solid_OpenClosePrinciple
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<PersonModel> applicants = new List<PersonModel>
            {
                new PersonModel{FirstName="太郎", LastName="山田"},
                new PersonModel{FirstName="一郎", LastName="鈴木"},
                new PersonModel{FirstName="浩一", LastName="佐藤"},
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();
            Accounts accountProcessor = new Accounts();

            foreach (var person in applicants)
            {
                employees.Add(accountProcessor.Create(person));
            }

            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName} {emp.EmailAddress}");
            }

            Console.ReadLine();
        }
    }
}