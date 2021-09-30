using System.Linq;
using API.DTOs;
using API.Entities;
using AutoMapper;

namespace API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AppUser, UserToDisplayDto>()
                .ForMember(dest => dest.PhotoUrl, 
                opt => opt.MapFrom(src => src.Photos.FirstOrDefault(x => x.IsMain).Url))
                .ForMember(des => des.LawCollegeStudiedIn, 
                opt => opt.MapFrom(src => src.LawyerDetails.FirstOrDefault().LawCollegeStudiedIn))
                .ForMember(x => x.Interest1, 
                opt => opt.MapFrom(src => src.Interests.FirstOrDefault().Interest1));

            CreateMap<Photo, PhotoDto>();
            CreateMap<Interest, InterestDto>();
            CreateMap<LawyerDetail, LawyerDetailDto>();
        }
    }
}