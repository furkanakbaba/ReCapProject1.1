using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConserns.Validation
{
    public static class ValidationTool//burada generic bir validation kuralları sınıfı oluşturduk. 
        //Business ta operasoyonlar içinde spagetti olmasın da başa attribute olarak atayalım diye klasörledik.
    {

        public static void Validate(IValidator validator, object entity)
        {
            var context = new ValidationContext<object>(entity);
            var result = validator.Validate(context);
            if (!result.IsValid)//geçerli değilse
            {
                throw new ValidationException(result.Errors);
            }
        }
    }


}
