using Microsoft.EntityFrameworkCore;
using UserInsuranceDetails.WebApi.DAL.DatabaseContext;
using UserInsuranceDetails.WebApi.DAL.Entity;
using UserInsuranceDetails.WebApi.DAL.Repositories.Interfaces;

namespace UserInsuranceDetails.WebApi.DAL.Repositories.Implementations
{
    public class XmlDataRepository : IXmlDataRepository
    {
        private readonly XmlDataDbContext _dbContext;

        public XmlDataRepository(XmlDataDbContext userDetailDbContext)
        {
            _dbContext = userDetailDbContext;
        }

        public async Task<XmlDataEntity> GetByConfigCodeAsync(string configCode)
        {
            var userDetails =  await _dbContext.UserInsuranceDetails.FirstOrDefaultAsync(u => u.ConfigCode == configCode);
            if (userDetails == null)
            {
                return null!;
            }
            return userDetails;
        }
    }
}
