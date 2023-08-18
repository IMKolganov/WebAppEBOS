using WebAppEBOS.Entity.Specifications.Interfaces;

namespace WebAppEBOS.Entity.Specifications.Interfaces;

public interface IQuerySpecification<T> : 
    IExpressionSpecification<T>,
    ISpecification<T>,
    IHasQuerySpecification,
    IHasSize
{
}