using HR.Models.Classifies;

namespace homework.backEnd.Interfaces.ClassifiesInterface
{
    public interface IService
    {
        public Task<string> AddService(ServiceClassify service);
        public Task<string> RemoveService(int id);
        public Task<string> UpdateService(ServiceClassify service);
    }
}
