using homework.backEnd.Interfaces.ClassifiesInterface;
using homework.Data;
using HR.Models.Classifies;

namespace homework.backEnd.Repositories.ClassifiesRepos
{
    public class ServiceRepos : IService
    {
        private ApplicationDbContext _dbContext;

        public ServiceRepos(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<string> AddService(ServiceClassify service)
        {
            var name = _dbContext.ServiceTable.FirstOrDefault(a =>
                a.ServiceName == service.ServiceName);
            if (name == null)
            {
                await _dbContext.ServiceTable.AddAsync(service);
                await _dbContext.SaveChangesAsync();
                return "The service Table has been successfully added to the database";
            }
            return "The service Table already exists in the database";
        }

        public async Task<string> RemoveService(int id)
        {
            var obj = _dbContext.ServiceTable.FirstOrDefault(a => a.Id == id);
            if (obj != null)
            {
                _dbContext.ServiceTable.Remove(obj);
                await _dbContext.SaveChangesAsync();
                return "The Service has been successfully removed from the database";
            }
            return "Can't Remove Service from database";
        }

        public Task<string> UpdateService(ServiceClassify service)
        {
            throw new NotImplementedException();
        }
    }
}
