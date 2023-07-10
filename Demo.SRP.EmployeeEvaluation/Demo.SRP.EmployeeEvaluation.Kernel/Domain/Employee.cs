using Demo.SRP.EmployeeEvaluation.Kernel.Common;

namespace Demo.SRP.EmployeeEvaluation.Kernel.Domain
{
    public sealed class Employee : BaseEntity<EmployeeId>
    {
        public Employee(string firstName, string lastName, int yearsOfExperience = 0)
        {
            Id = EmployeeId.NextId;
            FirstName = firstName;
            LastName = lastName;
            YearsOfExperience = yearsOfExperience;
            SkillManager = new SkillManager();
        }

        public string FirstName { get; }
        public string LastName { get; }
        public int YearsOfExperience { get; }
        public SkillManager SkillManager { get; }

        public bool MeetsExperienceAndSkillRequirements(int yearsOfExperience, params EmployeeSkill[] skills)
        {
            return YearsOfExperience >= yearsOfExperience && SkillManager.HasSkills(skills);
        }

        public override string ToString()
        {
            var skillsText = SkillManager.DisplaySkills();
            return
                $"Hey! I am {FirstName} {LastName}. I have a total of {YearsOfExperience} years experience. {skillsText}\n";
        }
    }
}
