using System.Collections.Generic;
using Demo.SRP.EmployeeEvaluation.Kernel.Domain;
using Demo.SRP.EmployeeEvaluation.Kernel.Extensions;
using Demo.SRP.EmployeeEvaluation.Kernel.Services;
using Demo.SRP.EmployeeEvaluation.Kernel.Services.Static;

namespace Demo.SRP.EmployeeEvaluation.Main
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var employees = new[]
            {
                CreateEmployee("John", "Doe", 32,
                    EmployeeSkill.Communications,
                    EmployeeSkill.MicrosoftCSharp,
                    EmployeeSkill.MicrosoftSqlServer,
                    EmployeeSkill.MicrosoftAzureNetworking,
                    EmployeeSkill.MicrosoftAzureAiCognitiveService,
                    EmployeeSkill.InspiringMotivation),
                CreateEmployee("Sarah", "Smith", 5,
                    EmployeeSkill.Communications,
                    EmployeeSkill.MicrosoftCSharp,
                    EmployeeSkill.Communications,
                    EmployeeSkill.MicrosoftSqlServer),
                CreateEmployee("Michael", "Brown", 35,
                    EmployeeSkill.Communications,
                    EmployeeSkill.MicrosoftCSharp,
                    EmployeeSkill.MicrosoftAzureSecurity,
                    EmployeeSkill.MicrosoftAzureAiCognitiveService,
                    EmployeeSkill.MicrosoftSqlServer,
                    EmployeeSkill.InspiringMotivation)
            };

            EvaluateAndDisplayEmployeeLevels(employees);
        }

        private static Employee CreateEmployee(string firstName, string lastName, int age,
            params EmployeeSkill[] skills)
        {
            var employee = new Employee(firstName, lastName, age);
            employee.SkillManager.AddSkills(skills);
            return employee;
        }

        private static void EvaluateAndDisplayEmployeeLevels(IEnumerable<Employee> employees)
        {
            IEmployeeEvaluationService employeeEvaluationService = new StaticEmployeeEvaluationService();

            foreach (var employee in employees)
            {
                var level = employeeEvaluationService.Evaluate(employee);
                level.Display();
            }
        }
    }
}
