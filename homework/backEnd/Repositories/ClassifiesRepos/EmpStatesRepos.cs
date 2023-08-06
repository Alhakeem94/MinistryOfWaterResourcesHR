using homework.backEnd.Interfaces.ClassifiesInterface;
using homework.Data;
using HR.Models.Classifies;

namespace homework.backEnd.Repositories.ClassifiesRepos
{
    public class EmpStatesRepos : IEmpStates
    {
        private readonly ApplicationDbContext _dbContext;

        public EmpStatesRepos(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<string> AddNewEmpstates(EmpStatesClassify empStatesClassify)
        {
            var name = _dbContext.EmpStatesTable.FirstOrDefault(a => a.EmpStates == empStatesClassify.EmpStates);
            if (name == null)
            {
                await _dbContext.EmpStatesTable.AddAsync(empStatesClassify);
                await _dbContext.SaveChangesAsync();
                return "The Emp states Table has been successfully added to the database";
            }
            else
            {
                return "The Emp states Table already exists in the database";
            }
        }

        public async Task<string> RemoveNewEmpstates(int id)
        {
            var obj = _dbContext.EmpStatesTable.FirstOrDefault(a=> a.Id == id);
            if (obj != null)
            {
                _dbContext.EmpStatesTable.Remove(obj);
                await _dbContext.SaveChangesAsync();
                return "The Employ state has been successfully removed from the database";
            }
            return "Can't Remove Employ state from database";
        
        }

        public Task<string> UpdateNewEmpstates(EmpStatesClassify empStatesClassify)
        {
            throw new NotImplementedException();
        }
    }
}
