﻿namespace WebAppEBOS.Data.Entites.Interfaces;

public interface IEntityBase
{
    public DateTime Created { get; set; }
    public DateTime Updated { get; set; }
}