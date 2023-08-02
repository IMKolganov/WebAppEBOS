using Microsoft.AspNetCore.Identity;
using WebAppEBOS.Entities.EntityModels.Interfaces;

namespace WebAppEBOS.Entities.EntityModels;

public class User : IdentityUser<int>, IEntity<int>, IEntityBase
{
    // [Required, Key] public int Id { get; set; }
    public DateTime Created { get; set; }
    public DateTime Updated { get; set; }
}