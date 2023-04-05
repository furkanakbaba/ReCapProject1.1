using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidation : AbstractValidator<Car>
    {
        public CarValidation()
        {
            RuleFor(c => c.Id ).NotEmpty();
            RuleFor(c => c.DailyPrice > 0).NotEmpty().WithMessage("Araç günlük kiralama fiyatı 0 dan büyük olmalıdır.");
            RuleFor(c => c.BrandId).NotEmpty();
            RuleFor(c => c.ColorId).NotEmpty();
            RuleFor(c => c.ModelYear).NotEmpty();
            RuleFor(c => c.Description).NotEmpty();
            RuleFor(c => c.Description.Length <= 500);
        }
    }
}
