using homework.backEnd.Interfaces.ClassifiesInterface;
using homework.Data;
using HR.Models.Classifies;

namespace homework.backEnd.Repositories.ClassifiesRepos
{
    public class PositionRepos : IPosition
    {
        private readonly ApplicationDbContext _dbContext;

        public PositionRepos(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<string> AddPosition(PositionClassify position)
        {
            var name = _dbContext.PositionTable.FirstOrDefault(a =>
                a.PositionName == position.PositionName);
            if (name == null)
            {
                await _dbContext.PositionTable.AddAsync(position);
                await _dbContext.SaveChangesAsync();
                return "The position Table has been successfully added to the database";
            }
            return "The position Table already exists in the database";
        }

        public async Task<string> RemovePosition(int id)
        {
            var obj = _dbContext.PositionTable.FirstOrDefault(a => a.Id == id);
            if (obj != null)
            {
                _dbContext.PositionTable.Remove(obj);
                await _dbContext.SaveChangesAsync();
                return "The Position has been successfully removed from the database";
            }
            return "Can't Remove Position from database";
        }

        public Task<string> UpdatePosition(PositionClassify position)
        {
            throw new NotImplementedException();
        }
    }
}
