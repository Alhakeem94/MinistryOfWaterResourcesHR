using homework.backEnd.Interfaces.ClassifiesInterface;
using homework.Data;
using HR.Models.Classifies;

namespace homework.backEnd.Repositories.ClassifiesRepos
{
    public class JobDegreeRepos : IJobDegree
    {
        private readonly ApplicationDbContext _dbContext;

        public JobDegreeRepos(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<string> AddJobDgree(JobDegreeClassify jobDegree)
        {
            var name = _dbContext.JobDegreeTable.FirstOrDefault(a => a.JobDegree == jobDegree.JobDegree);
            if (name == null)
            {
                await _dbContext.JobDegreeTable.AddAsync(jobDegree);
                await _dbContext.SaveChangesAsync();
                return "The Job Degree Table has been successfully added to the database";
            }

            return "The Job Degree Table already exists in the database";
        }

        public async Task<string> RemoveJobDgree(int id)
        {
            var obj = _dbContext.JobDegreeTable.FirstOrDefault(a=>a.Id == id);
            if (obj != null)
            {
                _dbContext.JobDegreeTable.Remove(obj);
                await _dbContext.SaveChangesAsync();
                return "The Job Degree has been successfully removed from the database";
            }
            return "Can't Remove JobDegree from database";
        
        }

        public Task<string> UpdateJobDgree(JobDegreeClassify jobDegree)
        {
            throw new NotImplementedException();
        }
    }
}
