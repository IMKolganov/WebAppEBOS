using System.Linq.Expressions;
using WebAppEBOS.Entity.Specifications.Base;
using WebAppEBOS.Entity.Specifications.Interfaces;

namespace WebAppEBOS.Entity.Specifications.QuerySpecification
{
    // TODO rewrite
    public enum enOrderByType
    {
        asc = 1, desc = 2
    }
    public interface IQueryOrderBy<T> : IExpressionSpecification<T>, IQuerySpecification<T>
    {
        Expression<Func<T, object>> OrderByExpression { get; }
        enOrderByType _Type { get; }
    }
    public interface IQueryPageOrderBy<T> : IPageSpecification<T>, IQueryOrderBy<T>, IHasIndex
    {
    }
    public class QueryByOrderSpecification<T> : ExpressionSpecificationBase<T>
        , IQueryOrderBy<T>

    {
        public enOrderByType _Type { get; set; } = enOrderByType.asc;
        public int Size { get; set; } = int.MaxValue;
        private readonly Expression<Func<T, object>> _OrderBy;
        public Expression<Func<T, object>> OrderByExpression => _OrderBy;
        protected override Expression<Func<T, bool>> BuildExpression() { return null; }


        public QueryByOrderSpecification(Expression<Func<T, bool>> iExpression, Expression<Func<T, object>> iOrderBy)
            : base(iExpression)
        {
            _OrderBy = iOrderBy;
        }
    }

    public class QueryByOrderPageSpecification<T> : QueryByOrderSpecification<T>
    , IQueryPageOrderBy<T>
    {
        public int Index { get; set; } = 0;

        public QueryByOrderPageSpecification(Expression<Func<T, bool>> iExpression
            , Expression<Func<T, object>> iOrderBy)
            : base(iExpression, iOrderBy)
        {
        }
    }
}
