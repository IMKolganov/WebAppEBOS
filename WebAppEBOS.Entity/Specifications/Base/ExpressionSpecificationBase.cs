using WebAppEBOS.Entity.Extensions;
using WebAppEBOS.Entity.Specifications.Interfaces;

namespace WebAppEBOS.Entity.Specifications.Base;

public abstract class ExpressionSpecificationBase<T> : 
    IExpressionSpecification<T>,
    ISpecification<T>
{
    private readonly System.Linq.Expressions.Expression<Func<T, bool>> _expression;
    private Func<T, bool> _expressionFunc;

    public System.Linq.Expressions.Expression<Func<T, bool>> Expression => this._expression ?? this.BuildExpression();

    private Func<T, bool> ExpressionFunc => this._expressionFunc ?? (this._expressionFunc = this.Expression.Compile());

    protected ExpressionSpecificationBase()
    {
    }

    protected ExpressionSpecificationBase(System.Linq.Expressions.Expression<Func<T, bool>> expression)
    {
        expression.ThrowIfNull<System.Linq.Expressions.Expression<Func<T, bool>>>(nameof (expression));
        this._expression = expression;
    }

    public bool IsSatisfied(T item) => this.ExpressionFunc(item);

    protected abstract System.Linq.Expressions.Expression<Func<T, bool>> BuildExpression();
}