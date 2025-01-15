using PromoSpark.Domain.Entities;
using PromoSpark.Application.Models.DTOs;
using PromoSpark.Application.Models.Requests;
using AutoMapper;
using PromoSpark.Domain.Common.Enums;


namespace PromoSpark.Infrastructure.Services
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            // User mappings
            CreateMap<User, UserDto>()
                .ForMember(dest => dest.Role, opt =>
                    opt.MapFrom(src => src.Role.ToString()));

            CreateMap<RegisterRequest, User>()
                .ForMember(dest => dest.PasswordHash, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedAt, opt =>
                    opt.MapFrom(src => DateTime.UtcNow));

            // Challenge mappings
            CreateMap<Challenge, ChallengeDto>()
                .ForMember(dest => dest.Creative, opt =>
                    opt.MapFrom(src => src.Creative));

            CreateMap<CreateChallengeRequest, Challenge>()
                .ForMember(dest => dest.Status, opt =>
                    opt.MapFrom(src => StatusEnum.Pending))
                .ForMember(dest => dest.CreatedAt, opt =>
                    opt.MapFrom(src => DateTime.UtcNow));

            // Submission mappings
            CreateMap<Submission, SubmissionDto>()
                .ForMember(dest => dest.Participant, opt =>
                    opt.MapFrom(src => src.Participant));

            CreateMap<CreateSubmissionRequest, Submission>()
                .ForMember(dest => dest.IsVerified, opt =>
                    opt.MapFrom(src => false))
                .ForMember(dest => dest.CreatedAt, opt =>
                    opt.MapFrom(src => DateTime.UtcNow));
        }
    }
}
