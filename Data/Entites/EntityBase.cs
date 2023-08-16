﻿using WebAppEBOS.Data.Entites.Enums;
using WebAppEBOS.Data.Entites.Interfaces;

namespace WebAppEBOS.Data.Entites;

public class EntityBase : IEntityBase
{
    public DateTime Created { get; set; } = DateTime.UtcNow;
    public DateTime Updated { get; set; } = DateTime.UtcNow;
    public EntityStatus Status { get; set; } = EntityStatus.Active;
}