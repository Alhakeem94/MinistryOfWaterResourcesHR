using HR.Models.Classifies;

namespace homework.backEnd.Interfaces.ClassifiesInterface
{
    public interface INationalism
    {
        public Task<string> AddNewNationalism(NationalismClassify NationalismClassify);
        public Task<string> UpdateNewNationalism(int id);
        public Task<string> RemoveNewNationalism(NationalismClassify nationalism);
    }
}
