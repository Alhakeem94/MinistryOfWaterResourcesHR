using homework.backEnd.Interfaces.ClassifiesInterface;
using homework.Data;
using HR.Models.Classifies;

namespace homework.backEnd.Repositories.ClassifiesRepos
{
    public class StageRepos : IStage
    {
        private ApplicationDbContext _dbContext;

        public StageRepos(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<string> AddStage(StageClassify stage)
        {
            throw new NotImplementedException();
        }

        public Task<string> RemoveStage(StageClassify stage)
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateStage(StageClassify stage)
        {
            throw new NotImplementedException();
        }
    }
}
