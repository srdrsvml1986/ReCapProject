using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    class CarImageValidator : AbstractValidator<CarImage>
    {
        public CarImageValidator()
        {
            //RuleFor(u => u.Date).NotEmpty();
            RuleFor(u => u.CarId).NotEmpty();
            //RuleFor(u => u.ImagePath).NotEmpty();       
        } 
    }
}
