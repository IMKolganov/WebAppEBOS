using System.ComponentModel.DataAnnotations;
using WebAppEBOS.Entity.Entites.Interfaces;

namespace WebAppEBOS.Entity.Entites;

public class Customer : EntityBase, IEntity<int>
{
    [Required, Key] public int Id { get; set; }
    [Required, MaxLength(255)] public string Name { get; set; } = null!;
    [Required] public int RefAppId { get; set; }
    public string? Path { get; set; }
}