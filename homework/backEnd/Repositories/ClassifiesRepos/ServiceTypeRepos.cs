using homework.backEnd.Interfaces.ClassifiesInterface;
using homework.Data;
using HR.Models.Classifies;

namespace homework.backEnd.Repositories.ClassifiesRepos
{
    public class ServiceTypeRepos : IServiceType
    {
        private readonly ApplicationDbContext _dbContext;

        public ServiceTypeRepos(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<string> AddServiceType(ServiceTypeClassify serviceType)
        {
            var name = _dbContext.ServiceTypeTable.FirstOrDefault(a =>
                a.ServiceType == serviceType.ServiceType);
            if (name == null)
            {
                await _dbContext.ServiceTypeTable.AddAsync(serviceType);
                await _dbContext.SaveChangesAsync();
                return "The service Type has been successfully added to the database";
            }
            return "The service Type Table already exists in the database";
        }

        public async Task<string> RemoveServiceType(int id)
        {
            var obj = _dbContext.ServiceTypeTable.FirstOrDefault(a => a.Id == id);
            if (obj != null)
            {
                _dbContext.ServiceTypeTable.Remove(obj);
                await _dbContext.SaveChangesAsync();
                return "The Service Type has been successfully removed from the database";
            }
            return "Can't Remove Service Type from database";
        }

        public Task<string> UpdateServiceType(ServiceTypeClassify serviceType)
        {
            throw new NotImplementedException();
        }
    }
}
