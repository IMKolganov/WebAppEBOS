using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using WebAppEBOS.Data.Entites.Interfaces;

namespace WebAppEBOS.Data.Entites;

public class UserToken : IdentityUserToken<int>, IEntity<int>, IEntityBase
{
    [Required, Key] public int UserId { get; set; }
    [Required, Key] public string LoginProvider { get; set; } = "MyTokenProvider";
    [Required, Key][ProtectedPersonalData]
    public string? Value { get; set; }
    public DateTime Created { get; set; }
    public DateTime Updated { get; set; }
}