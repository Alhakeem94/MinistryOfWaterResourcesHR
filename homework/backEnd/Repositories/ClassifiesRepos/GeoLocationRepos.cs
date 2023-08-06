using homework.backEnd.Interfaces.ClassifiesInterface;
using homework.Data;
using HR.Models.Classifies;

namespace homework.backEnd.Repositories.ClassifiesRepos
{
    public class GeoLocationRepos : IGeoLocation
    {
        private readonly ApplicationDbContext _dbContext;

        public GeoLocationRepos(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<string> AddNewlocation(GeoLocationClassify geoLocationClassify)
        {
            var name = _dbContext.GeoLocationTable.FirstOrDefault(a =>
                a.GeoLocation == geoLocationClassify.GeoLocation);
            if (name == null)
            {
                await _dbContext.GeoLocationTable.AddAsync(geoLocationClassify);
                await _dbContext.SaveChangesAsync();
                return "The Geo Location Table has been successfully added to the database";
            }
            else
            {
                return "The Geo Location Table already exists in the database";
            }
        }

        public async Task<string> RemoveNewlocation(int id)
        {
            var obj = _dbContext.GeoLocationTable.FirstOrDefault(a => a.Id == id);
            if (obj != null)
            {
                _dbContext.GeoLocationTable.Remove(obj);
                await _dbContext.SaveChangesAsync();
                return "The Geo Location has been successfully removed from the database";
            }
            return "Can't Remove Geo Location state from database";
        
        }

        public Task<string> UpdateNewlocation(GeoLocationClassify geoLocationClassify)
        {
            throw new NotImplementedException();
        }
    }
}
