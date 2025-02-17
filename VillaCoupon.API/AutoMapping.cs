using VillaCoupon.API.DTO;
using VillaCoupon.API.Models;
using AutoMapper;

namespace VillaCoupon.API
{
    public class AutoMapping:Profile
    {
        public AutoMapping()
        {
            CreateMap<Coupon, CouponCreateDTO>().ReverseMap();
            CreateMap<Coupon, CouponUpdateDTO>().ReverseMap();
            CreateMap<Coupon, CouponDTO>().ReverseMap();
            CreateMap<LocalUser, UserDTO>().ReverseMap();
            CreateMap<ApplicationUser, UserDTO>().ReverseMap();
        }
    }
}
