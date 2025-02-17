using Microsoft.EntityFrameworkCore;
using VillaCoupon.API.Data;
using VillaCoupon.API.Models;

namespace VillaCoupon.API.Repository
{
    public class CouponRepository: ICouponRepository
    {   
        private readonly ApplicationDbContext _context;
        public CouponRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Coupon>> GetAllCouponsAsync() 
        {
            return await _context.Coupons.ToListAsync();
        }
        public async Task<Coupon?> GetCouponByIdAsync(int id)
        {
            return await _context.Coupons.FindAsync(id);
        }
        public async Task<Coupon?> GetCouponByNameAsync(string couponName)
        {
            return await _context.Coupons.FirstOrDefaultAsync(x=>x.Name== couponName);
        }
        public async Task CreateAsync(Coupon coupon)
        {
            await _context.Coupons.AddAsync(coupon);
        }
        public async Task UpdateAsync(Coupon coupon)
        {
            _context.Coupons.Update(coupon);
        }
        public async Task RemoveAsync(Coupon coupon)
        {
            _context.Coupons.Remove(coupon);
        }
        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
