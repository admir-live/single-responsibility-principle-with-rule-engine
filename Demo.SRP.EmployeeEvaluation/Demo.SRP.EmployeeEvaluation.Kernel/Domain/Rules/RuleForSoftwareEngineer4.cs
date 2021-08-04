namespace Demo.SRP.EmployeeEvaluation.Kernel.Domain.Rules
{
    public sealed class RuleForSoftwareEngineer4 : BaseEmployeeEvaluationRule
    {
        public RuleForSoftwareEngineer4() :
            base(level: EmployeeLevel.SoftwareEngineerL4,
                EmployeeSkill.Communications,
                EmployeeSkill.MicrosoftCSharp,
                EmployeeSkill.MicrosoftSqlServer,
                EmployeeSkill.InspiringMotivation)
        {
        }
    }
}