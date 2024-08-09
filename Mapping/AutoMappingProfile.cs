using AutoMapper;
using StudentApp.Modules.Domain;
using StudentApp.Modules.Dto;

namespace StudentApp.Mapping
{
    public class AutoMappingProfile : Profile
    {
        public AutoMappingProfile()
        {
            CreateMap<Student, StudentAddDto>().ReverseMap();
            CreateMap<Student, StudentUpdateDto>().ReverseMap();
            CreateMap<Student, StudentResponseDto>().ReverseMap();
        }
    }
}
