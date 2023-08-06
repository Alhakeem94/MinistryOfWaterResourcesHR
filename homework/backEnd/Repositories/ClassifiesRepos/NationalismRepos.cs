using homework.backEnd.Interfaces.ClassifiesInterface;
using homework.Data;
using HR.Models.Classifies;

namespace homework.backEnd.Repositories.ClassifiesRepos
{
    public class NationalismRepos : INationalism
    {
        private readonly ApplicationDbContext _dbContext;

        public NationalismRepos(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<string> AddNewNationalism(NationalismClassify NationalismClassify)
        {
            var name = _dbContext.NationalismTable.FirstOrDefault(a => a.Nationalism == NationalismClassify.Nationalism);
            if (name == null)
            {
                await _dbContext.NationalismTable.AddAsync(NationalismClassify);
                await _dbContext.SaveChangesAsync();
                return "The Nationalism Table has been successfully added to the database";
            }
            return "The Nationalism Table already exists in the database";
        }

        public async Task<string> UpdateNewNationalism(int id)
        {
            var obj = _dbContext.NationalismTable.FirstOrDefault(a => a.id == id);
            if (obj != null)
            {
                _dbContext.NationalismTable.Remove(obj);
                await _dbContext.SaveChangesAsync();
                return "The Nationalism has been successfully removed from the database";
            }
            return "Can't Remove Nationalism from database";
        }

        public Task<string> RemoveNewNationalism(NationalismClassify nationalism)
        {
            throw new NotImplementedException();
        }
    }
}
