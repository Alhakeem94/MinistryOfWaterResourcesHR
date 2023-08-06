using homework.backEnd.Interfaces.ClassifiesInterface;
using homework.Data;
using HR.Models.Classifies;

namespace homework.backEnd.Repositories.ClassifiesRepos
{
    public class ServiceStatusRepos : IServiceStatus
    {
        private ApplicationDbContext _dbContext;

        public ServiceStatusRepos(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<string> AddServiceStatus(ServiceStatusClassify serviceStatus)
        {
            var name = _dbContext.ServiceStatusTable.FirstOrDefault(a =>
                a.ServiceStatus == serviceStatus.ServiceStatus);
            if (name == null)
            {
                await _dbContext.ServiceStatusTable.AddAsync(serviceStatus);
                await _dbContext.SaveChangesAsync();
                return "The service Status Table has been successfully added to the database";
            }
            return "The service Status Table already exists in the database";
        }

        public async Task<string> RemoveServiceStatus(int id)
        {
            var obj = _dbContext.ServiceStatusTable.FirstOrDefault(a => a.Id == id);
            if (obj != null)
            {
                _dbContext.ServiceStatusTable.Remove(obj);
                await _dbContext.SaveChangesAsync();
                return "The Service Status has been successfully removed from the database";
            }
            return "Can't Remove Service Status from database";
        }

        public Task<string> UpdateServiceStatus(ServiceStatusClassify serviceStatus)
        {
            throw new NotImplementedException();
        }
    }
}
