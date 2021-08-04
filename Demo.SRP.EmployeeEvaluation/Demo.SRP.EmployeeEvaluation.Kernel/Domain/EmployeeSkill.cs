using Demo.SRP.EmployeeEvaluation.Kernel.Mutual;

namespace Demo.SRP.EmployeeEvaluation.Kernel.Domain
{
    public sealed class EmployeeSkill : Enumeration
    {
        private EmployeeSkill(int id, string name) : base(id: id, name: name)
        {
        }

        public static EmployeeSkill MicrosoftCSharp => new EmployeeSkill(id: 1, name: "Microsoft C#");
        public static EmployeeSkill MicrosoftSqlServer => new EmployeeSkill(id: 2, name: "Microsoft SQL Server");
        public static EmployeeSkill MicrosoftAzureNetworking => new EmployeeSkill(id: 3, name: "Microsoft Azure Networking");
        public static EmployeeSkill MicrosoftAzureAiCognitiveService => new EmployeeSkill(id: 4, name: "Microsoft Azure Ai Cognitive Services");
        public static EmployeeSkill MicrosoftAzureSecurity => new EmployeeSkill(id: 5, name: "Microsoft Azure Security");
        public static EmployeeSkill InspiringMotivation => new EmployeeSkill(id: 6, name: "Inspiring motivation");
        public static EmployeeSkill Communications => new EmployeeSkill(id: 7, name: "Communications");

        public static implicit operator string(EmployeeSkill level)
        {
            return level.ToString();
        }
    }
}