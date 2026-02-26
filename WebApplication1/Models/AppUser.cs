using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace WebApplication1.Models;

public class AppUser:IdentityUser
{
    [StringLength(255)]
    public string? PhotoPath { get; set; }
    public bool IsActive { get; set; }
    [Column(TypeName = "datetime")]
    public DateTime CreatedAt { get; set; }
}