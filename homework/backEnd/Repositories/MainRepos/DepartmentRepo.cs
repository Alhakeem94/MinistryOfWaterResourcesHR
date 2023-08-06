using homework.backEnd.Interfaces.MainInterface;
using homework.Data;
using homework.Model.MainClass;
using Microsoft.EntityFrameworkCore;

namespace homework.backEnd.Repositories.MainRepos
{
    public class DepartmentRepo : IDepartment
    {
        private readonly ApplicationDbContext _dbContext;

        public DepartmentRepo(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<string> AddNewDepartment(DepartmentModel departmentModel)
        {
            var depName = await _dbContext.DeparmentTable.FirstOrDefaultAsync(a => a.DepartmentName == departmentModel.DepartmentName);
            if (depName == null)
            {
                await _dbContext.DeparmentTable.AddAsync(departmentModel);
                await _dbContext.SaveChangesAsync();
                return "The Department Table has been successfully added to the database";

            }
            
            return "The Department Table already exists in the database";

        }

        public async Task<string> RemoveNewDepartment(int id)
        {
            var obj = _dbContext.DeparmentTable.FirstOrDefault(a => a.Id == id);
            if (obj != null)
            {
                _dbContext.Remove(obj);
                await _dbContext.SaveChangesAsync();
                return "The Department Table has been successfully Removed to the database";
            }
            return "Can't Removed Department from the database";
        }

        public Task<string> UpdateNewDepartment(DepartmentModel departmentModel)
        {
            throw new NotImplementedException();
        }
    }
}
