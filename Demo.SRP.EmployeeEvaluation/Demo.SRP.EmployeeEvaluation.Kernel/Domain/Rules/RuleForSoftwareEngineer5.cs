namespace Demo.SRP.EmployeeEvaluation.Kernel.Domain.Rules
{
    public sealed class RuleForSoftwareEngineer5 : BaseEmployeeEvaluationRule
    {
        public RuleForSoftwareEngineer5() :
            base(level: EmployeeLevel.SoftwareEngineerL5,
                EmployeeSkill.Communications,
                EmployeeSkill.MicrosoftCSharp,
                EmployeeSkill.MicrosoftAzureSecurity,
                EmployeeSkill.MicrosoftAzureAiCognitiveService,
                EmployeeSkill.MicrosoftSqlServer,
                EmployeeSkill.InspiringMotivation)
        {
        }
    }
}