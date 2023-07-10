namespace Demo.SRP.EmployeeEvaluation.Kernel.Domain.Rules
{
    public sealed class SoftwareArchitectEvaluator : IEmployeeLevelEvaluationStrategy
    {
        public EmployeeJobLevel EvaluateEmployeeLevel(Employee employee)
        {
            return employee.MeetsExperienceAndSkillRequirements(10, EmployeeSkill.Communications,
                EmployeeSkill.MicrosoftCSharp, EmployeeSkill.MicrosoftAzureSecurity,
                EmployeeSkill.MicrosoftAzureAiCognitiveService, EmployeeSkill.MicrosoftSqlServer,
                EmployeeSkill.InspiringMotivation)
                ? EmployeeJobLevel.SoftwareArchitect
                : EmployeeJobLevel.Undefined;
        }
    }
}
