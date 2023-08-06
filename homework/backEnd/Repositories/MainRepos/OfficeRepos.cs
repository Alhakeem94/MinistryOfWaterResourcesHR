using homework.backEnd.Interfaces.MainInterface;
using homework.Data;
using homework.Model.MainClass;
using Microsoft.EntityFrameworkCore;

namespace homework.backEnd.Repositories.MainRepos
{
    public class OfficeRepos : IOffice
    {
        private readonly ApplicationDbContext _dbContext;

        public OfficeRepos(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<string> AddOffice(OfficeModel officeModel)
        {
            var checkOfficeName = await _dbContext.OfficeTable.FirstOrDefaultAsync(a => a.OfficeName == officeModel.OfficeName);
            if (checkOfficeName == null)
            {
                await _dbContext.OfficeTable.AddAsync(officeModel);
                await _dbContext.SaveChangesAsync();
                return "The Office Table has been successfully added to the database";

            }

            return "The Office Table already exists in the database";
        }

        public async Task<string> RemoveOffice(int id)
        {
            var obj = _dbContext.OfficeTable.FirstOrDefault(a => a.Id == id);
            if (obj != null)
            {
                _dbContext.Remove(obj);
                await _dbContext.SaveChangesAsync();
                return "The Employe has been successfully Removed to the database";
            }
            return "Can't Remove Employe from database";
        }

        public Task<string> UpdateOffice(OfficeModel officeModel)
        {
            throw new NotImplementedException();
        }

        public async Task<List<OfficeModel>> GetAllOffices()
        {
            return await _dbContext.OfficeTable.ToListAsync();
        }
    }
}
