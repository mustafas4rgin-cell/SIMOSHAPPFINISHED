using System.ComponentModel.DataAnnotations;

namespace SimoshStore
{
    public class RegisterViewModel
{
    [Required]
    public string FirstName { get; set; } = default!;
    [Required]
    public string LastName { get; set; } = default!;
    [DataType(DataType.PhoneNumber)]
    public string Phone { get; set; } = default!;
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; } = default!;
    [DataType(DataType.Password)]
    public string Password { get; set; } = default!;
    [Compare(nameof(Password), ErrorMessage = "Passwords do not match.")]
    public string PasswordConfirm { get; set; } = default!;
}

}

