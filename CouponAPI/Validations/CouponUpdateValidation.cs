using CouponAPI.Models.DTO;
using FluentValidation;

namespace CouponAPI.Validations
{
    public class CouponUpdateValidation : AbstractValidator<CouponUpdateDTO>
    {
        public CouponUpdateValidation()
        {
            RuleFor(c => c.Id).NotEmpty().GreaterThan(0).WithMessage("Coupon Id is required");
            RuleFor(c => c.Name).NotEmpty().WithMessage("Coupon Name is required");
            RuleFor(c => c.Percent).InclusiveBetween(1, 100).WithMessage("Percent must be between 1 and 100");
        }
    }
}
