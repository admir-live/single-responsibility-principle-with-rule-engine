using Demo.SRP.EmployeeEvaluation.Kernel.Mutual;

namespace Demo.SRP.EmployeeEvaluation.Kernel.Domain
{
    public interface IEmployeeEvaluationRule : IRule<Employee, EmployeeLevel>
    {
    }
}