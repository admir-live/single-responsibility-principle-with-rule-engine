namespace Demo.SRP.EmployeeEvaluation.Kernel.Domain.Rules
{
    public sealed class SoftwareEngineerTeamLeaderEvaluator : IEmployeeLevelEvaluationStrategy
    {
        public EmployeeJobLevel EvaluateEmployeeLevel(Employee employee)
        {
            return employee.MeetsExperienceAndSkillRequirements(10, EmployeeSkill.Communications,
                EmployeeSkill.MicrosoftCSharp, EmployeeSkill.MicrosoftSqlServer, EmployeeSkill.InspiringMotivation)
                ? EmployeeJobLevel.TeamLeader
                : EmployeeJobLevel.Undefined;
        }
    }
}
