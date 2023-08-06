using HR.Models.Classifies;

namespace homework.backEnd.Interfaces.ClassifiesInterface
{
    public interface IServiceStatus
    {
        public Task<string> AddServiceStatus(ServiceStatusClassify serviceStatus);
        public Task<string> RemoveServiceStatus(int id);
        public Task<string> UpdateServiceStatus(ServiceStatusClassify serviceStatus);
    }
}
