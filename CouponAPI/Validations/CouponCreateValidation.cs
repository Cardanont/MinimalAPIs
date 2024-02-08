using CouponAPI.Models.DTO;
using FluentValidation;

namespace CouponAPI.Validations
{
    public class CouponCreateValidation : AbstractValidator<CouponCreateDTO>
    {
        public CouponCreateValidation()
        {
            RuleFor(c => c.Name).NotEmpty().WithMessage("Coupon Name is required");
            RuleFor(c => c.Percent).InclusiveBetween(1, 100).WithMessage("Percent must be between 1 and 100");
        }
    }
}
