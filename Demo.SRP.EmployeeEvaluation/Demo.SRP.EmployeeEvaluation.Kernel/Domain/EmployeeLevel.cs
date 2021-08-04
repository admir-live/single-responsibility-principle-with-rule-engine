using Demo.SRP.EmployeeEvaluation.Kernel.Mutual;

namespace Demo.SRP.EmployeeEvaluation.Kernel.Domain
{
    public sealed class EmployeeLevel : Enumeration
    {
        private EmployeeLevel(int id, string name) : base(id: id, name: name)
        {
        }

        public static EmployeeLevel None => new EmployeeLevel(id: 0, name: "Not defined");
        public static EmployeeLevel SoftwareEngineerL1 => new EmployeeLevel(id: 1, name: "Level 1 Software Engineer [Junior I]");
        public static EmployeeLevel SoftwareEngineerL2 => new EmployeeLevel(id: 2, name: "Level 2 Software Engineer [Junior II]");
        public static EmployeeLevel SoftwareEngineerL3 => new EmployeeLevel(id: 3, name: "Level 3 Software Engineer [Senior I]");
        public static EmployeeLevel SoftwareEngineerL4 => new EmployeeLevel(id: 4, name: "Level 4 Software Engineer [Team Leader]");
        public static EmployeeLevel SoftwareEngineerL5 => new EmployeeLevel(id: 5, name: "Level 5 Software Engineer [Software Architect]");
        public static EmployeeLevel SoftwareEngineerL6 => new EmployeeLevel(id: 6, name: "Level 6 Software Engineer [Solution Architect]");

        public static implicit operator string(EmployeeLevel level)
        {
            return level.ToString();
        }
    }
}