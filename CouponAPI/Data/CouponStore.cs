using CouponAPI.Models;

namespace CouponAPI.Data
{
    public static class CouponStore
    {
        public static List<Coupon> couponList = new List<Coupon>()
        {
            new Coupon
            {
                Id = 1,
                Name = "New Year Coupon",
                Percent = 10,
                IsActive = true
            },
            new Coupon
            {
                Id = 2,
                Name = "Christmas Coupon",
                Percent = 20,
                IsActive = true
            },
            new Coupon
            {
                Id = 3,
                Name = "Black Friday Coupon",
                Percent = 30,
                IsActive = true
            },
        };
    }
}
