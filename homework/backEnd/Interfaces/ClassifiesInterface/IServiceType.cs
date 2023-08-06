using HR.Models.Classifies;

namespace homework.backEnd.Interfaces.ClassifiesInterface
{
    public interface IServiceType
    {
        public Task<string> AddServiceType(ServiceTypeClassify serviceType);
        public Task<string> RemoveServiceType(int id);
        public Task<string> UpdateServiceType(ServiceTypeClassify serviceType);
    }
}
