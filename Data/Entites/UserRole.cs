using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using WebAppEBOS.Data.Entites.Interfaces;

namespace WebAppEBOS.Data.Entites;

public class UserRole : IdentityUserRole<int>, IEntity<int>, IEntityBase
{
    // Composite primary key using Data Annotations
    [Key]
    [Column(Order = 1)]
    public override int UserId { get; set; }

    [Key]
    [Column(Order = 2)]
    public override int RoleId { get; set; }
    public DateTime Created { get; set; }
    public DateTime Updated { get; set; }
}