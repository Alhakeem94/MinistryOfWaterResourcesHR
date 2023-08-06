using homework.backEnd.Interfaces.ClassifiesInterface;
using homework.Data;
using HR.Models.Classifies;

namespace homework.backEnd.Repositories.ClassifiesRepos
{
    public class MaritalStatusRepos : IMaritalStatus
    {
        private readonly ApplicationDbContext _dbContext;

        public MaritalStatusRepos(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<string> Addmaritalstatus(MaritalStatusClassify MaritalStatusClassify)
        {
            var name = _dbContext.MaritalStatusTable.FirstOrDefault(a =>
                a.MaritalStatus == MaritalStatusClassify.MaritalStatus);
            if (name == null)
            {
                await _dbContext.MaritalStatusTable.AddAsync(MaritalStatusClassify);
                await _dbContext.SaveChangesAsync();
                return "The Marital Status Table has been successfully added to the database";
            }
            return "The Marital Status Table already exists in the database";
        }

        public Task<string> Removemaritalstatus(MaritalStatusClassify maritalStatus)
        {
            throw new NotImplementedException();
        }

        public Task<string> Updatemaritalstatus(MaritalStatusClassify maritalStatus)
        {
            throw new NotImplementedException();
        }
    }
}
