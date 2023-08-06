using HR.Models.Classifies;

namespace homework.backEnd.Interfaces.ClassifiesInterface
{
    public interface IGovernorate
    {
        public Task<string> AddNewGovernorate(GovernorateClassify governorateClassify);
        public Task<string> UpdateNewGovernorate(int id);
        public Task<string> RemoveNewGovernorate(GovernorateClassify governorateClassify);
    }
}
