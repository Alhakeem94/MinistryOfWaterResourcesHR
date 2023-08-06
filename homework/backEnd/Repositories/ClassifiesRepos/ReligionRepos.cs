using homework.backEnd.Interfaces.ClassifiesInterface;
using homework.Data;
using HR.Models.Classifies;

namespace homework.backEnd.Repositories.ClassifiesRepos
{
    public class ReligionRepos : IReligion
    {
        private ApplicationDbContext _dbContext;

        public ReligionRepos(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<string> AddReligion(ReligionClassify religion)
        {
            throw new NotImplementedException();
        }

        public Task<string> RemoveReligion(ReligionClassify religion)
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateReligion(ReligionClassify religion)
        {
            throw new NotImplementedException();
        }
    }
}
