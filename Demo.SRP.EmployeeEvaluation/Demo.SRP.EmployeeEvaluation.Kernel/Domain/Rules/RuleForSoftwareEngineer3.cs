namespace Demo.SRP.EmployeeEvaluation.Kernel.Domain.Rules
{
    public sealed class RuleForSoftwareEngineer3 : BaseEmployeeEvaluationRule
    {
        public RuleForSoftwareEngineer3() :
            base(level: EmployeeLevel.SoftwareEngineerL3,
                EmployeeSkill.Communications,
                EmployeeSkill.MicrosoftCSharp,
                EmployeeSkill.MicrosoftSqlServer)
        {
        }
    }
}