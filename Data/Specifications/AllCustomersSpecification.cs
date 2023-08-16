using System.Linq.Expressions;
using WebAppEBOS.Data.Entites;
using WebAppEBOS.Data.Entites.Enums;
using WebAppEBOS.Data.Specifications.Base;

namespace WebAppEBOS.Data.Specifications;

public sealed class AllCustomersSpecification: QuerySpecificationBase<Customer>
{
    // private readonly int _ownerId;
    // private readonly int _friendId;

    public AllCustomersSpecification()
    {
        // _ownerId = ownerId;
        // _friendId = friendId;
    }

    protected override Expression<Func<Customer, bool>> BuildExpression()
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