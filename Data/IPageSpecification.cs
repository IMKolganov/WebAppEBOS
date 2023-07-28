namespace WebAppEBOS.Data;

public interface IPageSpecification<T> : 
    IQuerySpecification<T>,
    IExpressionSpecification<T>,
    ISpecification<T>,
    IHasQuerySpecification,
    IHasSize,
    IHasPageSpecification,
    IHasIndex
{
}