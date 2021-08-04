using Demo.SRP.EmployeeEvaluation.Kernel.Domain;

namespace Demo.SRP.EmployeeEvaluation.Kernel.Services.Static
{
    public sealed class StaticEmployeeEvaluationService : IEmployeeEvaluationService
    {
        public EmployeeLevel Evaluate(Employee employee)
        {
            var level = EmployeeLevel.SoftwareEngineerL1;

            if (employee.YearsOfExperience >= 1 &&
                employee.Skills.Contains(item: EmployeeSkill.Communications) &&
                employee.Skills.Contains(item: EmployeeSkill.MicrosoftCSharp))
            {
                level = EmployeeLevel.SoftwareEngineerL2;
            }

            if (employee.YearsOfExperience >= 3 &&
                employee.Skills.Contains(item: EmployeeSkill.Communications) &&
                employee.Skills.Contains(item: EmployeeSkill.MicrosoftCSharp) &&
                employee.Skills.Contains(item: EmployeeSkill.MicrosoftSqlServer))
            {
                level = EmployeeLevel.SoftwareEngineerL3;
            }

            if (employee.YearsOfExperience >= 5 &&
                employee.Skills.Contains(item: EmployeeSkill.Communications) &&
                employee.Skills.Contains(item: EmployeeSkill.MicrosoftCSharp) &&
                employee.Skills.Contains(item: EmployeeSkill.InspiringMotivation) &&
                employee.Skills.Contains(item: EmployeeSkill.MicrosoftSqlServer))
            {
                level = EmployeeLevel.SoftwareEngineerL4;
            }

            if (employee.YearsOfExperience >= 7 &&
                employee.Skills.Contains(item: EmployeeSkill.Communications) &&
                employee.Skills.Contains(item: EmployeeSkill.MicrosoftCSharp) &&
                employee.Skills.Contains(item: EmployeeSkill.MicrosoftAzureAiCognitiveService) &&
                employee.Skills.Contains(item: EmployeeSkill.MicrosoftAzureSecurity) &&
                employee.Skills.Contains(item: EmployeeSkill.InspiringMotivation) &&
                employee.Skills.Contains(item: EmployeeSkill.MicrosoftSqlServer))
            {
                level = EmployeeLevel.SoftwareEngineerL5;
            }

            if (employee.YearsOfExperience >= 11 &&
                employee.Skills.Contains(item: EmployeeSkill.Communications) &&
                employee.Skills.Contains(item: EmployeeSkill.MicrosoftCSharp) &&
                employee.Skills.Contains(item: EmployeeSkill.MicrosoftAzureAiCognitiveService) &&
                employee.Skills.Contains(item: EmployeeSkill.MicrosoftAzureSecurity) &&
                employee.Skills.Contains(item: EmployeeSkill.MicrosoftAzureNetworking) &&
                employee.Skills.Contains(item: EmployeeSkill.InspiringMotivation) &&
                employee.Skills.Contains(item: EmployeeSkill.MicrosoftSqlServer))
            {
                level = EmployeeLevel.SoftwareEngineerL6;
            }

            return level;
        }
    }
}