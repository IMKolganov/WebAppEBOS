using Microsoft.AspNetCore.Identity;
using WebAppEBOS.Entity.Entites.Interfaces;

namespace WebAppEBOS.Entity.Entites;//todo: why i can't change namespace

public class User : IdentityUser<int>, IEntity<int>, IEntityBase
{
    // [Required, Key] public int Id { get; set; }
    public DateTime Created { get; set; }
    public DateTime Updated { get; set; }
}