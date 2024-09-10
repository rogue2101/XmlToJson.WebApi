using AutoMapper;
using UserInsuranceDetails.WebApi.DAL.Repositories.Interfaces;
using UserInsuranceDetails.WebApi.Extensions;
using UserInsuranceDetails.WebApi.Models;
using UserInsuranceDetails.WebApi.Services.XmlToJsonService.Interface;

namespace UserInsuranceDetails.WebApi.Services.XmlToJsonService.Implementation
{
    public class XmlToJsonService : IXmlToJsonService
    {
        private readonly IXmlDataRepository _userDetailRepository;
        private readonly IMapper _mapper;
        public XmlToJsonService(IXmlDataRepository userDetailRepository, IMapper mapper)
        {
            _userDetailRepository = userDetailRepository;
            _mapper = mapper;
        }
        private async Task<XmlDataModel> GetXmlDataAsync(string configCode)
        {
            return _mapper.Map<XmlDataModel>(await _userDetailRepository.GetByConfigCodeAsync(configCode));
        }

        public async Task<ApiResponseModel<object>> GetJsonDataAsync(string configCode)
        {
            XmlDataModel? xmlDataModel = await GetXmlDataAsync(configCode);
            ResponseType responseType = new ResponseType();
            Type type = responseType.GetResponseType(configCode);

            if (xmlDataModel == null)
            {
                return new ApiResponseModel<object>()
                {
                    TimeStamp = DateTime.UtcNow,
                    StatusMessage = "Not Found",
                    StatusCode = 404,
                    Body = null!
                };
            }


            Type genericType = typeof(XmlToJsonDeserialize<>).MakeGenericType(type);

            var instance = Activator.CreateInstance(genericType);

            var method = genericType.GetMethod("ConvertToJson");

            var jsonResult = method.Invoke(instance, new object[] { xmlDataModel.XmlData! });

            return new ApiResponseModel<object>()
            {
                TimeStamp = DateTime.UtcNow,
                StatusMessage = "Success",
                StatusCode = 200,
                Body = jsonResult
            };
        }

    }
}
