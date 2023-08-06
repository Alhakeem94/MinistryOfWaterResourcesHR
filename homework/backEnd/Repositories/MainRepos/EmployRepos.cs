using homework.backEnd.Interfaces.MainInterface;
using homework.Data;
using homework.Model.MainClass;
using Microsoft.EntityFrameworkCore;

namespace homework.backEnd.Repositories.MainRepos
{
    public class EmployRepos : IEmploye
    {
        private readonly ApplicationDbContext _dbContext;

        public EmployRepos(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<string> AddEmploye(EmployeModel employeModel)
        {
            var employeName = await _dbContext.EmployTable.FirstOrDefaultAsync(a => a.FirstName == employeModel.FirstName);
            if (employeName == null)
            {
                await _dbContext.EmployTable.AddAsync(employeModel);
                await _dbContext.SaveChangesAsync();
                return "The Office Table has been successfully added to the database";

            }
            else
            {
                return "The Office Table already exists in the database";
            }
        }

        public async Task<string> RemoveEmploye(int id)
        {
            EmployeModel? obj = await _dbContext.EmployTable.FirstOrDefaultAsync(a => a.Id == id);
            if (obj != null)
            {
                _dbContext.Remove(obj);
                await _dbContext.SaveChangesAsync();
                return "The Employe has been successfully added to the database";
            }
            return "can't find Employe record at the database";
        }

        public Task<string> UpdateEmploye(EmployeModel employeModel)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> CheckIfUserExistsInDB(string empNumber)
        {
            var checkIfUserExists = await _dbContext.EmployTable.FirstOrDefaultAsync(a => a.EmpNumber == empNumber);

            if (checkIfUserExists is null)
            {
                return false;
            }

            return true;
        }
    }
}
