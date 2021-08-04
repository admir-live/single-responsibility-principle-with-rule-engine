namespace Demo.SRP.EmployeeEvaluation.Kernel.Domain.Rules
{
    public sealed class RuleForSoftwareEngineer6 : BaseEmployeeEvaluationRule
    {
        public RuleForSoftwareEngineer6() :
            base(level: EmployeeLevel.SoftwareEngineerL6,
                EmployeeSkill.Communications,
                EmployeeSkill.MicrosoftCSharp,
                EmployeeSkill.MicrosoftAzureSecurity,
                EmployeeSkill.MicrosoftAzureAiCognitiveService,
                EmployeeSkill.MicrosoftSqlServer,
                EmployeeSkill.MicrosoftAzureNetworking,
                EmployeeSkill.InspiringMotivation)
        {
        }
    }
}