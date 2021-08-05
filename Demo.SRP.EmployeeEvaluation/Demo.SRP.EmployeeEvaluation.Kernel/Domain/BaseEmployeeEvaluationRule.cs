using System.Collections.Generic;
using System.Linq;

namespace Demo.SRP.EmployeeEvaluation.Kernel.Domain
{
    public abstract class BaseEmployeeEvaluationRule : IEmployeeEvaluationRule
    {
        protected BaseEmployeeEvaluationRule(EmployeeLevel level, params EmployeeSkill[] requiredSkills)
        {
            RequiredSkills = requiredSkills ?? new EmployeeSkill[0];
            Level = level;
        }

        protected ICollection<EmployeeSkill> RequiredSkills { get; }
        protected EmployeeLevel Level { get; }

        public virtual EmployeeLevel Evaluate(Employee parameter)
        {
            var success = RequiredSkills.OrderBy(keySelector: skill => skill.Id).SequenceEqual(second: parameter.Skills.OrderBy(keySelector: skill => skill.Id));
            return success ? Level : EmployeeLevel.None;
        }
    }
}