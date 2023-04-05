using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidation : AbstractValidator<User>
    {
        public UserValidation()
        {
            RuleFor(u=>u.Id).NotEmpty();
            RuleFor(u => u.Email).NotEmpty().WithMessage("Bu alan boş geçilemez").
                EmailAddress().WithMessage("Geçerli bir email adresi giriniz.");

            RuleFor(u => u.Password).Must(IsPasswordValid)
                .WithMessage("Lütfen en az bir büyük, bir küçük harfli olmak üzere, en az sekiz karakterli bir şifre oluşturunuz.")
                .NotEmpty().WithMessage("Bu alan boş geçilemez");

            RuleFor(u => u.FirstName).NotEmpty().WithMessage("Bu alan boş geçilemez.");
            RuleFor(u => u.LastName).NotEmpty().WithMessage("Bu alan boş geçilemez");

            bool IsPasswordValid(string arg)
            {
                Regex regex = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$");
                return regex.IsMatch(arg);
            }


        }
    }
}
