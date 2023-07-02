using Microsoft.AspNetCore.Identity;

namespace Web.Identity.CustomValidator
{
    public class CustomIdentityErrorDescriber:IdentityErrorDescriber
    {
        public override IdentityError InvalidUserName(string userName)
        {
            
            return new IdentityError { Code="InvalidUserName", Description=$"Bu {userName} geçersizdir." };
        }

        public override IdentityError DuplicateEmail(string email)
        {
            return new IdentityError { Code = "DuplicateEmail", Description = $"Bu {email} kullanılmaktadır!" };  
        }

        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError
            {
                Code = "PasswordTooShort",
                Description = $"Şifreniz en az {length} karakter olmalıdır!"
            };
        }

        public override IdentityError DuplicateUserName(string userName)
        {
            return new IdentityError
            {
                Code = "DuplicateUsername",
                Description = $"Bu {userName} kullanılmaktadır!"
            };
        }
    }
}
