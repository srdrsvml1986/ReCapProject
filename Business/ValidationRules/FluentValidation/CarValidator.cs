using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c=>c.Description).NotEmpty();
            RuleFor(c=>c.DailyPrice).GreaterThan(100);
            RuleFor(c=>c.Description).Must(StartWithA).WithMessage("Description A harfi ile başlamalı");
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
