using AutoMapper;
using UserInsuranceDetails.WebApi.DAL.Entity;
using UserInsuranceDetails.WebApi.Models;

namespace UserInsuranceDetails.WebApi.Services.Mapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig() 
        {
            CreateMap<XmlDataEntity, XmlDataModel>().ReverseMap();
        }
    }
}
