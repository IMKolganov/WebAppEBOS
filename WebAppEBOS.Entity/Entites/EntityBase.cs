using WebAppEBOS.Entity.Entites.Enums;
using WebAppEBOS.Entity.Entites.Interfaces;

namespace WebAppEBOS.Entity.Entites;

public class EntityBase : IEntityBase
{
    public DateTime Created { get; set; } = DateTime.UtcNow;
    public DateTime Updated { get; set; } = DateTime.UtcNow;
    public EntityStatus Status { get; set; } = EntityStatus.Active;
}