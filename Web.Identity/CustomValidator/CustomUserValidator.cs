
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Identity.Models;

namespace Web.Identity.CustomValidator
{
    public class CustomUserValidator : IUserValidator<AppUser>
    {
        public Task<IdentityResult> ValidateAsync(UserManager<AppUser> manager, AppUser user)
        {
            char[] Digits = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            List<IdentityError> errors = new List<IdentityError>();
            if (Digits.Contains(user.UserName[0]))
            {
                errors.Add(new IdentityError() { Code = "UserNameContainsFirstLetterDigitContains", Description="Kullanıcı adının ilk karakteri sayısal karakter içeremez." });    
            }

            if (errors.Count==0)
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




