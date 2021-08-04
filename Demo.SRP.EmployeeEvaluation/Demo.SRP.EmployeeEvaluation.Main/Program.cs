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
            var samed = new Employee(firstName: "Samed", lastName: "Skulj");

            var haris = new Employee(firstName: "Haris", lastName: "Mlaco", yearsOfExperience: 1);
            haris.AddSkills(
                EmployeeSkill.Communications,
                EmployeeSkill.MicrosoftCSharp);

            var faris = new Employee(firstName: "Faris", lastName: "Haskovic", yearsOfExperience: 3);
            faris.AddSkills(
                EmployeeSkill.Communications,
                EmployeeSkill.MicrosoftCSharp,
                EmployeeSkill.MicrosoftSqlServer);

            var mirza = new Employee(firstName: "Mirza", lastName: "Hodzic", yearsOfExperience: 6);
            mirza.AddSkills(
                EmployeeSkill.Communications,
                EmployeeSkill.MicrosoftCSharp,
                EmployeeSkill.MicrosoftSqlServer,
                EmployeeSkill.InspiringMotivation);


            var admir = new Employee(firstName: "Admir", lastName: "Mujkic", yearsOfExperience: 11);
            admir.AddSkills(
                EmployeeSkill.Communications,
                EmployeeSkill.MicrosoftCSharp,
                EmployeeSkill.MicrosoftAzureSecurity,
                EmployeeSkill.MicrosoftAzureAiCognitiveService,
                EmployeeSkill.MicrosoftSqlServer,
                EmployeeSkill.InspiringMotivation);

            var fehim = new Employee(firstName: "Fehim", lastName: "Dervišbegović", yearsOfExperience: 23);
            fehim.AddSkills(
                EmployeeSkill.Communications,
                EmployeeSkill.MicrosoftCSharp,
                EmployeeSkill.MicrosoftAzureSecurity,
                EmployeeSkill.MicrosoftAzureAiCognitiveService,
                EmployeeSkill.MicrosoftSqlServer,
                EmployeeSkill.MicrosoftAzureNetworking,
                EmployeeSkill.InspiringMotivation);

            samed.Display();

            IEmployeeEvaluationService employeeEvaluationService = new StaticEmployeeEvaluationService();
            employeeEvaluationService.Evaluate(employee: admir).Display();
        }
    }
}