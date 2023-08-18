using System.ComponentModel.DataAnnotations;
using WebAppEBOS.Entity.Entites.Interfaces;

namespace WebAppEBOS.Entity.Entites;

public class Customer : EntityBase, IEntity<int>
{
    [Required, Key] public int Id { get; set; }
    [Required, MaxLength(255)] public string Name { get; set; } = null!;
    [Required, MaxLength(255)] public string Surname { get; set; } = null!;
    [MaxLength(255)] public string TelephoneHomeNumber { get; set; }
    [MaxLength(255)] public string TelephonePhoneNumber { get; set; }
    [MaxLength(255)] public string TelephoneWorkNumber { get; set; }
    [Required, MaxLength(255)] public string Address { get; set; } = null!; 
    [MaxLength(255)] public string Country { get; set; }
    public int PostCode { get; set; }
    public DateTime DateBirth { get; set; }
    [Required] public int RefAppId { get; set; }
    public string? Path { get; set; }
}