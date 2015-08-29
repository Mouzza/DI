using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UI_MVC.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class ContactViewModel
    {
        [Required(ErrorMessage = "Gelieve een voornaam in te geven")]
        [StringLength(25, ErrorMessage = "{0} moet minstens {2} karakters en max 25 karakters lang zijn. ", MinimumLength = 3)]
        [Display(Name = "Voornaam")]
        public string Voornaam { get; set; }

        [Required(ErrorMessage = "Gelieve een achternaam in te geven")]
        [Display(Name = "Achternaam")]
        [StringLength(25, ErrorMessage = "{0} moet minstens {2} karakters en max 25 karakters lang zijn. ", MinimumLength = 3)]
        public string Achternaam { get; set; }

        [Required(ErrorMessage = "Gelieve een telefoonnummer in te geven")]
        [StringLength(10, ErrorMessage = "{0} moet minstens {2} karakters en max 10 karakters lang zijn. ", MinimumLength = 9)]
        [Display(Name = "Telefoonnummer")]
        [RegularExpression(@"[0-9]*\.?[0-9]+", ErrorMessage = "{0} mag enkel cijfers bevatten.")]
        public string Telefoonnummer { get; set; }


        [EmailAddress(ErrorMessage = "Gelieve een geldige emailadres in te geven")]
        [Required(ErrorMessage = "Gelieve een emailadres in te geven")]
        [Display(Name = "Email adres")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Gelieve een bericht in te geven")]
        [StringLength(500, ErrorMessage = "{0} moet minstens {2} karakters en max 500 karakters lang zijn. ", MinimumLength = 5)]
        [Display(Name = "Bericht")]
        public string Bericht { get; set; }


    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
