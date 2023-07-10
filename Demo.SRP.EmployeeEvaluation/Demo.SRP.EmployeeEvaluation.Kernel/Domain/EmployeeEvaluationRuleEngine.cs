using System.Collections.Generic;
using System.Linq;
using Demo.SRP.EmployeeEvaluation.Kernel.Domain.Rules;
using MoreLinq;

namespace Demo.SRP.EmployeeEvaluation.Kernel.Domain
{
    public static class EmployeeEvaluationRuleEngine
    {
        private static IEnumerable<IEmployeeLevelEvaluationStrategy> Strategies { get; } =
            new IEmployeeLevelEvaluationStrategy[]
            {
                new JuniorSoftwareEngineerLevelOneEvaluator(), new JuniorSoftwareEngineerLevelTwoEvaluator(),
                new SeniorSoftwareEngineerLevelOneEvaluator(), new SoftwareEngineerTeamLeaderEvaluator(),
                new SoftwareArchitectEvaluator()
            };

        public static EmployeeJobLevel CalculateLevel(Employee employee)
        {
            return Strategies
                .Select(strategy => strategy.EvaluateEmployeeLevel(employee))
                .DefaultIfEmpty(EmployeeJobLevel.Undefined)
                .MaxBy(level => level.Id)
                .FirstOrDefault();
        }
    }
}
