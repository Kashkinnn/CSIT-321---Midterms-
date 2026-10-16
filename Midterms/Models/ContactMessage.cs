using System.ComponentModel.DataAnnotations;

namespace Midterms.Models;

public class ContactMessage
{
    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; } = "";

    [Required, EmailAddress(ErrorMessage = "Enter a valid email")]
    public string Email { get; set; } = "";

    [Required(ErrorMessage = "Message is required")]
    public string Message { get; set; } = "";
}
