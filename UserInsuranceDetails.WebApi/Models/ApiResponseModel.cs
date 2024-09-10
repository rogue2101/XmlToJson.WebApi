namespace UserInsuranceDetails.WebApi.Models
{
    public class ApiResponseModel<T>
    {
        public DateTime? TimeStamp { get; set; }
        public string StatusMessage { get; set; }
        public int StatusCode { get; set; }
        public T Body { get; set; }  // Make Body of type T
    }
}
