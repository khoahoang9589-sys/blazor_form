namespace blazor_form.Models;

using System.ComponentModel.DataAnnotations;

public class CustomerContactModel
{
    [Required(ErrorMessage = "Full name must be at least 3 characters long.")]
    [MinLength(3, ErrorMessage = "Full name must be at least 3 characters long.")]
    public string FullName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please enter a valid email address.")]
    [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Please enter a valid email address.")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Phone number must be 10-12 digits.")]
    [RegularExpression(@"^\d{10,12}$", ErrorMessage = "Phone number must be 10-12 digits.")]
    public string PhoneNumber { get; set; } = string.Empty;

    [RegularExpression(@"^$|^[\s\S]{5,}$", ErrorMessage = "Address must be at least 5 characters long.")]
    public string? Address { get; set; }

    [Required(ErrorMessage = "Message must be at least 10 characters long.")]
    [MinLength(10, ErrorMessage = "Message must be at least 10 characters long.")]
    public string Message { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please select a service.")]
    public string Service { get; set; } = string.Empty;

    [Range(typeof(bool), "true", "true", ErrorMessage = "You must agree before submitting.")]
    public bool AgreeTerms { get; set; }
}
