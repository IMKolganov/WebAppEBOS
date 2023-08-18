using System.Linq.Expressions;
using WebAppEBOS.Entity.Entites;
using WebAppEBOS.Entity.Entites.Enums;
using WebAppEBOS.Entity.Specifications.Base;

namespace WebAppEBOS.Entity.Specifications;

public sealed class AllCallsSpecification: QuerySpecificationBase<Call>
{
    // private readonly int _ownerId;
    // private readonly int _friendId;

    public AllCallsSpecification()
    {
        // _ownerId = ownerId;
        // _friendId = friendId;
    }

    protected override Expression<Func<Call, bool>> BuildExpression()
    {
        return x =>
            x.Status == EntityStatus.Active &&
            (
                true
                // (x.ParentId == _ownerId && x.ChildId == _friendId) ||
                // (x.ChildId == _ownerId && x.ParentId == _friendId)
            );
    }
}