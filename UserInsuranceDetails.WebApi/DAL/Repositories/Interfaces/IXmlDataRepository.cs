using UserInsuranceDetails.WebApi.DAL.Entity;

namespace UserInsuranceDetails.WebApi.DAL.Repositories.Interfaces
{
    public interface IXmlDataRepository
    {
        public Task<XmlDataEntity> GetByConfigCodeAsync(string configCode);
    }
}
