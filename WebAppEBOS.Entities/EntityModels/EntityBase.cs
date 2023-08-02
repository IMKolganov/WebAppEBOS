using WebAppEBOS.Entities.EntityModels.Interfaces;

namespace WebAppEBOS.Entities.EntityModels;

public class EntityBase : IEntityBase
{
    public DateTime Created { get; set; } = DateTime.UtcNow;
    public DateTime Updated { get; set; } = DateTime.UtcNow;
}