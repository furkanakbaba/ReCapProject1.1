using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidation:AbstractValidator<Customer>
    {
        public CustomerValidation()
        {
            RuleFor(c=>c.CompanyName).NotEmpty().WithMessage("Bu alan boş geçilemez.");
            RuleFor(c=>c.Id).NotEmpty();
            RuleFor(c=>c.UserId).NotEmpty();
        }
    }
}
