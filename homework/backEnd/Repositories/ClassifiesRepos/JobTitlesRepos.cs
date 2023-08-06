using homework.backEnd.Interfaces.ClassifiesInterface;
using homework.Data;
using HR.Models.Classifies;

namespace homework.backEnd.Repositories.ClassifiesRepos
{
    public class JobTitlesRepos : IJobTitles
    {
        private readonly ApplicationDbContext _dbContext;

        public JobTitlesRepos(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<string> AddjobTitle(JobTitlesClassify jobTitles)
        {
            var name = _dbContext.JobTitlesTable.FirstOrDefault(a => a.JobTitle == jobTitles.JobTitle);
            if (name == null)
            {
                await _dbContext.JobTitlesTable.AddAsync(jobTitles);
                await _dbContext.SaveChangesAsync();
                return "The Job title Table has been successfully added to the database";
            }
            return "The Job title Table already exists in the database";
        }

        public async Task<string> RemovejobTitle(int id)
        {
            var obj = _dbContext.JobTitlesTable.FirstOrDefault(a => a.Id == id);
            if (obj != null)
            {
                _dbContext.JobTitlesTable.Remove(obj);
                await _dbContext.SaveChangesAsync();
                return "The Job Title has been successfully removed from the database";
            }
            return "Can't Remove Job Title from database";
        }

        public Task<string> UpdatejobTitle(JobTitlesClassify jobTitles)
        {
            throw new NotImplementedException();
        }
    }
}
