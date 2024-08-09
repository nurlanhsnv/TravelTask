using EntitiesT.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessT.Validation.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(p=> p.Username).MinimumLength(4).WithMessage("minimum uzunlugu 4 olmalidir").NotEmpty().WithMessage("bosh gonderile bilmez");
            RuleFor(p=> p.Email).MinimumLength(4).WithMessage("minimum uzunlugu 4 olmalidir").NotEmpty().WithMessage("bosh gonderile bilmez");
        }
    }
}
