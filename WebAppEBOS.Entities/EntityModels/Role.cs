using Microsoft.AspNetCore.Identity;
using WebAppEBOS.Entities.EntityModels.Interfaces;

namespace WebAppEBOS.Entities.EntityModels;

public class Role : IdentityRole<int>, IEntity<int>, IEntityBase
{ 
    public DateTime Created { get; set; }
    public DateTime Updated { get; set; }
}