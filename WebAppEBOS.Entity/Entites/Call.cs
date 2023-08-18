using System.ComponentModel.DataAnnotations;
using WebAppEBOS.Entity.Entites.Enums;
using WebAppEBOS.Entity.Entites.Interfaces;

namespace WebAppEBOS.Entity.Entites;

public class Call : EntityBase, IEntity<int>
{
    [Required, Key] public int Id { get; set; } 
    public int? CallerId { get; set; } 
    public int? ReceiverId { get; set; }
    public string CallerPhoneNumber { get; set; }
    public string ReceiverPhoneNumber { get; set; }
    [Required, MaxLength(255)] public string Subject { get; set; } = null!;
    [Required, MaxLength(255)] public string Description { get; set; } = null!;
    public DateTime StartTime { get; set; }
    public int DurationInSeconds { get; set; }
    public CallStatus CallStatus { get; set; }
    public CallRating CallRating { get; set; }
    public bool IsArchived { get; set; }
    public DateTime CallDateTime { get; set; }
}