﻿using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using WebAppEBOS.Data.Entites.Interfaces;

namespace WebAppEBOS.Data.Entites;

public class RoleClaim : IdentityRoleClaim<int>, IEntity<int>, IEntityBase
{ 
    public DateTime Created { get; set; }
    public DateTime Updated { get; set; }
}