using HR.Models.Classifies;

namespace homework.backEnd.Interfaces.ClassifiesInterface
{
    public interface INationality
    {
        public Task<string> AddNewNationality(NationalityClassify NationalityClassify);
        public Task<string> RemoveNewNationality(int id);
        public Task<string> UpdateNewNationality(NationalityClassify NationalityClassify);
    }
}
