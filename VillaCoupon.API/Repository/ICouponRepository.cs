using VillaCoupon.API.Models;

namespace VillaCoupon.API.Repository
{
    public interface ICouponRepository
    {
        Task<ICollection<Coupon>> GetAllCouponsAsync();
        Task<Coupon?> GetCouponByIdAsync(int id);
        Task<Coupon?> GetCouponByNameAsync(string couponName);
        Task CreateAsync(Coupon coupon);
        Task UpdateAsync(Coupon coupon);
        Task RemoveAsync(Coupon coupon);
        Task SaveAsync();
    }
}
