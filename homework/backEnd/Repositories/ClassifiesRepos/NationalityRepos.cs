using homework.backEnd.Interfaces.ClassifiesInterface;
using homework.Data;
using HR.Models.Classifies;

namespace homework.backEnd.Repositories.ClassifiesRepos
{
    public class NationalityRepos : INationality
    {
        private ApplicationDbContext _dbContext;

        public NationalityRepos(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<string> AddNewNationality(NationalityClassify NationalityClassify)
        {
            var name = _dbContext.NationalityTable.FirstOrDefault(a =>
                a.NationalityName == NationalityClassify.NationalityName);
            if (name == null)
            {
                await _dbContext.NationalityTable.AddAsync(NationalityClassify);
                await _dbContext.SaveChangesAsync();
                return "The Nationality Table has been successfully added to the database";
            }
            return "The Nationality Table already exists in the database";
        }

        public async Task<string> RemoveNewNationality(int id)
        {
            var obj = _dbContext.NationalityTable.FirstOrDefault(a => a.id == id);
            if (obj != null)
            {
                _dbContext.NationalityTable.Remove(obj);
                await _dbContext.SaveChangesAsync();
                return "The Nationality has been successfully removed from the database";
            }
            return "Can't Remove Nationality from database";
        }

        public Task<string> UpdateNewNationality(NationalityClassify NationalityClassify)
        {
            throw new NotImplementedException();
        }
    }
}
