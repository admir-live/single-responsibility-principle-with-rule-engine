using System.Collections.Generic;
using System.Linq;
using System.Text;
using Demo.SRP.EmployeeEvaluation.Kernel.Mutual;

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
            Skills = new List<EmployeeSkill>();
        }

        public string FirstName { get; }
        public string LastName { get; }
        public int YearsOfExperience { get; }
        public IList<EmployeeSkill> Skills { get; }

        public void AddSkills(params EmployeeSkill[] skills)
        {
            foreach (var skill in skills)
            {
                if (Skills.Contains(item: skill) == false)
                {
                    Skills.Add(item: skill);
                }
            }
        }

        public override string ToString()
        {
            var message = new StringBuilder(value: $"Hey! I am {FirstName} {LastName}. ");
            message.Append(value: Skills.Any() ? $"I have a total of {YearsOfExperience} years experience with {string.Join(separator: ", ", values: Skills)}." : "I don't have any previous experience.");
            message.AppendLine();
            return message.ToString();
        }
    }
}