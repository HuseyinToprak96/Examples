using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Threading.Tasks;
using Web.Identity.Models;

namespace Web.Identity.CustomValidator
{
    public class CustomPasswordValidator : IPasswordValidator<AppUser>
    {
        public Task<IdentityResult> ValidateAsync(UserManager<AppUser> manager, AppUser user, string password)
        {
         List<IdentityError> errors = new List<IdentityError>();
            if (password.ToLower().Contains(user.UserName))
            {
                errors.Add(new IdentityError { Code = "PasswordContainsUserName",Description="Kullanıcı Adı içeremez!" });

            }
            if (password.ToLower().Contains("1234"))
            {
                errors.Add(new IdentityError { Code = "PasswordContains1234", Description = "Şifre alanı ardışık sayı içeremez!" });
            }
            if (password.ToLower().Contains(user.Email.ToLower()))
            {
                errors.Add(new IdentityError() { Code = "PasswordContainsEmail", Description="Şifre alanı email adresiniz içeremez!" });                
            }

            if (errors.Count == 0)
            {
                return Task.FromResult(IdentityResult.Success);
            }
            else
            {
                return Task.FromResult(IdentityResult.Failed(errors.ToArray()));
            }
        }
    }
}
