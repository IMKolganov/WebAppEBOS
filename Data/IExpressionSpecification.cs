namespace WebAppEBOS.Data;

public interface IExpressionSpecification<T> : ISpecification<T>
{
    System.Linq.Expressions.Expression<Func<T, bool>> Expression { get; }
}