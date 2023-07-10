using System.Collections.Generic;
using System.Linq;

namespace Demo.SRP.EmployeeEvaluation.Kernel.Domain
{
    public class SkillManager
    {
        private readonly HashSet<EmployeeSkill> _skills = new();

        public void AddSkills(params EmployeeSkill[] skills)
        {
            foreach (var skill in skills)
            {
                _skills.Add(skill);
            }
        }

        public void RemoveSkill(EmployeeSkill skill)
        {
            _skills.Remove(skill);
        }

        public bool HasSkills(EmployeeSkill[] skills)
        {
            return skills.All(skill => _skills.Contains(skill));
        }

        public string DisplaySkills()
        {
            return _skills.Any()
                ? $"I am skilled in {string.Join(", ", _skills)}."
                : "No previous experience.";
        }
    }
}
