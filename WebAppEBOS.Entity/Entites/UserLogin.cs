using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using WebAppEBOS.Entity.Entites.Interfaces;

namespace WebAppEBOS.Entity.Entites;

public class UserLogin : IdentityUserLogin<int>, IEntity<int>, IEntityBase
{
    [Required, Key] public override int UserId { get; set; }
    public DateTime Created { get; set; }
    public DateTime Updated { get; set; }
}