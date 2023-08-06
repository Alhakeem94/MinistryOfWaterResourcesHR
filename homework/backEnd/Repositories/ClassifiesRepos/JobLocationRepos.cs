using homework.backEnd.Interfaces.ClassifiesInterface;
using homework.Data;
using HR.Models.Classifies;

namespace homework.backEnd.Repositories.ClassifiesRepos
{
    public class JobLocationRepos : IJobLocation
    {
        private readonly ApplicationDbContext _dbContext;

        public JobLocationRepos(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<string> Addjoblocation(JobLocationClassify jobLocationClassify)
        {
            var name = _dbContext.JobLocationTable.FirstOrDefault(a => a.JobLocation == jobLocationClassify.JobLocation);
            if (name == null)
            {
                await _dbContext.JobLocationTable.AddAsync(jobLocationClassify);
                await _dbContext.SaveChangesAsync();
                return "The job location Table has been successfully added to the database";
            }
            else
            {
                return "The job location Table already exists in the database";
            }
        }

        public async Task<string> Removejoblocation(int id)
        {
            var obj = _dbContext.JobLocationTable.FirstOrDefault(a => a.Id == id);
            if (obj != null)
            {
                _dbContext.JobLocationTable.Remove(obj);
                await _dbContext.SaveChangesAsync();
                return "The Job Location has been successfully removed from the database";
            }
            return "Can't Remove Job Location from database";
        
        }

        public Task<string> Updatejoblocation(JobLocationClassify jobLocation)
        {
            throw new NotImplementedException();
        }
    }
}
