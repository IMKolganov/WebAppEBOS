namespace WebAppEBOS.Data.Entites.Enums;

public enum EntityStatus
{
    Deleted = -1, // 0xFFFFFFFF
    Disabled = 0,
    Active = 1,
    Pending = 2,
}