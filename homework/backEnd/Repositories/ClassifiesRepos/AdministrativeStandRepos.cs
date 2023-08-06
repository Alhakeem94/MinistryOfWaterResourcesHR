using homework.backEnd.Interfaces.ClassifiesInterface;
using homework.Data;
using HR.Models.Classifies;

namespace homework.backEnd.Repositories.ClassifiesRepos
{
    public class AdministrativeStandRepos : IAdministrativeStand
    {
        private readonly ApplicationDbContext _dbContext;

        public AdministrativeStandRepos(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<string> AddNewAdministrationStand(AdministrativeStandClassify administrativeStandClassify)
        {
            var name =  _dbContext.AdministrativeTable.FirstOrDefault(a=>a.AdministrativeSituation == 
            administrativeStandClassify.AdministrativeSituation);

            if (name == null)
            {
                await _dbContext.AdministrativeTable.AddAsync(administrativeStandClassify);
                await _dbContext.SaveChangesAsync();
                return "The AdministrationStand Table has been successfully added to the database";
            }
            else
            {
                return "The AdministrationStand Table already exists in the database";
            }
        }

        public async Task<string> RemoveAdministrationStand(int id)
        {
            var obj = _dbContext.AdministrativeTable.FirstOrDefault(a => a.Id == id);
            if (obj != null)
            {
                _dbContext.AdministrativeTable.Remove(obj);
                await _dbContext.SaveChangesAsync();
                return "The Administration Stand has been successfully removed from the database";
            }
            return "Can't Remove Administration Stand from database";
        }

        public Task<string> UpdateAdministrationStand(AdministrativeStandClassify administrativeStandClassify)
        {
            throw new NotImplementedException();
        }
    }
}
