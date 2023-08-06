using HR.Models.Classifies;

namespace homework.backEnd.Interfaces.ClassifiesInterface
{
    public interface ISpecialization
    {
        public Task<string> AddSpecializtion(SpecializationClassify specialization);
        public Task<string> RemoveSpecializtion(int id);
        public Task<string> UpdateSpecializtion(SpecializationClassify specialization);
    }
}
