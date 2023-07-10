namespace Demo.SRP.EmployeeEvaluation.Kernel.Domain.Rules
{
    public sealed class JuniorSoftwareEngineerLevelOneEvaluator : IEmployeeLevelEvaluationStrategy
    {
        public EmployeeJobLevel EvaluateEmployeeLevel(Employee employee)
        {
            return employee.MeetsExperienceAndSkillRequirements(1, EmployeeSkill.Communications, EmployeeSkill.MicrosoftCSharp, EmployeeSkill.MicrosoftSqlServer)
                ? EmployeeJobLevel.JuniorSoftwareEngineerI
                : EmployeeJobLevel.Undefined;
        }
    }
}
