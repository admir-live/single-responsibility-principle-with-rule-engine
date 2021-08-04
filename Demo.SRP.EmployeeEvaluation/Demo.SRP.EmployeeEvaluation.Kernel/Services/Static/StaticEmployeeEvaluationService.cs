using Demo.SRP.EmployeeEvaluation.Kernel.Domain;

namespace Demo.SRP.EmployeeEvaluation.Kernel.Services.Static
{
    public sealed class StaticEmployeeEvaluationService : IEmployeeEvaluationService
    {
        public EmployeeLevel Evaluate(Employee employee)
        {
            return EmployeeEvaluationRuleEngine.CalculateLevel(employee: employee);
        }
    }
}