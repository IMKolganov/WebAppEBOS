using WebAppEBOS.Data.Specifications.Interfaces;

namespace WebAppEBOS.Data.Specifications.Base;

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