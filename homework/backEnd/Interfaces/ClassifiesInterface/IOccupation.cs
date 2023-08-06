using HR.Models.Classifies;

namespace homework.backEnd.Interfaces.ClassifiesInterface
{
    public interface IOccupation
    {
        public Task<string> AddOccupation(OccupationClassify occupation);
        public Task<string> RemoveOccupation(int id);
        public Task<string> UpdateOccupation(OccupationClassify occupation);
    }
}
