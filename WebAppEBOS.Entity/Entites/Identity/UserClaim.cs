﻿using Microsoft.AspNetCore.Identity;
using WebAppEBOS.Entity.Entites.Interfaces;

namespace WebAppEBOS.Entity.Entites.Identity;

public class UserClaim : IdentityUserClaim<int>, IEntity<int>, IEntityBase
{   
    public DateTime Created { get; set; }
    public DateTime Updated { get; set; }
}