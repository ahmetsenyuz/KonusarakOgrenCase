using System.ComponentModel.DataAnnotations;

namespace KonusarakOgrenCase.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Kullanıcı adı alanı gereklidir")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Şifre alanı gereklidir.")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Şifreniz minimum 6 karaterli olmalıdır!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
