using System.ComponentModel.DataAnnotations;

namespace FitnessClient.ViewModels
{
  public class RegisterViewModel
  {
    [Required]
    [Display(Name = "Name")]
    public string Name { get; set; }

    [Required]
    [EmailAddress]
    [Display(Name = "Email")]
    public string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    public string Password { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "Confirm Password")]
    [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
    public string ConfirmPassword { get; set; }

    [Required]
    [Display(Name = "Your Height(in inches)")]
    public int Height { get; set; }

    [Required]
    [Display(Name = "Current Weight")]
    public int Weight { get; set; }
    [Required]
    [Display(Name = "Age")]
    public int Age { get; set; }
    
    [Required]
    [Display(Name = "Fitness Level")]
    public string FitnessLevel { get; set; }
    
    [Required]
    [Display(Name = "Gender")]
    public string Gender { get; set; }
  }
}