using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using WebAppEBOS.Entity.Entites.Interfaces;

namespace WebAppEBOS.Entity.Entites;

public class UserToken : IdentityUserToken<int>, IEntity<int>, IEntityBase
{
    [Required, Key] public override int UserId { get; set; }
    [Required, Key] public override string LoginProvider { get; set; } = "MyTokenProvider";

    [Required, Key]
    [ProtectedPersonalData]
    public override string? Value { get; set; } = "MyTokenValue";
    public DateTime Created { get; set; }
    public DateTime Updated { get; set; }
}