using homework.backEnd.Interfaces.ClassifiesInterface;
using homework.Data;
using HR.Models.Classifies;

namespace homework.backEnd.Repositories.ClassifiesRepos
{
    public class GovernorateRepos : IGovernorate
    {
        private ApplicationDbContext _dbContext;

        public GovernorateRepos(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<string> AddNewGovernorate(GovernorateClassify governorateClassify)
        {
            var name = _dbContext.GovernoraTable.FirstOrDefault(a =>
                a.GovernorateName == governorateClassify.GovernorateName);
            if (name == null)
            {
                await _dbContext.GovernoraTable.AddAsync(governorateClassify);
                await _dbContext.SaveChangesAsync();
                return "The Governorate Table has been successfully added to the database";
            }
            else
            {
                return "The Governorate Table already exists in the database";
            }
        }

        public async Task<string> UpdateNewGovernorate(int id)
        {
            var obj = _dbContext.GovernoraTable.FirstOrDefault(a => a.id == id);
            if (obj != null)
            {
                _dbContext.GovernoraTable.Remove(obj);
                await _dbContext.SaveChangesAsync();
                return "The Governorate has been successfully removed from the database";
            }
            return "Can't Remove Governorate from database";
        }

        public Task<string> RemoveNewGovernorate(GovernorateClassify governorateClassify)
        {
            throw new NotImplementedException();
        }
    }
}
