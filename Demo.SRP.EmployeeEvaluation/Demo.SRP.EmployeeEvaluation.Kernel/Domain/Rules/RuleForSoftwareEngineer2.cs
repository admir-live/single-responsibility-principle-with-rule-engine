namespace Demo.SRP.EmployeeEvaluation.Kernel.Domain.Rules
{
    public sealed class RuleForSoftwareEngineer2 : BaseEmployeeEvaluationRule
    {
        public RuleForSoftwareEngineer2() :
            base(level: EmployeeLevel.SoftwareEngineerL2,
                EmployeeSkill.Communications,
                EmployeeSkill.MicrosoftCSharp)
        {
        }
    }
}