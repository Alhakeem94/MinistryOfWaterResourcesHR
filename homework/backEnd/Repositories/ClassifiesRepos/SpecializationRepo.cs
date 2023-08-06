using homework.backEnd.Interfaces.ClassifiesInterface;
using homework.Data;
using HR.Models.Classifies;

namespace homework.backEnd.Repositories.ClassifiesRepos
{
    public class SpecializationRepo : ISpecialization
    {
        private readonly ApplicationDbContext _dbContext;

        public SpecializationRepo(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<string> AddSpecializtion(SpecializationClassify specialization)
        {
            var name = _dbContext.SpecializationTable.FirstOrDefault(a =>
                a.Specialization == specialization.Specialization);
            if (name == null)
            {
                await _dbContext.SpecializationTable.AddAsync(specialization);
                await _dbContext.SaveChangesAsync();
                return "The specialization has been successfully added to the database";
            }
            return "The specialization Table already exists in the database";
        }

        public async Task<string> RemoveSpecializtion(int id)
        {
            var obj = _dbContext.SpecializationTable.FirstOrDefault(a => a.Id == id);
            if (obj != null)
            {
                _dbContext.SpecializationTable.Remove(obj);
                await _dbContext.SaveChangesAsync();
                return "The Specialization has been successfully removed from the database";
            }
            return "Can't Remove Specialization from database";
        }

        public Task<string> UpdateSpecializtion(SpecializationClassify specialization)
        {
            throw new NotImplementedException();
        }
    }
}
