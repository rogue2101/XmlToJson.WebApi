using UserInsuranceDetails.WebApi.Models;

namespace UserInsuranceDetails.WebApi.Extensions
{
    public class ResponseType
    {
        public Dictionary<string, Type> responseType = null!;

        public ResponseType()
        {
            responseType = new Dictionary<string, Type>();
            responseType.Add("userinsurancedata", typeof(InsuranceList));
            responseType.Add("breakfastmenu", typeof(BreakfastMenu));
        }

        public Type GetResponseType(string configCode)
        {
            return responseType.GetValueOrDefault(configCode, null);
        }
    }
}
