using System.Collections.Generic;
using Demo.SRP.EmployeeEvaluation.Kernel.Domain.Rules;
using Demo.SRP.EmployeeEvaluation.Kernel.Mutual;

namespace Demo.SRP.EmployeeEvaluation.Kernel.Domain
{
    public static class EmployeeEvaluationRuleEngine
    {
        private static IEnumerable<IRule<Employee, EmployeeLevel>> Rules { get; } = new IRule<Employee, EmployeeLevel>[]
        {
            new RuleForSoftwareEngineer1(),
            new RuleForSoftwareEngineer2(),
            new RuleForSoftwareEngineer3(),
            new RuleForSoftwareEngineer4(),
            new RuleForSoftwareEngineer5(),
            new RuleForSoftwareEngineer6()
        };

        public static EmployeeLevel CalculateLevel(Employee employee)
        {
            var level = EmployeeLevel.None;
            foreach (var rule in Rules)
            {
                var candidate = rule.Evaluate(parameter: employee);
                if (candidate.Id > level.Id)
                {
                    level = candidate;
                }
            }

            return level;
        }
    }
}