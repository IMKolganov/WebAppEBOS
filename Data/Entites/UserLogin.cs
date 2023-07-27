using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using WebAppEBOS.Data.Entites.Interfaces;

namespace WebAppEBOS.Data.Entites;

public class UserLogin : IdentityUserLogin<int>, IEntity<int>, IEntityBase
{
    [Required, Key] public int UserId { get; set; }
    public DateTime Created { get; set; }
    public DateTime Updated { get; set; }
}