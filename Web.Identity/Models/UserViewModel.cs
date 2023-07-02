using System.ComponentModel.DataAnnotations;

namespace Web.Identity.Models
{
    public class UserViewModel
    {
        [Required(ErrorMessage ="Kullanıcı Adı Zorunludur!")]
        [Display(Name ="Kullanıcı Adı")]
        public string Username { get; set; }
        [Display(Name ="Tel No")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage ="Email Adresi Zorunludur!")]
        [Display(Name ="Email Adresi")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Şifre Zorunludur!")]
        [Display(Name ="Şifre")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
