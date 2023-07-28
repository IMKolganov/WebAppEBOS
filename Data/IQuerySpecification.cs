namespace WebAppEBOS.Data;

public interface IQuerySpecification<T> : 
    IExpressionSpecification<T>,
    ISpecification<T>,
    IHasQuerySpecification,
    IHasSize
{
}