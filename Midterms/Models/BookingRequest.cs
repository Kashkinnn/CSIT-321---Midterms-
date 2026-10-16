using System.ComponentModel.DataAnnotations;

namespace Midterms.Models;

public class BookingRequest
{
    [Required(ErrorMessage = "Full name is required")]
    public string FullName { get; set; } = "";

    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Enter a valid email")]
    public string Email { get; set; } = "";

    [Required(ErrorMessage = "Pick a destination")]
    public int WonderId { get; set; }

    [Required(ErrorMessage = "Pick a date")]
    public DateTime? TravelDate { get; set; } = DateTime.Today.AddDays(14);

    [Range(1, 20, ErrorMessage = "1 to 20 travelers")]
    public int Travelers { get; set; } = 2;

    public string Notes { get; set; } = "";
}
