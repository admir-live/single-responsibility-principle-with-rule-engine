using Demo.SRP.EmployeeEvaluation.Kernel.Domain;

namespace Demo.SRP.EmployeeEvaluation.Kernel.Services
{
    public interface IEmployeeEvaluationService
    {
        EmployeeLevel Evaluate(Employee employee);
    }
}