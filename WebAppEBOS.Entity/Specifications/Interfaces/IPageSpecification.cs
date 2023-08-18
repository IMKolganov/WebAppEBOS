using WebAppEBOS.Entity.Specifications.Interfaces;

namespace WebAppEBOS.Entity.Specifications.Interfaces;

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