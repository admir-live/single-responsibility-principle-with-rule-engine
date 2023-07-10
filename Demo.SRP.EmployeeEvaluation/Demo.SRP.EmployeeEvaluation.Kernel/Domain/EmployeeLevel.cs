using Demo.SRP.EmployeeEvaluation.Kernel.Common;

namespace Demo.SRP.EmployeeEvaluation.Kernel.Domain
{
    public sealed class EmployeeJobLevel : Enumeration
    {
        private EmployeeJobLevel(int levelId, string levelName) : base(levelId, levelName)
        {
        }

        public static EmployeeJobLevel Undefined => new(0, "Not defined");
        public static EmployeeJobLevel JuniorSoftwareEngineerI => new(1, "Level 1 Software Engineer [Junior I]");
        public static EmployeeJobLevel JuniorSoftwareEngineerII => new(2, "Level 2 Software Engineer [Junior II]");
        public static EmployeeJobLevel SeniorSoftwareEngineerI => new(3, "Level 3 Software Engineer [Senior I]");
        public static EmployeeJobLevel TeamLeader => new(4, "Level 4 Software Engineer [Team Leader]");
        public static EmployeeJobLevel SoftwareArchitect => new(5, "Level 5 Software Engineer [Software Architect]");
        public static EmployeeJobLevel SolutionArchitect => new(6, "Level 6 Software Engineer [Solution Architect]");

        public static implicit operator string(EmployeeJobLevel jobLevel)
        {
            return jobLevel.ToString();
        }
    }
}
