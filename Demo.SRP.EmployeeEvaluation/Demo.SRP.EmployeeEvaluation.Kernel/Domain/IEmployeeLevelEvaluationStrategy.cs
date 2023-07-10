namespace Demo.SRP.EmployeeEvaluation.Kernel.Domain
{
    public interface IEmployeeLevelEvaluationStrategy
    {
        EmployeeJobLevel EvaluateEmployeeLevel(Employee employee);
    }
}
