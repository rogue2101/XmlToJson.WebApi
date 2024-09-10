namespace UserInsuranceDetails.WebApi.Models
{
    public class XmlDataModel
    {
        public int Id { get; set; }
        public string ConfigCode { get; set; } = null!;
        public string? XmlData { get; set; }
        public string? CreatedUser { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string? ModifiedUser { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
    }
}
