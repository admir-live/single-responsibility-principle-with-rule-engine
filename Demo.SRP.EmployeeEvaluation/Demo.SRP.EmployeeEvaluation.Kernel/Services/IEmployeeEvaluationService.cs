using Demo.SRP.EmployeeEvaluation.Kernel.Domain;

namespace Demo.SRP.EmployeeEvaluation.Kernel.Services
{
    public interface IEmployeeEvaluationService
    {
        EmployeeJobLevel Evaluate(Employee employee);
    }
}
