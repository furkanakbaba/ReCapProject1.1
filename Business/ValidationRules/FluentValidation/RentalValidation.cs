using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidation : AbstractValidator<Rental>
    {
        public RentalValidation()
        {
            RuleFor(r => r.RentDate).NotEmpty();
            RuleFor(r => r.CarId).GreaterThanOrEqualTo(1);
            RuleFor(r => r.CustomerId).GreaterThanOrEqualTo(1);
            RuleFor(r => r.CustomerId).NotEmpty();
            RuleFor(r => r.RentDate).NotEmpty();
        }
    }
}
