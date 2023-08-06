using HR.Models.Classifies;

namespace homework.backEnd.Interfaces.ClassifiesInterface
{
    public interface IGeoLocation
    {
        public Task<string> AddNewlocation(GeoLocationClassify geoLocationClassify);
        public Task<string> RemoveNewlocation(int id);
        public Task<string> UpdateNewlocation(GeoLocationClassify geoLocationClassify);
    }
}
