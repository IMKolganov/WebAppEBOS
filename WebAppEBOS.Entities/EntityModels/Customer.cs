using System.ComponentModel.DataAnnotations;
using WebAppEBOS.Entities.EntityModels.Interfaces;

namespace WebAppEBOS.Entities.EntityModels;

public class Customer : EntityBase, IEntity<int>
{
    [Required, Key] public int Id { get; set; }
    [Required, MaxLength(255)] public string Name { get; set; }
    [Required] public int RefAppId { get; set; }
    public string? Path { get; set; }
}