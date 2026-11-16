namespace blazor_form.Models;

using System.ComponentModel.DataAnnotations;

public class CourseRegistrationModel
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

    [Required(ErrorMessage = "Please select a course.")]
    public string Course { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please select a study mode.")]
    public string StudyMode { get; set; } = "Online";

    [Required(ErrorMessage = "Please select a start date.")]
    public DateTime? StartDate { get; set; }

    public string? Comments { get; set; }

    [Range(typeof(bool), "true", "true", ErrorMessage = "You must agree before submitting.")]
    public bool AgreeTerms { get; set; }
}
