using WebAppEBOS.Entity.Specifications.Interfaces;
using WebAppEBOS.Entity.Specifications.Interfaces;

namespace WebAppEBOS.Entity.Specifications.Base;

public abstract class QuerySpecificationBase<T> : 
    ExpressionSpecificationBase<T>,
    IQuerySpecification<T>,
    IExpressionSpecification<T>,
    ISpecification<T>,
    IHasQuerySpecification,
    IHasSize
{
    public int Size { get; set; } = 50;

    protected QuerySpecificationBase()
    {
    }

    protected QuerySpecificationBase(System.Linq.Expressions.Expression<Func<T, bool>> expression)
        : base(expression)
    {
    }
}