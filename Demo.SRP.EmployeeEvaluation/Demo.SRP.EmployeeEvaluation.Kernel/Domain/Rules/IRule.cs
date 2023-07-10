namespace Demo.SRP.EmployeeEvaluation.Kernel.Mutual
{
    public interface IRule<in TSpecification, out TResponse>
    {
        TResponse Evaluate(TSpecification parameter);
    }
}
