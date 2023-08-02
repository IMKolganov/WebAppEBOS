namespace WebAppEBOS.Entities.Specifications.Interfaces;

public interface IQuerySpecification<T> : 
    IExpressionSpecification<T>,
    ISpecification<T>,
    IHasQuerySpecification,
    IHasSize
{
}