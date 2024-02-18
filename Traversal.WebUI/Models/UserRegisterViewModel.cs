using System.ComponentModel.DataAnnotations;

namespace Traversal.WebUI.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage ="Lütfen adınızı giriniz")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Lütfen soy adınızı giriniz")]
        public string Surname { get; set; }

        [Required(ErrorMessage ="Lütfen adınızı giriniz")]
        public string Username { get; set; }

        [Required(ErrorMessage ="Lütfen mail adresinizi giriniz")]
        public string Mail{ get; set; }

        [Required(ErrorMessage ="Lütfen şifreyi giriniz")]
        public string Password { get; set; }

        [Required(ErrorMessage ="Lütfen şifreyi tekrar giriniz")]
        [Compare("Password",ErrorMessage ="Şifreler uyumlu değil")]
        public string ConfirmPassword { get; set; }

        
    }
}
 