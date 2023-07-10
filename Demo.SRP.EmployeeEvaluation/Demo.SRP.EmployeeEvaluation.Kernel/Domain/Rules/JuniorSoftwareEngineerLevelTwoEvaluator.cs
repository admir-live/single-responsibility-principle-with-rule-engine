namespace Demo.SRP.EmployeeEvaluation.Kernel.Domain.Rules
{
    public sealed class JuniorSoftwareEngineerLevelTwoEvaluator : IEmployeeLevelEvaluationStrategy
    {
        public EmployeeJobLevel EvaluateEmployeeLevel(Employee employee)
        {
            return employee.MeetsExperienceAndSkillRequirements(3, EmployeeSkill.Communications,
                EmployeeSkill.MicrosoftCSharp, EmployeeSkill.MicrosoftSqlServer, EmployeeSkill.MicrosoftAzureNetworking)
                ? EmployeeJobLevel.JuniorSoftwareEngineerII
                : EmployeeJobLevel.Undefined;
        }
    }
}
