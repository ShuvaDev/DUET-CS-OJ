using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace DUET_CS_OJ.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("Remember Me?")]
        public bool RememberMe { get; set; }
    }
}
