using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebApplication1.Models;

//Donors = Muzakki
public class Donor
{
    public int DonorId { get; set; }
    [Required, StringLength(100)]
    public string? FirstName { get; set; }
    [Required, StringLength(100)]
    public string? LastName { get; set; }
    [StringLength(150)]
    public string? Email { get; set; }
    [StringLength(20)]
    public string? Phone { get; set; }
    [StringLength(255)]
    public string? PhotoPath { get; set; }
    public bool IsCorporate { get; set; }
    public DateTime RegistrationDate { get; set; }

    public virtual DonorProfile? Profile { get; set; }
    public virtual ICollection<DonorAddress> DonorAddresses { get; set; } = new List<DonorAddress>();
}

public class DonorProfile
{
    public int DonorProfileId { get; set; }
    [Column(TypeName = "datetime")]
    public DateTime DateOfBirth { get; set; }
    [StringLength(20)]
    public string? Gender { get; set; }
    [StringLength(100)]
    public string? Occupation { get; set; }
    [StringLength(20)]
    public string? PreferredLanguage  { get; set; }
    
    [ForeignKey("Donor")]
    public int DonorId { get; set; }
    public virtual Donor? Donor { get; set; }
}

public class DonorAddress
{
    public int AddressId { get; set; }
    [Required]
    public string? AddressLine1 { get; set; }
    [StringLength(50)]
    public string? City { get; set; }
    [StringLength(50)]
    public string? Division { get; set; }
    [StringLength(20)]
    public string? PostalCode { get; set; }
    [StringLength(50)]
    public string? Country { get; set; }
    public bool IsPrimary { get; set; }
    
    [ForeignKey("Donor")] 
    public int DonorId { get; set; }
    public virtual Donor? Donor { get; set; }
}