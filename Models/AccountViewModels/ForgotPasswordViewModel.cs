using System.ComponentModel.DataAnnotations;


namespace TutorialHub.Models.AccountViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
