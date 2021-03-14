using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            //doğrulama kodları buraya gelecek.
            RuleFor(c => c.CompanyName).MinimumLength(3);
        }
    }
}
