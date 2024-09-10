using UserInsuranceDetails.WebApi.Models;

namespace UserInsuranceDetails.WebApi.Services.XmlToJsonService.Interface
{
    public interface IXmlToJsonService
    {
        public Task<ApiResponseModel<object>> GetJsonDataAsync(string configCode);
    }
}
