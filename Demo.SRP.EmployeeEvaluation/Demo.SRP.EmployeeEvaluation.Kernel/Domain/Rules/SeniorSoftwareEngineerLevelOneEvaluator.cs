namespace Demo.SRP.EmployeeEvaluation.Kernel.Domain.Rules
{
    public sealed class SeniorSoftwareEngineerLevelOneEvaluator : IEmployeeLevelEvaluationStrategy
    {
        public EmployeeJobLevel EvaluateEmployeeLevel(Employee employee)
        {
            return employee.MeetsExperienceAndSkillRequirements(5, EmployeeSkill.Communications,
                EmployeeSkill.MicrosoftCSharp, EmployeeSkill.MicrosoftSqlServer, EmployeeSkill.Communications)
                ? EmployeeJobLevel.SeniorSoftwareEngineerI
                : EmployeeJobLevel.Undefined;
        }
    }
}
