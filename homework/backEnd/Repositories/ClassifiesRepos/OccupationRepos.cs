using homework.backEnd.Interfaces.ClassifiesInterface;
using homework.Data;
using HR.Models.Classifies;

namespace homework.backEnd.Repositories.ClassifiesRepos
{
    public class OccupationRepos : IOccupation
    {
        private readonly ApplicationDbContext _dbContext;

        public OccupationRepos(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<string> AddOccupation(OccupationClassify occupation)
        {
            var name = _dbContext.OccupationTable.FirstOrDefault(a =>
                a.UserName == occupation.UserName);
            if (name == null)
            {
                await _dbContext.OccupationTable.AddAsync(occupation);
                await _dbContext.SaveChangesAsync();
                return "The occupation Table has been successfully added to the database";
            }
            return "The occupation Table already exists in the database";
        }

        public async Task<string> RemoveOccupation(int id)
        {
            var obj = _dbContext.OccupationTable.FirstOrDefault(a => a.Id == id);
            if (obj != null)
            {
                _dbContext.OccupationTable.Remove(obj);
                await _dbContext.SaveChangesAsync();
                return "The Occupation has been successfully removed from the database";
            }
            return "Can't Remove Occupation from database";
        }

        public Task<string> UpdateOccupation(OccupationClassify occupation)
        {
            throw new NotImplementedException();
        }
    }
}
