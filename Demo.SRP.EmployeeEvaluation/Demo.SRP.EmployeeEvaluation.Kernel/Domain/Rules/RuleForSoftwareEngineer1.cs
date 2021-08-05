namespace Demo.SRP.EmployeeEvaluation.Kernel.Domain.Rules
{
    public sealed class RuleForSoftwareEngineer1 : BaseEmployeeEvaluationRule
    {
        public RuleForSoftwareEngineer1() : base(level: EmployeeLevel.SoftwareEngineerL1)
        {
        }
    }
}