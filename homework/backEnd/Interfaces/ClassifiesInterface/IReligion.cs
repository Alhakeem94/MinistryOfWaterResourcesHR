using HR.Models.Classifies;

namespace homework.backEnd.Interfaces.ClassifiesInterface
{
    public interface IReligion
    {
        public Task<string> AddReligion(ReligionClassify religion);
        public Task<string> RemoveReligion(ReligionClassify religion);
        public Task<string> UpdateReligion(ReligionClassify religion);
    }
}
