using Demo.SRP.EmployeeEvaluation.Kernel.Common;

namespace Demo.SRP.EmployeeEvaluation.Kernel.Domain
{
    public sealed class EmployeeSkill : Enumeration
    {
        private EmployeeSkill(int id, string name) : base(id, name)
        {
        }

        public static EmployeeSkill MicrosoftCSharp => new(1, "Microsoft C#");
        public static EmployeeSkill MicrosoftSqlServer => new(2, "Microsoft SQL Server");
        public static EmployeeSkill MicrosoftAzureNetworking => new(3, "Microsoft Azure Networking");
        public static EmployeeSkill MicrosoftAzureAiCognitiveService => new(4, "Microsoft Azure Ai Cognitive Services");
        public static EmployeeSkill MicrosoftAzureSecurity => new(5, "Microsoft Azure Security");
        public static EmployeeSkill InspiringMotivation => new(6, "Inspiring motivation");
        public static EmployeeSkill Communications => new(7, "Communications");

        public static implicit operator string(EmployeeSkill level)
        {
            return level.ToString();
        }
    }
}
